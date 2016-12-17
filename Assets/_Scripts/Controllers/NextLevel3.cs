using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel3 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("level_3");
    }
}
