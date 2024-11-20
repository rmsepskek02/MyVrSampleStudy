using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFps
{
    public class AOpening : WorldMenu
    {
        #region Variables
        public GameObject locomotion;
        public SceneFader fader;

        //sequence UI        
        [SerializeField]
        private string sequence01 = "...Where am I?";
        [SerializeField]
        private string sequence02 = "I need get out of here";
        //음성 사운드
        public AudioSource line01;
        public AudioSource line02;
        #endregion

        // Start is called before the first frame update
        protected override void Start()
        {   
            base.Start();
            StartCoroutine(PlaySequence());
        }

        //오프닝 시퀀스
        IEnumerator PlaySequence()
        {
            //0.플레이 캐릭터 비 활성화
            locomotion.SetActive(false);

            //1.페이드인 연출(4초 대기후 페인드인 효과)            
            fader.FromFade(4f + 5f); //5초동안 페이드 효과

            yield return new WaitForSeconds(5f);

            //2.화면 하단에 시나리오 텍스트 화면 출력(3초), 음성 출력
            //(...Where am I?)            
            ShowMenuUI(sequence01);            
            line01.Play();

            yield return new WaitForSeconds(3f);
            //(I need get out of here)
            ShowMenuUI(sequence02);
            line02.Play();

            //3. 3초후에 시나리오 텍스트 없어진다
            yield return new WaitForSeconds(3f);
            HideMenuUI();

            //4.플레이 캐릭터 활성화
            locomotion.SetActive(true);
        }
    }
}