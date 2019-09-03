using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base Class for Decision Tree Nodes
/// </summary>
public class DecisionNode
{
    protected Actor actor;

    private DecisionNode trueNode;
    private DecisionNode falseNode;

    public DecisionNode TrueNode { get => trueNode; set => trueNode = value; }
    public DecisionNode FalseNode { get => falseNode; set => falseNode = value; }

    public virtual string Evaluate(Actor thinker)
    {
        actor = thinker;

        if (TrueNode!=null && FalseNode!=null)
        {
            if (IsTrue())
            {
                return TrueNode.Evaluate(thinker);
            }
            else
            {
                return FalseNode.Evaluate(thinker);
            }
        }
        else
        {
            throw new System.NotImplementedException();
        }
    }

    protected virtual bool IsTrue()
    {
        throw new System.Exception("Calling unimplemented function DecisionNode.IsTrue()");
    }
}