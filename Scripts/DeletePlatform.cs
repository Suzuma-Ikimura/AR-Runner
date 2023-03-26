using UnityEngine;

public class DeletePlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Destroy(other.gameObject);
        }

    }
}
