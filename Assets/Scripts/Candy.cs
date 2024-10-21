using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
	public event Action CandyDestroyed;

	[SerializeField]
	private MeshRenderer _renderer;
	private Color _color;

	public void SetColor(Color color)
	{
		_renderer.materials[0].color = color;
		_color = color;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.TryGetComponent(out PlayerController player))
		{
			player.ChangeColor(_color);
			CandyDestroyed?.Invoke();
			Destroy(this.gameObject);
		}
	}
}
