using UnityEngine;
using UnityEngine.Tilemaps;

public class Ghost : MonoBehaviour
{
    public Tile tile;
    public Board mainBoard;
    public Piece trackingPiece;

    public Tilemap tilemap { get; private set; }
    public Vector3Int[] cells { get; private set; }
    public Vector3Int position { get; private set; }

    private void Awake()
    {
        tilemap = GetComponentInChildren<Tilemap>();
        cells = new Vector3Int[4];
    }

    private void LateUpdate()
    {
        Clear();
        Copy();
        Drop();
        Set();
    }

    private void Clear()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            Vector3Int tilePosition = cells[i] + position;
            tilemap.SetTile(tilePosition, null);
        }
    }

    private void Copy()
    {
        for (int i = 0; i < cells.Length; i++) {
            cells[i] = trackingPiece.cells[i];
        }
    }

    private void Drop()
    {
        Vector3Int position = trackingPiece.position;

        int bottom = -mainBoard.boardSize.y / 2 - 1;
        int dropDistance = 0;

        mainBoard.Clear(trackingPiece);

        for (int row = position.y; row >= bottom; row--)
        {
            position.y = row;

            if (mainBoard.IsValidPosition(trackingPiece, position)) {
                dropDistance = position.y - trackingPiece.position.y;
            } else {
                break;
            }
        }

        this.position = trackingPiece.position + new Vector3Int(0, dropDistance, 0);
        mainBoard.Set(trackingPiece);
    }

    private void Set()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            Vector3Int tilePosition = cells[i] + position;
            tilemap.SetTile(tilePosition, tile);
        }
    }
}