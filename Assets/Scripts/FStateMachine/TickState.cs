using UnityEngine;

namespace FStateMachine
{
    public class TickState : MonoBehaviour
    {
        public StateStack states;

        [SerializeField]
        public IPlayerState currentState;

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
            currentState = states.stack.Peek();
        }
    }
}
