using UnityEngine;
using UnityEngine.Tilemaps;

public class GridA : MonoBehaviour {
    private Spelobject[,] gridObjects;
    private GameObject[,] spawnedObjects;
    public Spelobject[,] GetGrid()
    {
        return gridObjects;
    }
    
    [SerializeField] private int width, height;
    [SerializeField] private GameObject _tileprefap;
    [SerializeField] private Transform cam;
    [SerializeField] private GameObject[] objectPrefabs;

    void Start()
    {
        GridG();
    }
    void GridG()
    {
        gridObjects = new Spelobject[width,height]; 
        spawnedObjects = new GameObject[width, height];

        float tileWidth = _tileprefap.transform.localScale.x;   
        float tileHeight = _tileprefap.transform.localScale.y;
        
        for (int y = 0; y < height; y ++)
            {
                for (int x = 0; x < width; x ++)
                {
                    float xPos = x * tileWidth;
                    float yPos = y * tileHeight;
                    Vector3 spawnPos = new Vector3(xPos-4.5f, yPos-3f, -1);
                    var spawnedTile = Instantiate(_tileprefap, spawnPos, Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    Instantiate(_tileprefap, spawnPos, Quaternion.identity);
                    int randomIndex = Random.Range(0, objectPrefabs.Length);

                    Vector3 objectPos = new Vector3(spawnPos.x, spawnPos.y, -2);

                    Instantiate(objectPrefabs[randomIndex], objectPos, Quaternion.identity);
                    Objects randomType =
                        (Objects)Random.Range(
                            0,
                            System.Enum.GetValues(typeof(Objects)).Length
                        );

                    gridObjects[x, y] = new Spelobject(randomType, 2);
                }
            }
        
    }
    public void Clear()
    {
        if (spawnedObjects == null) return;

        for (int y = 0; y < spawnedObjects.GetLength(1); y++)
        {
            for (int x = 0; x < spawnedObjects.GetLength(0); x++)
            {
                if (spawnedObjects[x, y] != null)
                {
                    Destroy(spawnedObjects[x, y]);
                }
            }
        }
    }
}
