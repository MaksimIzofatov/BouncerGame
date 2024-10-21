using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
	[SerializeField] private Color[] _colors;

	public Color GetRandomColor()
	{
		var nextColor = Random.Range(0, _colors.Length);
		return _colors[nextColor];
	}
}
