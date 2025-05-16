using UnityEngine;
using Vuforia;

public class Tile : MonoBehaviour
{
    // Reference to the marker
    public ImageTargetBehaviour marker;

    // Reference to the chess board tiles
    public GameObject[] chessTiles;

    public Vector2 Position,previousPosition;
    void Start(){
        chessTiles = GameObject.FindGameObjectsWithTag("Tile");
    }
    void Update()
    {
        if((marker.TargetStatus.Status == Status.TRACKED || marker.TargetStatus.Status == Status.EXTENDED_TRACKED)){
            // Get the marker's screen position
            Vector2 screenPos = Camera.main.WorldToScreenPoint(marker.transform.position);
            // Create a ray from the screen position
            Ray ray = Camera.main.ScreenPointToRay(screenPos);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);

            // Initialize a variable to store the hit information
            RaycastHit hit;
            // Check if the ray hits any of the chess tiles
            if (Physics.Raycast(ray, out hit))
            {
                // Iterate through the chess tiles
                for (int i = 0; i < chessTiles.Length; i++)
                {
                    // Check if the ray hit the current tile
                    if (hit.collider.gameObject == chessTiles[i])
                    {
                        // Do something when the marker is over the tile
                        // ...
                        
                        string[] parts = chessTiles[i].name.Split(' ');

                        if(previousPosition.x != int.Parse(parts[1])||previousPosition.y != int.Parse(parts[2]))
                        {
                            Position.x = int.Parse(parts[1]);
                            Position.y = int.Parse(parts[2]);
                            Controller Con = GameObject.FindGameObjectWithTag("Con").GetComponent<Controller>();
                            Con.UpdatePiecePosition();
                            previousPosition = Position;                        
                            Debug.Log(Position);
                        }
                        
                    }
                }
            }
        }
    }

    void Selected()
    {

    }
}