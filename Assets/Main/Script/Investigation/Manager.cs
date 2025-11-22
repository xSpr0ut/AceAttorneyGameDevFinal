using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
