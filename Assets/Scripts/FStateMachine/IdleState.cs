using FStateMachine.TextPop;
using UnityEngine;

namespace FStateMachine
{
    public class IdleState : MonoBehaviour, IPlayerState
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
            Debug.Log("enter idle!");
        }

        public void OnStateExit()
        {
            Debug.Log("exiting idle!");
        }
        
        private void PopStateLabel()
        {
            popTextTimer -= Time.deltaTime;

            if (popTextTimer <= 0f)
            {
                popUpStateSpawner.Pop("IdleState");
                popTextTimer = 0.2f;
            }
        }
    }
}
