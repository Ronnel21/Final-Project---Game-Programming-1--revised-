using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {        
        SceneManager.LoadScene("level_2");
    }
}
