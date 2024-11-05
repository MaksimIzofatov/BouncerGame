using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _player;

	private void Awake()
	{
		Instantiate(_player, transform.position, Quaternion.identity);
	}
}
