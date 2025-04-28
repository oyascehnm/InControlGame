using UnityEngine;

public class CreditScroller : MonoBehaviour
{
    public float scrollSpeed = 50f;

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        rectTransform.anchoredPosition += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
