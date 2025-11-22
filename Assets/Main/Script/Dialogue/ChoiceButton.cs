using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour
{
    public TMP_Text label;
    public int choiceIndex;

    public void Init(string text, int index, System.Action<int> callback)
    {
        label.text = text;
        choiceIndex = index;
        GetComponent<Button>().onClick.AddListener(() => callback(choiceIndex));
    }
}
