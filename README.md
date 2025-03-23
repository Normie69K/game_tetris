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

## **Setup Instructions**

### **1. Clone the Repository**
To get started, clone the repository to your local machine using the following command:

```bash
git clone https://github.com/Normie69K/game_tetris.git
```

### **2. Open the Project in Unity**
1. Open **Unity Hub**.
2. Click on **Add Project** and select the folder where you cloned the repository.
3. Ensure you are using a compatible version of Unity (preferably **Unity 2021.3 or later**).

### **3. Set Up the Game**
1. Open the game scene (located in the `Scenes` folder).
2. Ensure the `Board` and `Piece` GameObjects are set up correctly in the scene.
3. Assign the `TetrominoData` ScriptableObjects to the `Tetrominoes` array in the `Board` script.

### **4. Play the Game**
1. Click the **Play** button in the Unity Editor.
2. Use the controls to play the game.

---

## **Building the Game**
To build the game for your desired platform:

1. Go to **File > Build Settings**.
2. Select your target platform (e.g., Windows, Mac, Linux, WebGL).
3. Click **Build** and choose a location to save the build.

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

## **Credits**
This game was created by following a tutorial from **Zigurous**. Special thanks to Zigurous for the excellent tutorial and resources. The assets and code structure are based on the tutorial.

- **Tutorial Link**: [Zigurous Tetris Tutorial](https://youtu.be/ODLzYI4d-J8?si=1GdeocSfWfyNQ4md)

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
