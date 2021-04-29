using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour
{

	public bool isStart;
	public bool isQuit;

	void OnMouseUp()
	{
		if (isStart)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
		}
		if (isQuit)
		{
			Application.Quit();
		}
	}
}
