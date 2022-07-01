using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PaintBrush : XRGrabInteractable
{
    [SerializeField] private PaintHead paintHead;
    [SerializeField] private GameObject paintPrefab;

    GameObject tempPaint;
    bool hasPaint = false;

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        // Check if the painthead has a color
        if (!paintHead.hasPaintAttached)
            return;

        //Instantiating a paint prefab
        tempPaint = Instantiate(paintPrefab, paintHead.transform.position, Quaternion.identity);
        tempPaint.GetComponent<TrailRenderer>().material = paintHead.GetComponent<MeshRenderer>().material;
        hasPaint = true;
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);
        hasPaint = false;
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        if(hasPaint)
        {
            // The paint will follow the paint head
            tempPaint.transform.position = paintHead.transform.position;
        }
    }
}
