using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyahha : MonoBehaviour {
    [SerializeField]
    public GameObject HyahhaObject = null;

    public void OnPush () {
        StartCoroutine (RotateOnce ());
    }

    private IEnumerator RotateOnce () {
        float time = 0;
        while (true) {
            time += Time.deltaTime;
            HyahhaObject.GetComponent<RectTransform> ().eulerAngles = new Vector3 (0, 0, time * 360);
            if (time >= 1) {
                HyahhaObject.GetComponent<RectTransform> ().eulerAngles = new Vector3 (0, 0, 0);
                break;
            }

            yield return null;
        }
    }
}