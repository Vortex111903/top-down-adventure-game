using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }
}
