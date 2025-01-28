using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private bool detectingPlayer;
    [SerializeField] private float WaterValue;
    private PlayerItems player;

    void Start()
    {
        player = FindAnyObjectByType<PlayerItems>();

    }

    // Update is called once per frame
    void Update()
    {
        if (detectingPlayer && Input.GetKeyDown(KeyCode.E))
        {
            player.WaterLimit(WaterValue);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if(collision.CompareTag("Player"))
        { 
            detectingPlayer = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            detectingPlayer = false;
        }
    }
}
