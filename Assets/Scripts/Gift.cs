using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer _renderer;
	private Color _color;
	public Color Color => _color;
	public event Action<Color, int> DestroyGift;

	public void SetColor(Color color)
	{
		_renderer.materials[1].color = color;
		_color = color;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.TryGetComponent(out PlayerController player))
		{
			if (player.GetColor == _color)
			{
				DestroyGift?.Invoke(_color, -1);
				Destroy(this.gameObject);
			}
		}
	}
}
