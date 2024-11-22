using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Draggable")) 
        {
            Destroy(other.gameObject); 
        }
    }
}
