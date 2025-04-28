using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance;
    public float currentTime;    
    public bool isCounting = true;
    public bool countDown = false; 

    public float startTime = 300f;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        if (countDown)
            currentTime = startTime;
        else
            currentTime = 0f;
    }

    private void Update()
    {
        if (!isCounting) return;

        if (countDown)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                currentTime = 0f;
                isCounting = false;
                OnTimerEnd();
            }
        }
        else
        {
            currentTime += Time.deltaTime;
        }

        CheckAnxietyIncrease();
    }

    private void OnTimerEnd()
    {
        Debug.Log("Timer bitti!");
    }

    public void PauseTimer()
    {
        isCounting = false;
    }

    public void ResumeTimer()
    {
        isCounting = true;
    }

    private void CheckAnxietyIncrease()
    {
        if (countDown)
        {
            if (currentTime <= startTime * 0.75f)
            {
                AnxietyManager.Instance.IncreaseAnxietyMultiplier(1.5f);
            }
            if (currentTime <= startTime * 0.5f)
            {
                AnxietyManager.Instance.IncreaseAnxietyMultiplier(2f);
            }
            if (currentTime <= startTime * 0.25f)
            {
                AnxietyManager.Instance.IncreaseAnxietyMultiplier(2.5f);
            }
        }
    }
}
