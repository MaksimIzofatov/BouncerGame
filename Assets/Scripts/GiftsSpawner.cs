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
	public event Action<Color, int> CreateGift;
	public event Action<Color, int> DestroyGift;

	private void Awake()
	{
		_color = GetComponent<RandomColor>();
		_position = GetComponent<RandomPosition>();
	}

	public void Init()
	{
		for (int i = 0; i < _countGifts; i++)
		{
			var gift = Instantiate(_giftPrefab, _position.GetRandomPosition(), Quaternion.identity);
			gift.SetColor(_color.GetRandomColor());
			CreateGift?.Invoke(gift.Color, 1);
			gift.DestroyGift += OnDestroyGift;
			
		}
	}

	private void OnDestroyGift(Color color, int count)
	{
		DestroyGift?.Invoke(color, count);
	}
}
