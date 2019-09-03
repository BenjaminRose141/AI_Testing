using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBrain : DecisionTreeBrain
{
    private string result = null;

    //Branches
    private PlayerInRangeNode playerInAggroRange = new  PlayerInRangeNode();
    private PlayerInRangeNode playerInMeleeRange = new PlayerInRangeNode();
    private ActorInActionNode actorInWalkToPlayerInAggro = new ActorInActionNode();
    private ActorInActionNode actorInWalkToPlayerOutAggro = new ActorInActionNode();

    //Leaves
    private ActionNode idleAction = new ActionNode();
    private ActionNode attackAction = new ActionNode();
    private ActionNode walkToPlayerAction = new ActionNode();
    private ActionNode noAction = new ActionNode();


    private void Awake()
    {
#region Actions Setup

        idleAction.actionToReturn = "Idle";
        attackAction.actionToReturn = "Attack";
        walkToPlayerAction.actionToReturn = "WalkToPlayer";
        noAction.actionToReturn = "none";

#endregion

#region Nodes Setup

        // A1
        playerInAggroRange.TrueNode = playerInMeleeRange;
        playerInAggroRange.FalseNode = actorInWalkToPlayerOutAggro;
        playerInAggroRange.range = actor.AggroRange;

        // B1
        playerInMeleeRange.TrueNode = attackAction;
        playerInMeleeRange.FalseNode = actorInWalkToPlayerInAggro;
        playerInMeleeRange.range = actor.MeleeRange;

        // B2
        actorInWalkToPlayerOutAggro.TrueNode = idleAction;
        actorInWalkToPlayerOutAggro.FalseNode = noAction;
        actorInWalkToPlayerOutAggro.actionToTest = "WalkToPlayer";

        // C1
        actorInWalkToPlayerInAggro.TrueNode = noAction;
        actorInWalkToPlayerInAggro.FalseNode = walkToPlayerAction;
        actorInWalkToPlayerInAggro.actionToTest = "WalkToPlayer";
#endregion
    }

    public override string Think()
    {
        result = playerInAggroRange.Evaluate(actor);
        return result;
    }
}
