using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movement : MonoBehaviour    
{
    private Rigidbody2D rd;
    private float dirX;
    private float movementSpeed = 400f;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * movementSpeed;
        rd.velocity = new Vector2(dirX, 0f);
    }
}
