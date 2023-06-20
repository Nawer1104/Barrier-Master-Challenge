using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public static Trap Instance;

    public List<DragAndDrop> Cars;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void CheckGameOver()
    {
        if (Cars.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
