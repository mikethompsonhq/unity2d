using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public new string name = "Untitled";
    public bool alive;
    public int age = 10;
    public int[] points = new int[5];
    public string[] names;

    public float speed
    {
        get
        {
            return sm.speed;
        }
    }

    // Start is called before the first frame update

    private SpeedManager sm;

    void Awake()
    {
        sm = gameObject.GetComponent<SpeedManager>();
    }
    
    
    void Start()
    {
        print("Start");
    }

    void FixedUpdate()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
    }

    void LateUpdate()
    {

    }
}
