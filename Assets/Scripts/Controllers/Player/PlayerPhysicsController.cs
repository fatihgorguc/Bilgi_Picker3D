using Managers;
using UnityEngine;

namespace Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour 
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private new PlayerManager manager;
        [SerializeField] private new Rigidbody rigidbody;
        [SerializeField] private new Collider collider;

        #endregion

        #endregion
        
        public void OnReset()
        {
            
        }
    }
}