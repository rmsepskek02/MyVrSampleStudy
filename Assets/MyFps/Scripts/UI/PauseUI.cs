using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

namespace MyFps
{
    public class PauseUI : MonoBehaviour
    {
        #region Variables
        public GameObject pauseUI;

        public SceneFader fader;
        [SerializeField] private string loadToScene = "MainMenu";

        public GameObject thePlayer;
        #endregion

        private void Start()
        {

        }

        private void Update()
        {
            // 새로운 Input System 방식
            //if (Keyboard.current.escapeKey.wasPressedThisFrame)
            //{
            //    Toggle();
            //}
        }

        public void Toggle()
        {
            pauseUI.SetActive(!pauseUI.activeSelf);

            if (pauseUI.activeSelf) //pause 창이 오픈 될때, 사운드? && !isSequence
            {
                //thePlayer.GetComponent<FirstPersonController>().enabled = false;
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                Time.timeScale = 0f;
            }
            else //pause 창이 클로즈 될때
            {
                //thePlayer.GetComponent<FirstPersonController>().enabled = true;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                Time.timeScale = 1f;
            }
        }

        public void Menu()
        {
            Time.timeScale = 1f;

            //씬 종료 처리 ...
            AudioManager.Instance.StopBgm();

            fader.FadeTo(loadToScene);
        }
    }
}