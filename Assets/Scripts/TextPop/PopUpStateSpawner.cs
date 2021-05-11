using UnityEngine;

namespace FStateMachine.TextPop
{
    public class PopUpStateSpawner : MonoBehaviour
    {
        [SerializeField]
        private Transform pfStateTickPopUp;

        public void Pop(string state)
        {
            var stateTextCachedTransform = Instantiate(pfStateTickPopUp, Vector3.zero, Quaternion.identity);
            PopUpState popUpState = stateTextCachedTransform.GetComponent<PopUpState>();
            popUpState.SetUp(state);
        }
    }
}
