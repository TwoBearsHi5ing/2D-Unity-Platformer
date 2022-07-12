using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_2_LookForPlayerState : LookForPlayerState
{
    private Enemy2_2 enemy;

    public E2_2_LookForPlayerState(Entity etity, FiniteStateMachine stateMachine, string animBoolName, D_LookForPlayer stateData, Enemy2_2 enemy) : base(etity, stateMachine, animBoolName, stateData)
    {
        this.enemy = enemy;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (isPlayerInMinAgroRange)
        {
            stateMachine.ChangeState(enemy.playerDetectedState);
        }
        else if (isAllTurnsTimeDone)
        {
            stateMachine.ChangeState(enemy.idleState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
