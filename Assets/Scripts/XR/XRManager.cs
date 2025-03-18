using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class XRManager : MonoBehaviour
{
    public static XRManager XRInstance;
    public XRInteractionManager Manager;
    public XROrigin Origin;
    public XRInteractable Current;
    void Awake()
    {
        if(XRInstance == null)
        {
            XRInstance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate(float RotateAmount)
    {
        if (Current != null)
        {
            Current.transform.Rotate(new Vector3(0, RotateAmount, 0));
        }
    }
}
