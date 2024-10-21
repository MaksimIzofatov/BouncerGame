using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
	[SerializeField] private Candy _candyPrefab;

	private RandomColor _color;
	private RandomPosition _position;
	private Candy _candy;

	private void Awake()
	{
		_color = GetComponent<RandomColor>();
		_position = GetComponent<RandomPosition>();
	}
	private void Start()
	{
		_candy = Instantiate(_candyPrefab, _position.GetRandomPosition(), _candyPrefab.transform.localRotation);
		_candy.SetColor(_color.GetRandomColor());
		_candy.CandyDestroyed += ChangeParameters;
	}

	private void ChangeParameters()
	{
		_candy.SetColor(_color.GetRandomColor());
		_candy.ChangePosition(_position.GetRandomPosition());
		
	}

	private void OnDisable()
	{
		_candyPrefab.CandyDestroyed -= ChangeParameters;
	}
}
