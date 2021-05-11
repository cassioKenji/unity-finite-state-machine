using UnityEngine;

namespace FStateMachine
{
    public class FSMController : MonoBehaviour
    {
        public FStateMachine stateMachine;

        public JumpingState jumpingState;
        public IdleState idleState;
    
        void Start()
        {
            stateMachine = GetComponent<FStateMachine>();

            jumpingState = GetComponent<JumpingState>();
            idleState = GetComponent<IdleState>();
        }

        void Update()
        {
            if (Input.GetKeyDown("a"))
            {
                stateMachine.SetState(jumpingState);
            }
        
            if (Input.GetKeyDown("s"))
            {
                stateMachine.SetState(idleState);
            }
        
            //if (Input.GetKeyDown("d"))
            //{
            //    stateMachine.DebugStateMachine();
            //}
        }

        private void OnDisable()
        {
            Debug.Log("diabling state machine controller. below you can see the last state being popped.");
            stateMachine.ExitState();
            stateMachine.ClearStates();
        }
    }
}
