using UnityEngine;

public class ObjectToInvestigateTwo : MonoBehaviour
{
    public string knotName;
    [SerializeField] private float size;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

        if (hit && hit.collider != null)
        {
            this.transform.localScale = new Vector3(size + 0.15f, size + 0.15f, size + 0.15f);
        }

        else
        {
            this.transform.localScale = new Vector3(size, size, size);
        }
    }

    void OnMouseDown()
    {
        if (CombinedManagerTwo.Instance != null)
        {
            CombinedManagerTwo.Instance.PlayKnot(knotName);

            Destroy(this.gameObject);
        }
    }
}
