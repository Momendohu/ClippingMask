using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUIGroup : MonoBehaviour {
    [SerializeField]
    public GameObject Marker = null;

    [SerializeField]
    public GameObject Overlay = null;

    [SerializeField]
    public GameObject Finger = null;

    private TutorialGuideButtonMarker tutorialGuideButtonMarker = null;

    void Awake () {

    }

    void Start () {
        tutorialGuideButtonMarker = GameObject.FindObjectOfType<TutorialGuideButtonMarker> ();
        /*if (tutorialGuideButtonMarker) {
            Marker.SetActive (false);
            Overlay.SetActive (false);
            Finger.SetActive (false);
        } else {
            Marker.SetActive (true);
            Overlay.SetActive (true);
            Finger.SetActive (true);
        }*/

        Marker.SetActive (true);
        Overlay.SetActive (true);
        Finger.SetActive (true);

        Marker.GetComponent<RectTransform> ().anchoredPosition =
            tutorialGuideButtonMarker.Button.GetComponent<RectTransform> ().anchoredPosition;

        Finger.GetComponent<RectTransform> ().anchoredPosition =
            tutorialGuideButtonMarker.Button.GetComponent<RectTransform> ().anchoredPosition + new Vector2 (246, 18);
    }

    void Update () {

    }
}