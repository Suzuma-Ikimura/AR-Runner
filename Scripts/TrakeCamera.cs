using UnityEngine;

public class TrakeCamera : DefaultObserverEventHandler
{
    public Rigidbody rb;
    public GameObject playB, panelP;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        rb.useGravity = true;
        
        Time.timeScale= 1;

        panelP.SetActive(false);

        if(!IsInGame.isinGame)
            playB.SetActive(true);

    }


    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        rb.useGravity = false;
        playB.SetActive(false);

        if (IsInGame.isinGame) { 
            Time.timeScale= 0;
            panelP.SetActive(true);
        }
    }
}
