using UnityEngine;

namespace MyFps
{
    public class Bullet : MonoBehaviour
    {
        #region Variables
        //공격력
        [SerializeField] private float attackDamage = 5f;
        //임팩트
        public GameObject hitImpactPrefab;
        #endregion

        //충돌 체크
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log($"collision: {collision.gameObject.name}");

            GameObject effGo = Instantiate(hitImpactPrefab, transform.position, Quaternion.LookRotation(transform.forward * -1));
            Destroy(effGo, 2f);

            IDamageable damageable = collision.transform.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(attackDamage);
            }

            Destroy(gameObject);
        }
    }
}
