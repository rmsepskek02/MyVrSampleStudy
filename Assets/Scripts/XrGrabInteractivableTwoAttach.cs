using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVrSample
{
    /// <summary>
    /// 두개의 Attach Point 구현
    /// </summary>
    public class XrGrabInteractivableTwoAttach : XRGrabInteractable
    {
        #region Variables
        public Transform leftAttachTransform;
        public Transform rightAttachTransform;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            // 두개의 Attach Point를 잡는 손에 따라 구분해서 적용
            if (args.interactableObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = leftAttachTransform;
            }
            else if (args.interactableObject.transform.CompareTag("RightHand"))
            {
                attachTransform = rightAttachTransform;
            }
            base.OnSelectEntered(args);
        }
    }
}
