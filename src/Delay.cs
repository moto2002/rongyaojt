using System;
using UnityEngine;

public class Delay : MonoBehaviour
{
	public float delayTime = 1f;

	private void Start()
	{
		base.gameObject.SetActiveRecursively(false);
		base.Invoke("DelayFunc", this.delayTime);
	}

	private void DelayFunc()
	{
		base.gameObject.SetActiveRecursively(true);
	}
}
