using System;
using UnityEngine;

namespace Knife_Hit
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        public static GameManager Instance => _instance;

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
    }

    public enum AppState
    {
        MainMenu = 11,
        Play = 12,
        Win = 13,
        GameOver = 14
    }
}