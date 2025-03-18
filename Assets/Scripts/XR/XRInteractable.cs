using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class XRInteractable : MonoBehaviour
{
    [SerializeField] List<ARBaseGestureInteractable> SelectionInteractable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < SelectionInteractable.Count; i++)
        {
            SelectionInteractable[i].interactionManager = XRManager.XRInstance.Manager;
            SelectionInteractable[i].xrOrigin = XRManager.XRInstance.Origin;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
