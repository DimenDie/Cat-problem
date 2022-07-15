using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject cat1;
    [SerializeField] private GameObject cat2;
    public GameObject[] places = new GameObject[7];
    [SerializeField] private int cat1Counter;
    [SerializeField] private int cat2Counter;
    
    // Start is called before the first frame update
    void Start()
    {
        cat1Counter = 0;
        cat2Counter = places.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            cat2.transform.position = places[cat2Counter].transform.position + Vector3.up / 2;
            cat1.transform.position = places[cat1Counter].transform.position + Vector3.up / 2;

            cat2Counter = cat2Counter / places.Length;
            cat2Counter--;


            cat1Counter = cat1Counter % (places.Length - 1);

            cat1Counter++;
            if (cat1Counter == cat2Counter)
            {
                cat1Counter++;
            }


            Debug.Log(cat1Counter + ":" + cat2Counter);

        }
    }
}
