using UnityEngine;

public class ButtonControler : MonoBehaviour
{
    public PlaceTrackImages placeTrackImages; // PlaceTrackImages scriptine erişim

    public void MovePrefabForward()
    {
        if (placeTrackImages != null && placeTrackImages.prefab != null)
        {
            placeTrackImages.prefab.transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }

    public void MovePrefabBackward()
    {
        if (placeTrackImages != null && placeTrackImages.prefab != null)
        {
            placeTrackImages.prefab.transform.Translate(Vector3.back * Time.deltaTime);
        }
    }

    public void MovePrefabLeft()
    {
        if (placeTrackImages != null && placeTrackImages.prefab != null)
        {
            placeTrackImages.prefab.transform.Translate(Vector3.left * Time.deltaTime);
        }
    }

    public void MovePrefabRight()
    {
        if (placeTrackImages != null && placeTrackImages.prefab != null)
        {
            placeTrackImages.prefab.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}