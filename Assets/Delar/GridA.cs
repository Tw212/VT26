using UnityEngine;
using UnityEngine.Tilemaps;

public class GridA : MonoBehaviour {

    
    [SerializeField] private float width, height;
    [SerializeField] private GameObject _tileprefap;
    [SerializeField] private Transform cam;

    void Start()
    {
        GridG();
    }
    void GridG()
    {
        float tileWidth = _tileprefap.transform.localScale.x;   
        float tileHeight = _tileprefap.transform.localScale.y;
        for (float y = 0; y < height; y+=1.05f)
            {
                for (float x = 0; x < width; x+=1.05f)
                {
                    float xPos = x * tileWidth;
                    float yPos = y * tileHeight;
                    Vector3 spawnPos = new Vector3(xPos-4.5f, yPos-3f, -1);
                    var spawnedTile = Instantiate(_tileprefap, spawnPos, Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    
                    
                }
            }
        
    }
}
