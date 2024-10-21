using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _force;

    private Rigidbody _rb;
    private Camera _camera;

	private void Start()
	{
		_rb = GetComponent<Rigidbody>();
		_camera = Camera.main;
	}

	private void Update()
	{
		
		if (Input.GetMouseButtonDown(0))
		{
			var ray = _camera.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(ray, out var info);

			var norm = (info.point - transform.position).normalized;
			_rb.velocity = Vector3.zero;
			_rb.AddForce(new Vector3(norm.x, 0, norm.z) * _force);
		}
	}
}
