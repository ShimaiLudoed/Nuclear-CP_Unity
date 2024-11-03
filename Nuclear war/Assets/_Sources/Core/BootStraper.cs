using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BootStraper : MonoBehaviour
    {
        [SerializeField] private GameObject gamePanel;
        [SerializeField] private GameObject losePanel;
        private Game game;

        void Start()
        {
            game=new Game(gamePanel, losePanel);
            game.StartGame();
        }
    }
}