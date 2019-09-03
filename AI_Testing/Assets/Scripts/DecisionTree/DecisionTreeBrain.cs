using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTreeBrain : MonoBehaviour
{
    [SerializeField] protected Actor actor;

    public virtual string Think()
    {
        throw new System.NotImplementedException();
        //result = startNode.Evaluate();
        //return result;
    }
}