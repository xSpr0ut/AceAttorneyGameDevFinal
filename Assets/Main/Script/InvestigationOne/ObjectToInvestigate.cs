using UnityEngine;

public class ObjectToInvestigate : MonoBehaviour
{
    public string knotName;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

        if (hit && hit.collider != null)
        {
            this.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }

        else
        {
            this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }

    void OnMouseDown()
    {
        if (CombinedManager.Instance != null)
        {
            CombinedManager.Instance.PlayKnot(knotName);

            Destroy(this.gameObject);
        }
    }
}
