using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject cat1;
    [SerializeField] private GameObject cat2;
    public GameObject[] places = new GameObject[7];
    private int cat1Counter;
    private int cat2Counter;
    
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
            Debug.Log(cat1Counter + ":" + cat2Counter);

            if (cat1Counter + 1 == cat2Counter)
                cat1Counter++;
            cat1.transform.position = places[cat1Counter].transform.position + Vector3.up / 2;
            cat1Counter++;
            cat1Counter = cat1Counter % places.Length;


            cat2.transform.position = places[cat2Counter].transform.position + Vector3.up / 2;
            cat2Counter--;
            if (cat2Counter == -1)
                cat2Counter = places.Length - 1;

        }
    }
}
