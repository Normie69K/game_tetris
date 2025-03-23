# **Tetris-like Game**

This is a simple Tetris-like game implemented in Unity, created by following a tutorial from **Zigurous**. It includes basic gameplay mechanics like piece movement, rotation, and line clearing. The game ends when a new piece cannot spawn at the spawn position.

---

## **Features**
1. **Gameplay**:
   - Move pieces left, right, and down.
   - Rotate pieces using the `Q` (counter-clockwise) and `E` (clockwise) keys.
   - Hard drop pieces using the `Space` key.
   - Clear lines to make space for new pieces.

2. **Game Over**:
   - The game ends when a new piece cannot spawn at the spawn position.
   - When the game is over, the board is cleared, and the game stops.

---

## **How to Play**
1. **Controls**:
   - **A**: Move piece left.
   - **D**: Move piece right.
   - **S**: Soft drop (move piece down faster).
   - **Space**: Hard drop (instantly drop the piece to the bottom).
   - **Q**: Rotate counter-clockwise.
   - **E**: Rotate clockwise.

2. **Objective**:
   - Clear lines by filling complete rows with pieces.
   - The game ends when the pieces stack up to the top of the board.

---

## **Scripts**
Here’s a brief overview of the main scripts used in the game:

1. **`Board.cs`**:
   - Manages the game board, piece spawning, and line clearing.
   - Handles the **game over** condition.

2. **`Piece.cs`**:
   - Controls the movement, rotation, and placement of the active piece.

3. **`Data.cs`**:
   - Contains data for Tetromino shapes and rotation logic.

4. **`Tetromino.cs`**:
   - Defines the Tetromino types and their data.

---

## **Setup Instructions**
1. **Create the Game Board**:
   - Create a new Unity project.
   - Add a `Tilemap` to the scene for the game board.
   - Create an empty GameObject and name it `Board`.
   - Attach the `Board` script to the `Board` GameObject.

2. **Add the Piece**:
   - Create a `Piece` GameObject and attach the `Piece` script to it.
   - Make sure the `Piece` GameObject is a child of the `Board` GameObject.

3. **Tetromino Data**:
   - Create `TetrominoData` ScriptableObjects for each Tetromino shape (I, J, L, O, S, T, Z).
   - Assign these ScriptableObjects to the `Tetrominoes` array in the `Board` script.

4. **Controls**:
   - The game uses the following keyboard inputs:
     - **A**: Left
     - **D**: Right
     - **S**: Soft drop
     - **Space**: Hard drop
     - **Q**: Rotate counter-clockwise
     - **E**: Rotate clockwise

---

## **How to Run the Game**
1. Open the Unity project.
2. Open the game scene (ensure the `Board` and `Piece` GameObjects are set up correctly).
3. Click the "Play" button in the Unity Editor to start the game.
4. Use the controls to play the game.
5. When the game ends, the board will be cleared, and the game will stop.

---

## **Code Overview**

### **Board.cs**
- Manages the game board and piece spawning.
- Handles line clearing and game over logic.

### **Piece.cs**
- Controls the active piece’s movement, rotation, and placement.

### **Data.cs**
- Contains Tetromino shapes and rotation matrices.

### **Tetromino.cs**
- Defines the Tetromino types and their data.

---

## **Credits**
This game was created by following a tutorial from **Zigurous**. Special thanks to Zigurous for the excellent tutorial and resources. The assets and code structure are based on the tutorial.

- **Tutorial Link**: [Zigurous Tetris Tutorial](https://youtu.be/ODLzYI4d-J8?si=OSpWgQu9oOie3Got)

---

## **Future Improvements**
- Add a scoring system to track points for cleared lines.
- Implement a high score system to save and display the best scores.
- Add sound effects and music for a more immersive experience.
- Introduce different levels with increasing difficulty.

---

## **How to Run the Game in Unity**
1. **Open the Project**:
   - Open Unity and load the project containing the game.

2. **Set Up the Scene**:
   - Ensure the `Board` and `Piece` GameObjects are set up correctly in the scene.
   - Assign the `TetrominoData` ScriptableObjects to the `Tetrominoes` array in the `Board` script.

3. **Play the Game**:
   - Click the "Play" button in the Unity Editor.
   - Use the controls to play the game.

4. **Game Over**:
   - When the game ends, the board will be cleared, and the game will stop.
