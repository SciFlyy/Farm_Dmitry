using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracktorMovement : MonoBehaviour
{
    [Header("Fire Property")]
    [SerializeField] private GameObject senoPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireRate;
    private float nextFire;

    [Header("Traktor Property")]
    [SerializeField] private float speed;
    [SerializeField] private float border;
    private float direction;
    private bool isPress;

    private void Start()
    {
        nextFire = fireRate;
    }


    void Update()
    {
        //if (((transform.position.x > -border) && (direction == 1f)) || ((transform.position.x < border) && (direction == -1f)))
        //  {
        //      transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
        //  }
        if (isPress)
        {
            if (((transform.position.x > -border) && (direction == 1f)) || ((transform.position.x < border) && (direction == -1f)))
            {
                transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
            }
        }
        nextFire -= Time.deltaTime;
    }
    public void PressLeft()
    {
        direction = 1f;
        isPress = true;
    }

    public void PressRight()
    {
        direction = -1f;
        isPress = true;
    }

    public void StopPress()
    {
        direction = 0f;
        isPress = true;
    }
    
    public void PressFire()
    {
        if (nextFire > fireRate)
        {
            GameObject seno = Instantiate(senoPrefab, spawnPoint.position, Quaternion.identity); // senoPrefab.transform.rotation
            Destroy(seno, 15f);
            Debug.Log("Fire");

            nextFire = 0;
        }
        
    }

}
