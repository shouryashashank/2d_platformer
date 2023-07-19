using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frameSSS
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene("level2");
    }
}
