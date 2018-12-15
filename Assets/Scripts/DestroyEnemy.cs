using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy"){

            Destroy(collision.gameObject);
        }
    }
}
