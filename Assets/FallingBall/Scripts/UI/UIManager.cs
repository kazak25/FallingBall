using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HelixJump.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] _panels;
        [SerializeField] private GameObject _restartButton;
        
        #region Variables
        public delegate void PanelActive();
        public PanelActive FailedPanelActive;
        public PanelActive FinishPanelActive;

       
        private const byte FAILED = 0, FINISH = 1;
        #endregion

        private void Awake()
        {
            FailedPanelActive += FailedPanel;
            FinishPanelActive += FinishPanel;
        }
        
        [UsedImplicitly]
        public void RestartGame()
        {
            SceneManager.LoadSceneAsync("GameScene");
            _restartButton.SetActive(false);
        }

        private void FailedPanel()
        {
            _panels[FAILED].SetActive(true);
            _restartButton.SetActive(true);
        }
        private void FinishPanel()
        { 
            _panels[FINISH].SetActive(true);
            _restartButton.SetActive(true);
        }
    }
}