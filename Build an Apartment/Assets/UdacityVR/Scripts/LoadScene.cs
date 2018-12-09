using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

 public string SceneToLoad = "UdacityVR/Scenes/Carnival";

 void Start (){
     StartCoroutine(LoadSceneAsync());
 }
 
 IEnumerator LoadSceneAsync() {
     yield return new WaitForSeconds(5);
     
	 AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneToLoad);
 }
}
