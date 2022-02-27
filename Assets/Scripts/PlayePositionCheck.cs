using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayePositionCheck : MonoBehaviour
{
    [SerializeField] float maxFallIndex = -10f;
    void Update()
    {
        if(transform.position.y < maxFallIndex)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
