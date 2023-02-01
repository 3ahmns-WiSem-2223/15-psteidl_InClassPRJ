using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_score : MonoBehaviour
{
    [SerializeField]
    GameObject Canvas;
    int plusscore;
    Vector3 position;
    float xposition;
    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(5.5f, -5.5f);
        y = Random.Range(3, -3);
    }

    public void Pressed()
    {
        Canvas.GetComponent<Timer>().scorenumber += 1;
        position = new Vector3(x,y,0);
        gameObject.transform.position = position;
        gameObject.SetActive(false);
        gameObject.SetActive(true);
    }
}
