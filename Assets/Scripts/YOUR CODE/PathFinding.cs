using NUnit.Framework;
using UnityEngine;

public class PathFinding : MonoBehaviour
{
    public Map Grid;
    private const int AllyLocationX = 0;
    private const int AllyLocationY = 0;
    private const int NearestEnemyX = 0;
    private const int NearestEnemyY = 0;
    private const int GridSize = 0;

    private Map Map;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      GridSize = Map.MapSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
