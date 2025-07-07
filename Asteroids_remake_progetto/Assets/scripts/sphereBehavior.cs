using UnityEngine;


public class sphereBehavior : MonoBehaviour
{
    [Header("Velocità")]
    [SerializeField] bool isActive;
    [SerializeField] public float speed = 10f;
    [SerializeField] Rigidbody rb;
    [SerializeField] Collider collider; // Fixed the declaration by adding a valid variable name

    private void Awake()
    {
        Debug.Log("Sphere is created and ready to roll!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        Debug.Log("Sphere is enabled!");
    }

    private void OnDisable()
    {

    }

    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collisione con {collision.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger exit {other.gameObject.name}");
    }
}
