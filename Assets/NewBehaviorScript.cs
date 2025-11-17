using UnityEngine;
using Photon.Pun;

public class NewBehaviorScript : Interactive
{
    private Color originalColor;
    private bool isBlue = false;
    private PhotonView pv;

    void Start()
    {
        pv = GetComponent<PhotonView>();
    }

    public new void Interact()
    {
        if (pv == null)
        {
            return; // Only allow interaction by the owner
        }
        pv.RPC("ToggleColor", RpcTarget.All);
    }

    [PunRPC]
    public void ToggleColor()
    {
        if (!isBlue)
        {
            originalColor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.blue;
            isBlue = true;
        }
        else
        {
            GetComponent<Renderer>().material.color = originalColor;
            isBlue = false;
        }
    }
}
