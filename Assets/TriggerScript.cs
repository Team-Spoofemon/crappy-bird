using Unity.VisualScripting;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // because this TriggerScript gets spawned in, you can't drag-drop the logic script onto it
        // so, as a "workaround", find the game object of Logic, and get that game object's logic script.
        // finds the FIRST game object with that tag in the hierarchy
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("trigger");
        if (collision.gameObject.layer == 3) {
            logic.updateScore(update: 1);
        }
    }
}
