using UnityEngine;

public class ScaleController : MonoBehaviour
{
    public Transform solarSystemRoot;
    public float minScale = 0.1f;
    public float maxScale = 3.0f;

    public void SetScale(float scaleMultiplier)
    {
        Debug.Log("[INPUT] Scale requested");
        float currentScale = solarSystemRoot.localScale.x;
        float newScale = currentScale * scaleMultiplier;

        if (newScale < minScale || newScale > maxScale)
        {
            Debug.LogWarning("[WARN] Scale clamped");
            newScale = Mathf.Clamp(newScale, minScale, maxScale);
        }

        solarSystemRoot.localScale = Vector3.one * newScale;
        Debug.Log("[XR] Scale applied");
    }
    
    // Raccourcis pour les boutons UI
    public void ZoomIn() => SetScale(1.2f);
    public void ZoomOut() => SetScale(0.8f);
}