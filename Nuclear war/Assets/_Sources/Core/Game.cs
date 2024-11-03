using ResourceSys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Game
    {
        private GameObject _gamePanel;
        private GameObject _losePanel;

        public Game(GameObject gamePanel, GameObject losePanel)
        {
            _gamePanel = gamePanel;
            _losePanel = losePanel;
        }
        public void StartGame()
        {
           ResButton.endGame+=EndGame;
           _gamePanel.SetActive(true);
        }
        public void EndGame()
        {
            Debug.Log("проиграл");
            ResButton.endGame-=EndGame;
            _losePanel.SetActive(true);
            _gamePanel.SetActive(false);
        }
    }
}