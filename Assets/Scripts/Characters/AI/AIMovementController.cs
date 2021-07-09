using UnityEngine;

namespace Characters.AI
{
    [RequireComponent(typeof(CharacterController))]
    public class AIMovementController : MonoBehaviour
    {
        private CharacterController controller;
    
        private void Awake()
        {
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            // nawMesh
        }
    }
}