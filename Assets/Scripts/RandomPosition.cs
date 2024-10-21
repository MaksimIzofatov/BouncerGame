using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
	private int _minBorder = -9, _maxBorder = 10;

	public Vector3 GetRandomPosition()
	{
		var positionX = Random.Range(_minBorder, _maxBorder);
		var positionZ = Random.Range(_minBorder, _maxBorder);

		return new Vector3(positionX, 0, positionZ);
	}
}
