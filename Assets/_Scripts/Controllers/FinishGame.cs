using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("GameOver 1");
    }
}
