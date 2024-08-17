using StatePattern.Enemy;

namespace StatePattern.StateMachine
{
    // Define an interface for enemy states.
    public interface IState
    {
        public EnemyController Owner { get; set; }
        public void OnStateEnter();
        public void Update();
        public void OnStateExit();
    }
}

