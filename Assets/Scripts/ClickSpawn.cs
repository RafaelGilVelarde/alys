using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class ClickSpawn : MonoBehaviour
{
    [SerializeField] public GameObject Prefab;
    [SerializeField] public Vector3 ClickLocation;
    [SerializeField] AppInputs Click;
    [SerializeField] ARRaycastManager RaycastARManager;
    [SerializeField] ARPlaneManager PlaneARManager;
    [SerializeField] List<ARRaycastHit> hits = new List<ARRaycastHit>();


    Camera mainCamera;
    // Start is called before the first frame update
    private void Awake()
    {
       // Click = new AppInputs();
       // Click.Player.Enable();
        
    }
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnItem()
    {
        GameObject Aux = Instantiate(Prefab);
        Aux.transform.position = ClickLocation;
        gameObject.SetActive(false);
        XRManager.XRInstance.Current = Aux.GetComponent<XRInteractable>();
    }
    private void OnEnable()
    {
        //Click.Player.Fire.performed += Fire;
        EnhancedTouch.EnhancedTouchSupport.Enable();
        EnhancedTouch.TouchSimulation.Enable();
        EnhancedTouch.Touch.onFingerDown += FireTouch;
    }
    private void OnDisable()
    {
        //Click.Player.Fire.performed -= Fire;
        EnhancedTouch.EnhancedTouchSupport.Disable();
        EnhancedTouch.TouchSimulation.Disable();
        EnhancedTouch.Touch.onFingerDown -= FireTouch;
    }

    /*void Fire(InputAction.CallbackContext Context)
    {
        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit RayHit;
        if (Physics.Raycast(ray: ray, out RayHit, 500))
        {
            ClickLocation = RayHit.point;
            Debug.DrawLine(ray.origin, RayHit.point,Color.red,5);
            Debug.Log(RayHit.point);
        }
        SpawnItem();
    }*/
    void FireTouch(EnhancedTouch.Finger finger)
    {
        if (finger.index != 0)
        {
            return;
        }
        if (RaycastARManager.Raycast(finger.currentTouch.screenPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose pose = hits[0].pose;
            ClickLocation = pose.position;
            SpawnItem();
        }
    }
}
