using Data.ValueObjects;
using Managers;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Controllers.Player
{
    public class PlayerMeshController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private new PlayerManager manager;
        [SerializeField] private new Renderer renderer;

        #endregion
        
        #region Private Variables

        [ShowInInspector] private ScaleData _data;

        #endregion

        #endregion

        public void OnReset()
        {
            
        }

        public void GetMeshData(ScaleData dataScaleData)
        {
            _data = dataScaleData;
        }
    }
}