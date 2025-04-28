using UnityEngine;
using UnityEngine.UI;

public class AnxietyManager : MonoBehaviour
{
    public static AnxietyManager Instance;

    [Header("UI")]
    public Slider anxietySlider;

    [Header("Anxiety Settings")]
    public float anxietyLevel = 0f;
    public float anxietyIncreaseRate = 1f; // saniyede artış miktarı
    public float maxAnxiety = 100f;
    public int baseRate = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        if (anxietyLevel < maxAnxiety)
        {
            anxietyLevel += anxietyIncreaseRate * Time.deltaTime;
            anxietySlider.value = anxietyLevel;
        }
    }

    public void IncreaseAnxietyMultiplier(float multiplier)
    {
        anxietyIncreaseRate = baseRate * multiplier;
    }
}