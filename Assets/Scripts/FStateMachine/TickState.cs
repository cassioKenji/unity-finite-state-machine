using UnityEngine;

namespace FStateMachine
{
    public class TickState : MonoBehaviour
    {
        public StateStack states;

        [SerializeField]
        public IPlayerState currentState;
        public IPlayerState lastState;
        public IPlayerState peekedState;

        void Start()
        {
            states = GetComponent<StateStack>();
        }

        private void Update()
        {
            SetCurrentState();
            currentState.OnStateTick();
        }

        private void SetCurrentState()
        {
            peekedState = states.stack.Peek();
            
            if (lastState == peekedState) return;
            lastState = currentState = peekedState;
        }
    }
}
