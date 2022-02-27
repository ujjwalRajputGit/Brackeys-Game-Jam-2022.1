using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum LevelState
{
    Going = 1,
    Completed = 2,
}
public class LevelCompleteScript : MonoBehaviour
{
    private Vector3 groundCheckerOffset = Vector3.one;
    [SerializeField]private float groundCheckerRadius = 2;
    private LevelState levelState = LevelState.Going;
    [SerializeField] int NextSceneToLoad = 1;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("LevelCOmpleted !!!!!!!!");
    }
    private void Update()
    {
        Collider[] cols = Physics.OverlapSphere(groundCheckerOffset + new Vector3(transform.position.x, transform.position.y,0), groundCheckerRadius);
        for (int i = 0; i < cols.Length; i++)
        {
            Debug.Log("Level Completed!!!!!");
            levelState = LevelState.Completed;
        }
        if(levelState == LevelState.Completed)
        {
            SceneManager.LoadScene(NextSceneToLoad);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + new Vector3(groundCheckerOffset.x, groundCheckerOffset.y), groundCheckerRadius);
    }
}
