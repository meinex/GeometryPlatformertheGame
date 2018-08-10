using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour {


	//Start First level
	public void OnStartGame() {
		SceneManager.LoadScene ("SampleScene", LoadSceneMode.Single);
	}

	public void Exit() {
		Application.Quit ();
	}
}
