using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer _renderer;
	private Color _color;

	public void SetColor(Color color)
	{
		_renderer.materials[1].color = color;
		_color = color;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}
}
