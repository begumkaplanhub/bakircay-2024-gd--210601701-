using UnityEngine;

public class PlacementArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Draggable")) 
        {
            Destroy(other.gameObject); 
        }
    }
}
