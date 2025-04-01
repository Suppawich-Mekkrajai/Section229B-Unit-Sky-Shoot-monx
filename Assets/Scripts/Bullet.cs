using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.CompareTag("Enemy")) 
        {
            Debug.Log("Hit");
            GameManager.Instance.BulletHitTarget(); // GameManager
            //Destroy(gameObject); // 
            //Destroy(other.gameObject); // 
            other.GetComponent<Collider>().enabled = false;
            other.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
