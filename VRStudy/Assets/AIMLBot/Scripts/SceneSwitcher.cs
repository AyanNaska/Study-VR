using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    void Update()
    {
        // Check for key presses
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SwitchScene(1);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            SwitchScene(2);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchScene(3);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchScene(0);
        }
    }

    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}