using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//抽象化は割愛
public class TutorialGuideButtonMarker : MonoBehaviour {
    [SerializeField]
    public UnityEngine.UI.Button Button;

    void Awake () {
        Button.interactable = true;
    }

    void Start () {

    }

    void Update () {

    }
}