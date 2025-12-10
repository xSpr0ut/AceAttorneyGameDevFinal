using UnityEngine;

public class ObjectToInvestigateTwo : MonoBehaviour
{
    public string knotName;
    [SerializeField] private float sizex;
    [SerializeField] private float sizey;

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

        if (hit && hit.collider != null)
        {
            this.transform.localScale = new Vector3(sizex + sizex * 0.1f, sizey + sizey * 0.1f, sizex + sizex * 0.1f);
        }

        else
        {
            this.transform.localScale = new Vector3(sizex, sizey, sizex);
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
