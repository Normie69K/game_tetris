using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
    I, J, L, O, S, T, Z
}

[System.Serializable]
public struct TetrominoData
{
    public Tile tile;
    public Tetromino tetromino;

    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }

    public TetrominoData(Tetromino tetromino, Tile tile)
    {
        this.tetromino = tetromino;
        this.tile = tile;
        this.cells = Data.Cells[tetromino];
        this.wallKicks = Data.WallKicks[tetromino];
    }

    public void Initialize()
    {
        cells = Data.Cells[tetromino];
        wallKicks = Data.WallKicks[tetromino];
    }
}