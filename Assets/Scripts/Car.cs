using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Car : MonoBehaviour
{
    [SerializeField] float Speed = 10f;
    [SerializeField] float speedGainPerSecond = 0.2f;
    [SerializeField] float turnSpeed = 200f;


    private float steerValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed += speedGainPerSecond * Time.deltaTime;

        transform.Rotate(0f, turnSpeed * steerValue * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Scene_mainMenu");
        }
    }

    public void Steer(int value)
    {
        steerValue = value;
    }
}
