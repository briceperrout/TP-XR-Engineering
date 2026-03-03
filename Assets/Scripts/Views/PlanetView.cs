using UnityEngine;

public class PlanetView : MonoBehaviour
{
    public PlanetData.Planet planet;

    // C'est cette méthode précise qu'il te manquait !
    public void SetPosition(Vector3 pos)
    {
        transform.localPosition = pos;
    }
}