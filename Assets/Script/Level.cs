using UnityEngine;

public class Level : MonoBehaviour {

    //Parameters;
    [SerializeField] int breakableBlocks;  //Serialized for debugging propose;

    //cached reference
    Scene_Loader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<Scene_Loader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }

}
