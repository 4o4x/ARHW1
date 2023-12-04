using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class SceneSwitcher : MonoBehaviour
{
    public void ChangeScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
        ARSession arSession = FindObjectOfType<ARSession>(); // ARSession örneği bulunuyor
        if (arSession != null)
        {
            arSession.Reset(); // ARSession.Reset() metodu örneği üzerinden çağrılıyor
        }
        else
        {
            Debug.LogError("ARSession not found!");
        }
    }
}
