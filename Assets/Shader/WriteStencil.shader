Shader "WriteStencil"
{
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            // ステンシルバッファの設定
            Stencil{
                // ステンシルバッファ
                Ref 2
                // このシェーダでレンダリングされたピクセルのステンシルバッファを「対象」とするという意味
                Comp Always
                // Replace: 「対象」としたステンシルバッファにRefの値を書き込む、という意味
                Pass Replace
            }

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
            };
            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
                return fixed4(0, 0, 0, 0);
            }
            ENDCG
        }
    }
}