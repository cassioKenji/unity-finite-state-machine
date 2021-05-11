using System.Collections.Generic;
using UnityEngine;

namespace FStateMachine
{
    public class StateStack : MonoBehaviour
    {
        [SerializeField]
        public Stack<IPlayerState> stack;

        void Awake()
        {
            stack = new Stack<IPlayerState>();
        }
    }    
}
