using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class GiftsSpawner : MonoBehaviour
{
	[SerializeField] private Gift _giftPrefab;
    [SerializeField] private int _countGifts = 6;
	private RandomColor _color;
	private RandomPosition _position;

	private void Awake()
	{
		_color = GetComponent<RandomColor>();
		_position = GetComponent<RandomPosition>();
	}

	private void Start()
	{
		for (int i = 0; i < _countGifts; i++)
		{
			var gift = Instantiate(_giftPrefab, _position.GetRandomPosition(), Quaternion.identity);
			gift.SetColor(_color.GetRandomColor());
		}
	}
}
