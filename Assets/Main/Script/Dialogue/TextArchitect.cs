using System.Collections;
using UnityEngine;
using TMPro;

public class TextArchitect
{
    private TextMeshProUGUI tmpro_ui;
    private TextMeshPro tmpro_world;
    public TMP_Text tmpro => tmpro_ui != null ? tmpro_ui : tmpro_world; //put the text on appropriate layer

    public string currentText => tmpro.text;
    public string targetText { get; private set; } = ""; //publicly accessible, privately settable 
    public string preText { get; private set; } = ""; //text before the current text is put on
    private int preTextLength = 0;

    public string fullTargetText => preText + targetText;

    //Build Methods
    // 1. Instant Text 
    // 2. Typewriter 
    // 3. Fade
    public enum BuildMethod { instant, typewriter, fade}
    public BuildMethod buildMethod = BuildMethod.typewriter; //default is set to typewriter

    //Color
    public Color textColor { get { return tmpro.color; } set { tmpro.color = value; } }

    //Speed Vars
    public float speed { get { return baseSpeed * speedMultiplier; } set { speedMultiplier = value; } }
    private const float baseSpeed = 1;
    private float speedMultiplier = 1;

    //Char Generation Speed
    public int charactersPerCycle //charspeed changed based on speed
    {
        get
        {
            if (speed <= 2f) return characterMultiplier;
            if (speed <= 2.5f) return characterMultiplier * 2;
            return characterMultiplier * 3;
        }
    }

    private int characterMultiplier = 1;

    //Fast Forward for Visual Novel
    public bool hurryUp = false;

    //Assign world text + ui text into this script
    public TextArchitect(TextMeshProUGUI tmpro_ui) 
    {
        this.tmpro_ui = tmpro_ui;
    }

    public TextArchitect(TextMeshPro tmpro_world) 
    {
        this.tmpro_world = tmpro_world;
    }

    //----------------Building Text---------------------
    public Coroutine Build(string text)
    {
        preText = "";
        targetText = text;

        Stop();

        buildProcess = tmpro.StartCoroutine(Building());
        return buildProcess;
    }

    //----------------Appending Text--------------------
    //append text to what it is already in the text architect
    public Coroutine Append(string text)
    {
        preText = tmpro.text;
        targetText = text;

        Stop();

        buildProcess = tmpro.StartCoroutine(Building());
        return buildProcess;
    }

    //Additional Vars for Text Generation
    private Coroutine buildProcess = null; //handles text generation
    public bool isBuilding => buildProcess != null; //return true if buildprocess != null

    public void Stop()
    {
        if(!isBuilding) return;

        tmpro.StopCoroutine(buildProcess); //stop process if its running
        buildProcess = null;
    }

    //Build based on the Build Process
    IEnumerator Building()
    {
        Prepare();

        switch(buildMethod)
        {
            case BuildMethod.typewriter:
                yield return Build_Typewriter();
                break;
            
            case BuildMethod.fade:
                yield return Build_Fade();
                break;
        }

        OnComplete();
    }

    private void OnComplete()
    {
        buildProcess = null; //reset build process
        hurryUp = false; //reset hurry up
    }

    public void ForceComplete()
    {
        switch(buildMethod)
        {
            case BuildMethod.typewriter:
                tmpro.maxVisibleCharacters = tmpro.textInfo.characterCount;
                break;
            
            case BuildMethod.fade:
                break;
        }

        Stop();
        OnComplete();
    }

    //----------------Prepare for Switching Between Build Methods----------------
    //Fade - changing alpha values for opacity
    //Ensuring that for instant & typewriter that there wont be any text that becomes not visible
    private void Prepare()
    {
        switch(buildMethod)
        {
            case BuildMethod.instant:
                Prepare_Instant();
                break;
            case BuildMethod.typewriter:
                Prepare_Typewriter();
                break;
            case BuildMethod.fade:
                Prepare_Fade();
                break;
        }
    }

    private void Prepare_Instant()
    {
        tmpro.color = tmpro.color; //reinitialise color
        tmpro.text = fullTargetText; //for instant -> make all the text appear at once hence fullTargetText
        tmpro.ForceMeshUpdate(); //force update for any changes
        tmpro.maxVisibleCharacters = tmpro.textInfo.characterCount; //make sure every character is visible on screen

    }

    private void Prepare_Typewriter()
    {
        //Resetting itself for typewriter mode
        tmpro.color = tmpro.color; //reinitialise color
        tmpro.maxVisibleCharacters = 0; //don't want any text to be visible at the start
        tmpro.text = preText;

        //Make sure all the pretext is visible
        if(preText != "")
        {
            tmpro.ForceMeshUpdate(); //update if there is no text in the preText
            tmpro.maxVisibleCharacters = tmpro.textInfo.characterCount; //set visible characters to length of pretext
        }

        //Add target to prepare for build
        tmpro.text += targetText;
        tmpro.ForceMeshUpdate();
    }

    private void Prepare_Fade()
    {
        
    }

    private IEnumerator Build_Typewriter()
    {
        //Run until max visible characters = character count
        while(tmpro.maxVisibleCharacters < tmpro.textInfo.characterCount)
        {
            tmpro.maxVisibleCharacters += hurryUp ? charactersPerCycle * 5 : charactersPerCycle;
            //if hurryUp = true -> make the characters per cycle faster
            //if hurryUp = false -> default speed

            yield return new WaitForSeconds(0.015f / speed); //slight delay between each character it displays
        }
    }

    private IEnumerator Build_Fade()
    {
        yield return null;
    }
}
