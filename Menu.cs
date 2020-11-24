using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	//GoPlay вызывается кнопками меню
	public void GoPlay(int SceneGo)
    {
		if (SceneGo == 1)
        {
			SceneManager.LoadScene(1);
        }
		if (SceneGo == 2)
		{
			SceneManager.LoadScene(2);
		}
		if (SceneGo == 0)
		{
			SceneManager.LoadScene(0);
		}
	}
}
