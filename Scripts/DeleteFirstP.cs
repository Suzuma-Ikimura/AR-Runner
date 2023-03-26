using UnityEngine;

public class DeleteFirstP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Platform")) {
            Destroy(transform.parent.gameObject);
        }
    }
}
