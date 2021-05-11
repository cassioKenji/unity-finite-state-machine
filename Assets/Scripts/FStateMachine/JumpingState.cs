using FStateMachine.TextPop;
using UnityEngine;

namespace FStateMachine
{
    public class JumpingState : MonoBehaviour, IPlayerState
    {
        public PopUpStateSpawner popUpStateSpawner;
        public float popTextTimer = 0.2f;

        private void Start()
        {
            popUpStateSpawner = GetComponent<PopUpStateSpawner>();
        }

        public void OnStateTick()
        {
            PopStateLabel();
        }

        public void OnStateEnter()
        {
            Debug.Log("enter jumping!");
        }

        public void OnStateExit()
        {
            Debug.Log("exiting jumping!");
        }
        
        private void PopStateLabel()
        {
            popTextTimer -= Time.deltaTime;

            if (popTextTimer <= 0f)
            {
                popUpStateSpawner.Pop("JumpingState");
                popTextTimer = 0.2f;
            }
        }
    }
}
