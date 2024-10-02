
using UnityEngine;

public class Tele : MonoBehaviour
{
    [SerializeField]
    GameObject[] platforms;
    private int Platforms; //set platorm to different scene
    // Start is called before the first frame update
    void Awake()
    {
        Portals();
    }
    void Portals()
    {

        for (int i = 0; i < platforms.Length; i++)
        {
            int a = 0;
            platforms[i].GetComponent<Platform>().targetSceneId = a+1;

        }

    }
 }
