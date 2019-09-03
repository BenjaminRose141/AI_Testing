using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRangeNode : DecisionNode
{
    public float range = 0f;

    protected override bool IsTrue()
    {
        if(range == 0f)
        {
            throw new System.Exception("range not set up in DecisionNode.IsTrue()?");
        }
        else if(Vector3.Distance(actor.gameObject.transform.position, actor.Player.transform.position) < range)
        {
            return true;
        }
        return false;
    }
}
