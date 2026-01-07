using UnityEngine;
using UnityEngine.SceneManagement;

static class Govno
{
    public static GameObject _audioSource;
}

public class Music : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        if (Govno._audioSource == null) 
        {
            GameObject gameObject = Instantiate(prefab);
            DontDestroyOnLoad(gameObject);
            Govno._audioSource = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
