using UnityEngine;
public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]                                                  // a
                                                                           // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the AppleTree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;

    // Seconds between Apples instantiations
    public float appleDropDelay = 1f;

    void Start()
    {
        // Start dropping apples                                           // b
    }

    void Update()
    {
        // Basic Movement                                                  // b
        Vector3 pos = transform.position;                        // b
        pos.x += speed * Time.deltaTime;                         // c
        transform.position = pos;
        // Changing Direction                                              // b
        if (pos.x < -leftAndRightEdge)
        {                                        // a
            speed = Mathf.Abs(speed);   // Move right                           // b
        }
        else if (pos.x > leftAndRightEdge)
        {                                  // c
            speed = -Mathf.Abs(speed);  // Move left                            // c
        }
    }
}