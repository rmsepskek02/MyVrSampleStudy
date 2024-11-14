using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVrSample
{
    /// <summary>
    /// ±ÇÃÑ ÃÑ¾Ë ¹ß»ç
    /// </summary>
    public class FireBulletOnActivate : MonoBehaviour
    {
        #region Variables
        public GameObject bulletPrefab;
        public Transform firePoint;
        public float bulletSpeed = 20f;


        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
            grabInteractable.activated.AddListener(Fire);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void Fire(ActivateEventArgs args)
        {
            GameObject bulletGo = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bulletGo.GetComponent<Rigidbody>().linearVelocity = transform.forward * bulletSpeed;
            Destroy(bulletGo, 5f);
        }
    }
}
