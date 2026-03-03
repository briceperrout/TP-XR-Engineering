using UnityEngine;

public class GrabLogger : MonoBehaviour
{
    public void OnGrabbed() => Debug.Log("[XR] Table grabbed");
    public void OnReleased() => Debug.Log("[XR] Table released");
}