using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barSpawner : MonoBehaviour
{
    public float maxTime = 2;
    private float timer = 0;
    public GameObject bar;
    public GameObject bar2;
    public float height;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime && timer == 1)
        {
            GameObject newbar = Instantiate(bar);
            newbar.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newbar, 6);
            timer++;
        }else if (timer ==2 )
        {
            GameObject newbar2 = Instantiate(bar2);
            Destroy(newbar2, 6);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
