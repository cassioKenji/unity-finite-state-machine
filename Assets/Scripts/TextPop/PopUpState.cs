using TMPro;
using UnityEngine;

namespace FStateMachine
{
    public class PopUpState : MonoBehaviour
    {
        private TextMeshPro _textMeshPro;

        private void Awake()
        {
            _textMeshPro = GetComponent<TextMeshPro>();
        }

        private void Start()
        {
            Destroy(this.gameObject, 0.5f);
        }

        public void SetUp(string state)
        {
            _textMeshPro.SetText(state);
        }

        private void Update()
        {
            transform.Translate(Vector3.up * (50 * Time.deltaTime));
        }
    }
}
