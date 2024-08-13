using UnityEngine;

namespace StatePattern.Enemy
{
    public class IdleState : IState
    {
        private OnePunchManStateMachine stateMachine;
        public OnePunchManController Owner { get; set; }
        private float timer;

        public IdleState(OnePunchManStateMachine onePunchManStateMachine) => this.stateMachine = onePunchManStateMachine;

        public void OnStateEnter() => ResetTimer();

        public void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
                stateMachine.ChangeState(OnePunchManStates.ROTATING);
        }

        public void OnStateExit() => timer = 0;

        private void ResetTimer() => timer = Owner.Data.IdleTime;
    }
}

