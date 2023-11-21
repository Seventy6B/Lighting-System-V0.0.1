using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLightController : MonoBehaviour
{
    Input.GetKey(KeyCode.Space)
        KeyPressed = true;

    GameObject Light = GameObject.Find("Light");
    Inspector Attribute = Light.GetComponent<Inspector>();
    