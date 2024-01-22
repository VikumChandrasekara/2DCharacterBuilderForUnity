using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInput : MonoBehaviour
{
    public Button btnClick;
    public InputField inputBody,inputHair,inputFacialHair,inputEyebrow, inputEyes, inputNose, inputMouth, inputEar, inputHelmet, inputArmour, inputPants, inputSkirt, inputGloves, inputBoots, inputCape, inputGun;

    public void Start()
    {
        //attach button evemt
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }
    public void GetInputOnClickHandler()
    {
        Debug.Log("Input : " + inputBody.text  + inputHair.text  + inputFacialHair.text  + inputEyebrow.text + inputEyes.text  + inputNose.text);
    }
}
