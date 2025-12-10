using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class BackgroundController : MonoBehaviour
{
    public static BackgroundController Instance;

    public Image backgroundImage;

    [System.Serializable]
    public class BGEntry
    {
        public string id;
        public Sprite sprite;
    }

    public List<BGEntry> backgrounds = new List<BGEntry>();
    private Dictionary<string, Sprite> bgDict = new Dictionary<string, Sprite>();

    void Awake()
    {
        Instance = this;

        //Lookup for Dictionary
        foreach (var b in backgrounds)
        {
            bgDict[b.id.ToLower()] = b.sprite;
        }
    }

    public void SetBackground(string id)
    {
        id = id.ToLower();

        if(!bgDict.ContainsKey(id))
        {
            Debug.LogWarning("No background found");
            return;
        }

        backgroundImage.sprite = bgDict[id];
        Debug.Log("Background changed to " + id);
    }
}
