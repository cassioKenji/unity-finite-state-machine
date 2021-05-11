using UnityEngine;

namespace FStateMachine
{
    public class FStateMachine : MonoBehaviour
    {
        public StateStack states;

        IPlayerState _currentState;

        public IdleState idleState;

        private void Start()
        {
            idleState = GetComponent<IdleState>();
            SetState(idleState);
        }

        private void Awake()
        {
            states = GetComponent<StateStack>();
        }

        public void SetState(IPlayerState state)
        {
            if (IsCurrentStateEqualsTo(state)) return;

            PopLastState()?.OnStateExit();

            state.OnStateEnter();
            
            _currentState = state;
            AddStateToStack();
        }

        public void ExitState()
        {
            _currentState?.OnStateExit();
        }

        public bool IsCurrentStateEqualsTo(IPlayerState state)
        {
            return _currentState == state ;
        }
        
        private void AddStateToStack()
        {
            states.stack.Push(_currentState);
        }

        public IPlayerState PopLastState()
        {
            if (states.stack.Count < 1) return null;
            return states.stack.Pop();
        }

        public void DebugStateMachine()
        {
            Debug.Log("stack count: " + states.stack.Count);
            Debug.Log("currentState variable is holding: " + _currentState.ToString() );
            
            while (states.stack.Count > 0)
            {
                Debug.Log(states.stack.Pop()?.ToString());
            }
        }

        public void ClearStates()
        {
            states.stack.Clear();
        }
    }
}
