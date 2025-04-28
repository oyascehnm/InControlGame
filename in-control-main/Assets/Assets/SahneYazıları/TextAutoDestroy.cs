using UnityEngine;
using TMPro; 

public class TextAutoDestroy : MonoBehaviour
{
    public float beklemeSuresi = 3f; 

    void Start()
    {
        Invoke("KendiniKapat", beklemeSuresi);
    }

    void KendiniKapat()
    {
        gameObject.SetActive(false); 
    }
}
