using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Leaves of the Decision Tree - returns what action to take
/// </summary>
public class ActionNode : DecisionNode
{
    public string actionToReturn = null;
        
    public override string Evaluate(Actor thinker)
    {
            return actionToReturn;
    }
}