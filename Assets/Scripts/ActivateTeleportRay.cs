using UnityEngine;
using UnityEngine.InputSystem;

namespace MySample
{
    /// <summary>
    /// Teleport Ray�� �����ϴ� Ŭ����
    /// </summary>
    public class ActivateTeleportRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTeleportRay;          //�ڷ���Ʈ ���� Ray ������Ʈ
        public GameObject rightTeleportRay;         //�ڷ���Ʈ ������ Ray ������Ʈ

        public InputActionProperty leftActivate;    //���� ��Ʈ�ѷ� activate �Է�
        public InputActionProperty rightActivate;   //������ ��Ʈ�ѷ� activate �Է�
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float leftActivateValue = leftActivate.action.ReadValue<float>();
            float rightActivateValue = rightActivate.action.ReadValue<float>();

            leftTeleportRay.SetActive(leftActivateValue > 0.1f);
            rightTeleportRay.SetActive(rightActivateValue > 0.1f);
        }
    }
}
