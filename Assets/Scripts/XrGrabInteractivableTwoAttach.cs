using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVrSample
{
    /// <summary>
    /// �ΰ��� Attach Point ����
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
            // �ΰ��� Attach Point�� ��� �տ� ���� �����ؼ� ����
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
