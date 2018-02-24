using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highscore : MonoBehaviour {

        private static highscore _instance;
        public static highscore Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new highscore();
                return _instance;
            }
        }

        private int _highscore;
        public int Highscore
        {
            get
            {
                return _highscore;
            }
        }

        public highscore()
        {
            _highscore = PlayerPrefs.GetInt("Highscore");
        }

        public void SetHighscore(int score)
        {
            _highscore = score;
            PlayerPrefs.SetInt("Highscore", Highscore);
        }
    
}
