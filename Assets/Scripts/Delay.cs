using UnityEngine;

public class Delay : MonoBehaviour
{
    
    
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("SpawnObject", 60);

    }
    
    void SpawnObject()
    {
       gameObject.SetActive(true);
    }
}
