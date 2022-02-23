using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GameJam
{
    enum BallState
    {
        WithPlayer = 0,
        AwayFromPlayer =1,

    }
public class PickUpScript : MonoBehaviour
{
        [SerializeField] private string ballTag = "ball";
        [SerializeField] private float checkRadius = 1f;
        [SerializeField] private Vector3 ballCheckOffset = new Vector3(0,0,0);
        [SerializeField] private float pickOffset = 0.8f;
        [HideInInspector]
        BallState ballState = BallState.AwayFromPlayer;
        private GameObject PlayerObject;

        private void Start()
        {
            PlayerObject = FindObjectOfType<PlayerInput>().gameObject;
        }
        private void Update()
        {
            //StickToPlayer();
            Collider[] cols = Physics.OverlapSphere(ballCheckOffset + new Vector3(transform.position.x, transform.position.y,transform.position.z), checkRadius);
            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].CompareTag("ball"))
                {
                    ballState = BallState.WithPlayer;
                    Debug.Log("Ball State changed");
                    return;
                }
                ballState = BallState.AwayFromPlayer;
            }
        }
        void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position + new Vector3(ballCheckOffset.x, ballCheckOffset.y), checkRadius);
        }
        void StickToPlayer()
        {
            if(ballState == BallState.WithPlayer)
            {
                transform.position = new Vector3(PlayerObject.transform.position.x, PlayerObject.transform.position.y + 3, PlayerObject.transform.position.z);

            }
        }
    }

}
