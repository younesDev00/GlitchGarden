using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Range(1,5)] [SerializeField] float delayTime = 3;
    private int sceneIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(sceneIndex ==  0)
            StartCoroutine(LoadStart());
    }

    private IEnumerator LoadStart()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(1);
    }

}
