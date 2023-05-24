using UnityEngine;
using UnityEngine.UI;

namespace HelixJump.Score
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private Text[] _uiText;
        [SerializeField] private GameManager _gameManager;

        public delegate void Score(int score);
        public Score ScoreIncrease;

        private int _scoreCounter;

        private void Awake()
        {
            ScoreIncrease += ScoreCounter;
        }

        private void Start()
        {
            _uiText[1].text = PlayerPrefs.GetInt("HighScore").ToString();
        }

        private void ScoreCounter(int score)
        {
            _scoreCounter += score;
            _uiText[0].text = _scoreCounter.ToString();
        }

        private void Update()
        {
            if (_scoreCounter > PlayerPrefs.GetInt("HighScore"))
            {
                _uiText[1].text = _scoreCounter.ToString();
                PlayerPrefs.SetInt("HighScore", _scoreCounter);
                print("Girdi");
            }
        }
    }
}