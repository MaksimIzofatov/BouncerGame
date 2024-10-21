using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Color _color;


    public void ChangeColor(Color color) => _color = color;
    public Color GetColor => _color;
}
