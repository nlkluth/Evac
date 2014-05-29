using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour 
{
	public int stopMax;
	public int stopInterval;
	public int currentTime;

	void Start()
	{
		currentTime = stopMax;
	}

	void Update()
	{
		currentTime -= (int)(stopInterval * Time.deltaTime);

		if (stopInterval == 0) 
		{
			stopAction();
		}
	}

	private void stopAction()
	{
		Debug.Log ("stop");
	}
}
