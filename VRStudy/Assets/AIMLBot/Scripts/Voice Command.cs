using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceCommands : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;

    void Start()
    {
        keywordRecognizer = new KeywordRecognizer(new string[] { "heal me", "stop heal", "heal", "lightning", "summon heals" });
        keywordRecognizer.OnPhraseRecognized += OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Voice command: " + args.text);

        if (args.text == "heal me" || args.text == "heal" || args.text == "lightning" || args.text == "summon heals")
        {
            Debug.Log("healing");
        }
        else if (args.text == "stop heal")
        {
            Debug.Log("Stopped healing");
        }
    }

    void OnDestroy()
    {
        if (keywordRecognizer != null)
        {
            keywordRecognizer.Stop();
            keywordRecognizer.Dispose();
        }
    }
}