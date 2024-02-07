using System;
using Players.PlayerStat;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class SceneReloader : MonoBehaviour
{
	[SerializeField] private LayerMask layerMask;

	public static void ReloadScene()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

		SceneManager.LoadScene(currentSceneIndex);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if ((layerMask.value & 1 << other.gameObject.layer) != 0)
			ReloadScene();
	}
}