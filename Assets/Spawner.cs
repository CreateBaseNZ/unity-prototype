using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject(GameObject obj)
    {
        Instantiate(obj, new Vector3(0,5,0), Quaternion.identity);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
