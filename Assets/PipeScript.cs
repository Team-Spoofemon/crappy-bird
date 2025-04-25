using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float cullX = -45;
    public static int pipesCreated = 0;
    private int _id = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this._id = PipeMoveScript.pipesCreated;
        Debug.Log($"pipe {this._id} created");
        PipeMoveScript.pipesCreated += 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime ties it to time rather than the framerate, which is when Update is called
        transform.position = transform.position + (Vector3.left * this.moveSpeed * Time.deltaTime);

        if (this.transform.position.x < cullX)
        {
            Debug.Log($"pipe {this._id} culled");
            Destroy(this.gameObject);
        }
    }
}
