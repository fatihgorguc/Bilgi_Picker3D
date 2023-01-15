using Data.ValueObjects;
using DG.Tweening;
using Managers;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Controllers.Player
{
    public class PlayerMeshController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerManager manager;
        [SerializeField] private new Renderer renderer;
        [SerializeField] private TextMeshPro scaleText;
        [SerializeField] private ParticleSystem confettiParticle;
        
        //new
        [SerializeField] private TextMeshPro speedText;
        [SerializeField] private TextMeshPro bonusText;


        #endregion

        #region Private Variables

        [ShowInInspector] private ScaleData _data;
        
        //new

        private byte _bonusValue = 1;

        #endregion

        #endregion

        internal void GetMeshData(ScaleData scaleData)
        {
            _data = scaleData;
        }

        internal void ScaleUpPlayer()
        {
            renderer.gameObject.transform.DOScaleX(_data.ScaleCounter, 1).SetEase(Ease.Flash);
        }

        internal void ShowUpScaleText()
        {
            scaleText.DOFade(1, 0f).SetEase(Ease.Flash).OnComplete(() => scaleText.DOFade(0, 0).SetDelay(.65f));
            scaleText.rectTransform.DOAnchorPosY(.85f, .65f).SetRelative(true).SetEase(Ease.OutBounce).OnComplete(() =>
                scaleText.rectTransform.DOAnchorPosY(-.85f, .65f).SetRelative(true));
        }
        
        //new
        internal void ShowUpSpeedText()
        {
            speedText.DOFade(1, 0f).SetEase(Ease.Flash).OnComplete(() => speedText.DOFade(0, 0).SetDelay(.65f));
            speedText.rectTransform.DOAnchorPosY(.85f, .65f).SetRelative(true).SetEase(Ease.OutBounce).OnComplete(() =>
                speedText.rectTransform.DOAnchorPosY(-.85f, .65f).SetRelative(true));
        }
        
        internal void IncreaseBonusValue()
        {
            _bonusValue++;
            SetBonusValue();
        }

        internal void ResetBonusValue()
        {
            _bonusValue = 1;
            SetBonusValue();
        }

        private void SetBonusValue()
        {
            bonusText.text = "X" + _bonusValue;
        }
        
        internal void ShowUpBonusText()
        {
            bonusText.DOFade(1, 0f).SetEase(Ease.Flash).OnComplete(() => bonusText.DOFade(0, 0).SetDelay(.65f));
            bonusText.rectTransform.DOAnchorPosY(.85f, .65f).SetRelative(true).SetEase(Ease.OutBounce).OnComplete(() =>
                bonusText.rectTransform.DOAnchorPosY(-.85f, .65f).SetRelative(true));
        }
        
        internal void PlayConfettiParticle()
        {
            confettiParticle.Play();
            //confettiParticle.SetActive(true);
            //DOVirtual.DelayedCall(2, () => confettiParticle.SetActive(false));
        }
        
        internal void OnReset()
        {
            //new
            ResetBonusValue();
        }
    }
}