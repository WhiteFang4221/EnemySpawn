using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<NPC>(out NPC npc))
        {
            Destroy(collision.gameObject);
        }
    }
}
