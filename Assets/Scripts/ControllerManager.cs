using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerManager : MonoBehaviour
{
    [SerializeField] private string thumbStick;
    [SerializeField] private XRRayInteractor rayInteractor;
    [SerializeField] private XRInteractorLineVisual lineVisual;
    [SerializeField] private LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        // deactivate the teleportation
        rayInteractor.enabled = false;
        lineVisual.enabled = false;
        line.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float thumbstickValue = Input.GetAxis(thumbStick);

       // Debug.Log(thumbstickValue);

        if(thumbstickValue < -0.5f)
        {
            // activate the teleportation
            rayInteractor.enabled = true;
            lineVisual.enabled = true;
            line.enabled = true;
        }
    }
}
