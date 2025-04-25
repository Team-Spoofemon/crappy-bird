using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float rate = 2;
    public float timer = 0;
    public float offsetY = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > rate)
        {
            this.Spawn();
            timer = 0;
        }
    }

    void Spawn()
    {
        float low = this.transform.position.y - this.offsetY;
        float hig = this.transform.position.y + this.offsetY;
        Vector3 pipesPosition = new Vector3(transform.position.x, Random.Range(low, hig), transform.position.z);
        Instantiate(pipe, pipesPosition, this.transform.rotation);
    }
}
