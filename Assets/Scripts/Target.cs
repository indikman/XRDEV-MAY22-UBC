using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float xAmplitude = 0.5f;
    public float xSpeed = 1;

    public float yAmplitude = 0.5f;
    public float ySpeed = 1;

    public float zAmplitude = 0.5f;
    public float zSpeed = 1;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
                startPosition.x + Mathf.Sin(Time.timeSinceLevelLoad * xSpeed) * xAmplitude,
                startPosition.y + Mathf.Sin(Time.timeSinceLevelLoad * ySpeed) * yAmplitude,
                startPosition.z + Mathf.Sin(Time.timeSinceLevelLoad * zSpeed) * zAmplitude
            );
    }

    // Detect collision
    void OnCollisionEnter(Collision col)
    {
        //filter food items only
        if(col.gameObject.CompareTag("fooditem"))
        {
            GameManager.Instance.TargetHit(); // Ive been hit!


            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
