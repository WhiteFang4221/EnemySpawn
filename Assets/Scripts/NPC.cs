using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private NPCMoving _npcMoving;

    public void Init(Transform target)
    {
        _npcMoving = GetComponent<NPCMoving>();
        _npcMoving.SetTarget(target);
    }
}
