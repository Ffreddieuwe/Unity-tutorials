using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera triggeredCam;
    public Camera liveCam;

    private void Awake()
    {
        liveCam = Camera.allCameras[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        Collider PlayerCollider = PlayerCharacter.GetComponent<Collider>();

        if (other == PlayerCollider)
        {
            triggeredCam.enabled = true;
            liveCam.enabled = false;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject PlayerCharacter = GameObject.FindGameObjectWithTag("Player");
        Collider PlayerCollider = PlayerCharacter.GetComponent<Collider>();

        if (other == PlayerCollider)
        {
            triggeredCam.enabled = false;
            liveCam.enabled = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
