using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contador : MonoBehaviour
{
    private float countRate = 1f;
    public int startNumber = 10;
    private TextMeshProUGUI countDown;
    

    // Start is called before the first frame update
    void Start()
    {
        countDown = GetComponent<TextMeshProUGUI>();
        StartCoroutine("CountDownFunction");
        countDown.text = "Cuenta Atras";
    }

    private IEnumerator CountDownFunction()
    {
        yield return new WaitForSeconds(countRate);

        for (int FinalOfCount = startNumber; FinalOfCount >= 0; FinalOfCount -= 1)
        {
            yield return new WaitForSeconds(countRate);

            countDown.text = FinalOfCount.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
