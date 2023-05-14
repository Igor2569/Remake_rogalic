using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class Pause_button : MonoBehaviour
    {
        public GameObject panel;
        public GameObject pause_bt;
        public GameObject resume_bt;
        public void pause()
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
            pause_bt.SetActive(false);
            resume_bt.SetActive(true);
        }
        public void resume()
        {
            panel.SetActive(false);
            Time.timeScale = 1f;
            resume_bt.SetActive(false);
            pause_bt.SetActive(true);
        }
    }
}

