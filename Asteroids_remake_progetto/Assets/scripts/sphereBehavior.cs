using UnityEngine;


public class sphereBehavior : MonoBehaviour
{
    private string sphereName = "Sphere"; 

    private void Awake()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Sphere is created and ready to roll!");
        // Find the sphere by name
        GameObject sphere = GameObject.Find(sphereName);
        if (sphere != null)
        {
            Debug.Log("Found the sphere: " + sphere.name);
        }
        else
        {
            Debug.LogError("Sphere not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {

    }
}
