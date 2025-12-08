using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;
    // Easy access reference to CharacterManager
    // Can call -> CharacterManager.Instance.GetCharacter("Furina") for example


    // All Characters Sorted in Dictionary
    private Dictionary<string, Character> characters = new Dictionary<string, Character>();

    void Awake()
    {
        Instance = this;

        Character[] chars = FindObjectsOfType<Character>();

        // Loop through all characters found
        foreach (Character c in chars)
        {
            //change everything to lower case -> Furina, furina, FURINA will all work
            string key = c.characterName.ToLower();

            //Only add character if they aren't on the dictionary
            //Avoid duplicates
            if(!characters.ContainsKey(key))
                characters.Add(key, c);
        }
    }

    // Get Character by Name
    // Called by DialogueManager when a tag says: #speaker Furina
    // Looks up that character in the dictionary
    public Character GetCharacter(string name)
    {
        //Conver everything to lower case for consistency
        name = name.ToLower();

        //if characters exist in dictionary -> return
        if(characters.ContainsKey(name))
            return characters[name];

        //If not found -> Error
        Debug.LogError("Character not found: " + name);
        return null;
    }

    //Setting Active Speaker
    public void SetActiveSpeaker(Character speaker)
    {
        foreach(Character c in characters.Values)
        {
            //Fade in the speaker
            if(c == speaker)
            {
                c.gameObject.SetActive(c == speaker);
                StartCoroutine(c.FadeTo(1f, 0.25f));
            }

            //Fade out other character
            else
            {
                StartCoroutine(HideCharacter(c));
            }
        }
    }

    //Fades out coroutine + diable character after fading
    public IEnumerator HideCharacter(Character c)
    {
        yield return StartCoroutine(c.FadeTo(0f, 0.25f)); //fade out effect
        c.gameObject.SetActive(false);
    }
}
