using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    public GameObject PanelLose;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){   
            Time.timeScale = 0;
            PanelLose.SetActive(true);
        }
    }
}
