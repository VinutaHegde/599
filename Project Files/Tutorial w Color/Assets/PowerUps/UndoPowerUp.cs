using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoPowerUp : PowerUpBase
{
    int[] gridArray;
    
    
    
    public string GetType()
    {
        return "undo";
    }

    // grid[] is an old_array
    // gridArray[] is a TileArray that it's gonna be update
    public PowerUpTilesDto Use(PowerUpTilesDto powerUpTilesDto, int[] grid)
    {
    
        int size = powerUpTilesDto.TileArray.Length;
        for (int i = 0, i < size i++)
        {
            gridArray[i] = grid[i];
        }
            
        return powerUpTilesDto;
    }
}
