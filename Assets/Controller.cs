using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.PSVita;

public class Controller : MonoBehaviour
{
    public bool ShowUnityNames = false;

    [Header("Stick")]
    public Text LeftStickText;
    public Text RightStickText;
    public RectTransform LeftStick;
    public RectTransform RightStick;

    [Header("DPad")]
    public Sprite[] dpadSprites;
    public Image dUp;
    public Image dDown;
    public Image dLeft;
    public Image dRight;

    [Header("Buttons")]
    public Sprite[] faceSprites;
    public Image cross;
    public Image circle;
    public Image triangle;
    public Image square;
    public Image select;
    public Image start;
    public Image l;
    public Image r;

    [Header("Touch")]
    public Text touchOutput;
    public Vector2 frontTouch;
    public Vector2 rearTouch;

    public GameObject buttonLabels;
    public GameObject otherLabels;

    private void Update()
    {
        // STICK

        float lh = Input.GetAxis("LSH");
        float lv = Input.GetAxis("LSV");
        float rh = Input.GetAxis("RSH") * 10;
        float rv = Input.GetAxis("RSV") * 10;

        LeftStickText.text = (ShowUnityNames ? "1: " : "H: ") + lh.ToString("F2") + "\n" + (ShowUnityNames ? "2: " : "V: ") + lv.ToString("F2");
        RightStickText.text = (ShowUnityNames ? "4: " : "H: ") + rh.ToString("F2") + "\n" + (ShowUnityNames ? "5: " : "V: ") + rv.ToString("F2");
        
        LeftStick.anchoredPosition = new Vector2(lh * 5, lv * 5) ;
        RightStick.anchoredPosition = new Vector2(rh * 5, rv * 5);

        // DPAD

        dUp.sprite = Input.GetAxis("DV") > 0f ? dpadSprites[1] : dpadSprites[0];
        dDown.sprite = Input.GetAxis("DV") < 0f ? dpadSprites[3] : dpadSprites[2];
        dLeft.sprite = Input.GetAxis("DH") < 0f ? dpadSprites[5] : dpadSprites[4];
        dRight.sprite = Input.GetAxis("DH") > 0f ? dpadSprites[7] : dpadSprites[6];

        // FACE

        cross.sprite = Input.GetButton("Cross") ? faceSprites[1] : faceSprites[0];
        circle.sprite = Input.GetButton("Circle") ? faceSprites[3] : faceSprites[2];
        triangle.sprite = Input.GetButton("Triangle") ? faceSprites[5] : faceSprites[4];
        square.sprite = Input.GetButton("Square") ? faceSprites[7] : faceSprites[6];
        select.sprite = Input.GetButton("Select") ? faceSprites[9] : faceSprites[8];
        start.sprite = Input.GetButton("Start") ? faceSprites[11] : faceSprites[10];
        l.sprite = Input.GetButton("L") ? faceSprites[13] : faceSprites[12];
        r.sprite = Input.GetButton("R") ? faceSprites[15] : faceSprites[14];

        // TOUCH

        frontTouch = Input.GetTouch(0).position;

        touchOutput.text = !ShowUnityNames ? ("Front: (" + frontTouch.x + ", " + frontTouch.y + ")") 
            : ("Input.GetTouch(0): (" + frontTouch.x + ", " + frontTouch.y + ")");

        // OTHER

        buttonLabels.SetActive(ShowUnityNames);
        otherLabels.SetActive(ShowUnityNames);
    }

    public void Toggle()
    {
        EventSystem.current.SetSelectedGameObject(null);
        ShowUnityNames = !ShowUnityNames; 
    }
}
