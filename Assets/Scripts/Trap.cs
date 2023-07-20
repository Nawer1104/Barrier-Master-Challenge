using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public static Trap Instance;

    public List<GameObject> waypoints;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

}
