using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class IntController : MonoBehaviour
{
    public TMP_Text textMeshProText;
    public InputField inputField;
    public UnityEngine.UI.Text tospeakbyai;
    public InputField inputtospeak;
    [SerializeField] private Button activatespeachtotextButton;
    [SerializeField] private Button sendtospeakButton;
    [SerializeField] private Button speakButton;
    [SerializeField] private Talking Talking; // Reference to the FaceTarget script

    void Start()
    {
        Talking = GameObject.FindObjectOfType<Talking>(); // Find the instance of FaceTarget script
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (activatespeachtotextButton != null)
            {
                activatespeachtotextButton.onClick.Invoke();
            }
            else
            {
                Debug.LogWarning("Speak Button is not assigned!");
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (textMeshProText != null)
            {
                string text = textMeshProText.text;
                if (inputField != null)
                {
                    inputField.text = text;
                }
                else
                {
                    Debug.LogWarning("InputField is not assigned!");
                }
            }
            else
            {
                Debug.LogWarning("TextMeshProText is not assigned!");
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (sendtospeakButton != null)
            {
                sendtospeakButton.onClick.Invoke();
            }
            else
            {
                Debug.LogWarning("Speak Button is not assigned!");
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            inputtospeak.text = tospeakbyai.text;
            Debug.Log(inputtospeak.text);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (speakButton != null)
            {
                speakButton.onClick.Invoke();
                Talking.playtalk();
            }
            else
            {
                Debug.LogWarning("Speak Button is not assigned!");
            }
        }

    }
}
