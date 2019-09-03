using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorInActionNode : DecisionNode
{
    public string actionToTest = "";

    protected override bool IsTrue()
    {
        if (actionToTest == "")
        {
            throw new System.Exception("action not set up in DecisionNode.IsTrue()?");
        }
        else if (actor.currentAction == actionToTest)
        {
            return true;
        }
        return false;
    }
}
