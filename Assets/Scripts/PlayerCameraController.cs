using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class PlayerCameraController : NetworkBehaviour
{
    [SerializeField] GameObject cam;

    public override void OnStartAuthority()
    {
        cam.SetActive(true);
    }
}
