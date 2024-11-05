using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterMoveSnowman : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    public void OnInputMouse(int count)
    {
		_text.text = (int.Parse(_text.text) + count).ToString();
	}
}
