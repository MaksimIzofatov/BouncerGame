using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
	[SerializeField] private Candy _candyPrefab;

	private RandomColor _color;
	private RandomPosition _position;

	private void Awake()
	{
		_color = GetComponent<RandomColor>();
		_position = GetComponent<RandomPosition>();
	}
	private void Start()
	{
		Instance();
		_candyPrefab.CandyDestroyed += Instance;
	}

	private void Instance()
	{
		var candy = Instantiate(_candyPrefab, _position.GetRandomPosition(), Quaternion.identity);
		candy.SetColor(_color.GetRandomColor());
	}

	private void OnDisable()
	{
		_candyPrefab.CandyDestroyed -= Instance;
	}
}
