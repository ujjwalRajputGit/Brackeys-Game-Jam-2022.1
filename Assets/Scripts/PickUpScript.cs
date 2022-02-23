using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GameJam
{
public class PickUpScript : MonoBehaviour
{
        [SerializeField] private string ballTag = "ball";
        [SerializeField] private float checkRadius = 1f;
        [SerializeField] private Vector3 ballCheckOffset = new Vector3(0,0,0);


        private void OnTriggerStay(Collider other)
        {
            //Debug.Log("are we event colliding here");
            
        }
        private void Update()
        {
            //Debug.Log(gameObject.tag);
            Collider[] cols = Physics.OverlapSphere(ballCheckOffset + new Vector3(transform.position.x, transform.position.y,transform.position.z), checkRadius);
            for (int i = 0; i < cols.Length; i++)
            {
                if (cols[i].CompareTag("ball"))
                {
                    Debug.Log("we are near a ball");
                }
                //if (cols[i].gameObject != gameObject && !cols[i].isTrigger && !cols[i].CompareTag("Portal"))
                //{
                //    if (!isGrounded) isGrounded = true;
                //}
            }
        }
        void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position + new Vector3(ballCheckOffset.x, ballCheckOffset.y), checkRadius);
        }
    }

}
