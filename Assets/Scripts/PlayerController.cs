using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Material _material;

	private void Start()
	{
		_material = GetComponent<MeshRenderer>().materials[0];
	}

	public void ChangeColor(Color color) => _material.color = color;
    public Color GetColor => _material.color;
}
