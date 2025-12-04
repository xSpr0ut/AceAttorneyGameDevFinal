using UnityEngine;

[CreateAssetMenu(fileName = "EvidenceSO", menuName = "Scriptable Objects/EvidenceSO")]
public class EvidenceSO : ScriptableObject
{
    public bool selected;
    public int evidenceNo;
    public Sprite evidenceSprite;
    public string evidenceName;
    public string evidenceDesc;
}
