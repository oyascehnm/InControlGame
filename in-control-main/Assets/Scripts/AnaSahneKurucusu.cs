using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnaSahneKurucu : MonoBehaviour
{
    public Texture2D arkaPlanGorseli;

    void Start()
    {
        // Canvas oluþtur
        GameObject canvasObj = new GameObject("Canvas");
        Canvas canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler scaler = canvasObj.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);
        canvasObj.AddComponent<GraphicRaycaster>();

        // Arka Plan (RawImage)
        GameObject bgObj = new GameObject("Background");
        bgObj.transform.SetParent(canvasObj.transform);
        RawImage rawImage = bgObj.AddComponent<RawImage>();
        rawImage.texture = arkaPlanGorseli;
        RectTransform bgRect = rawImage.GetComponent<RectTransform>();
        bgRect.anchorMin = Vector2.zero;
        bgRect.anchorMax = Vector2.one;
        bgRect.offsetMin = Vector2.zero;
        bgRect.offsetMax = Vector2.zero;

        // Baþla Butonu
        GameObject buttonObj = new GameObject("BaslaButonu");
        buttonObj.transform.SetParent(canvasObj.transform);
        Button button = buttonObj.AddComponent<Button>();
        Image buttonImage = buttonObj.AddComponent<Image>();
        buttonImage.color = new Color(0.2f, 0.2f, 0.2f, 0.8f);
        RectTransform buttonRect = button.GetComponent<RectTransform>();
        buttonRect.sizeDelta = new Vector2(400, 150);
        buttonRect.anchorMin = new Vector2(0.5f, 0.5f);
        buttonRect.anchorMax = new Vector2(0.5f, 0.5f);
        buttonRect.pivot = new Vector2(0.5f, 0.5f);
        buttonRect.anchoredPosition = new Vector2(0, -300); // <<< Buton daha aþaðýda, ekranýn alt yarýsýna yaklaþtý

        // Buton Yazýsý
        GameObject buttonTextObj = new GameObject("ButtonText");
        buttonTextObj.transform.SetParent(buttonObj.transform);
        TextMeshProUGUI buttonText = buttonTextObj.AddComponent<TextMeshProUGUI>();
        buttonText.text = "BAÞLA";
        buttonText.alignment = TextAlignmentOptions.Center;
        buttonText.fontSize = 48;
        buttonText.color = Color.white;
        RectTransform buttonTextRect = buttonText.GetComponent<RectTransform>();
        buttonTextRect.sizeDelta = Vector2.zero;
        buttonTextRect.anchorMin = Vector2.zero;
        buttonTextRect.anchorMax = Vector2.one;
        buttonTextRect.offsetMin = Vector2.zero;
        buttonTextRect.offsetMax = Vector2.zero;

        // Baþlýk (TextMeshPro) — Baþla butonunun ALTINA koyacaðýz
        GameObject textObj = new GameObject("Baslik");
        textObj.transform.SetParent(canvasObj.transform);
        TextMeshProUGUI text = textObj.AddComponent<TextMeshProUGUI>();
        text.text = "Zihninin Derinliklerine Hoþ Geldin...";
        text.alignment = TextAlignmentOptions.Center;
        text.fontSize = 64;
        text.color = Color.white;
        RectTransform textRect = text.GetComponent<RectTransform>();
        textRect.sizeDelta = new Vector2(1400, 200);
        textRect.anchorMin = new Vector2(0.5f, 0.5f);
        textRect.anchorMax = new Vector2(0.5f, 0.5f);
        textRect.pivot = new Vector2(0.5f, 0.5f);
        textRect.anchoredPosition = new Vector2(0, -480); // <<< Yazý butondan sonra geliyor, daha da aþaðýda!
    }
}



