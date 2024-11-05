using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private CounterPresents _counterPresents;
    [SerializeField] private CounterMoveSnowman _counterMoveSnowman;
    [SerializeField] private GiftsSpawner _giftsSpawner;
	 private PlayerMovement _move;

	private void Start()
	{
		_giftsSpawner.CreateGift += _counterPresents.OnPresentChange;
		_giftsSpawner.DestroyGift += _counterPresents.OnPresentChange;
		_move = FindFirstObjectByType<PlayerMovement>();
		_move.InputMouse += _counterMoveSnowman.OnInputMouse;
		_giftsSpawner.Init();
	}


}
