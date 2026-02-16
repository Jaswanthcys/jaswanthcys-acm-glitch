# jaswanthcys-acm-glitch


# 🎮 Flappy Bird Clone – Unity 2D Game

## 📌 Project Overview

This is a 2D Flappy Bird-style game developed using Unity and C#.  
The player controls a bird that must pass through pipes without colliding.  
The game includes scoring, sound effects, extra life system, and time rewind functionality.

---

## 🚀 Features

- 🐦 Bird movement with physics
- 🧱 Dynamic pipe spawning
- 🎯 Score tracking system
- 🔊 Background music and sound effects
- ⏸ Game pause and restart system
- ❤️ One extra life system
- ⏪ Time rewind functionality
- 🧠 Modular and clean architecture

---

## 🏗️ Game Architecture

The project follows a modular design:

- **BirdScript** → Controls bird movement and collision
- **LogicScript** → Manages score, restart, and game over
- **PipeSpawnScript** → Spawns pipes at intervals
- **PipeMoveScript** → Moves pipes left continuously
- **PipeMiddleScript** → Detects scoring trigger
- **LifeRewindScript** → Handles extra life logic
- **TimeRewindScript** → Handles rewind feature
- **OneExtraLifeScript** → Ensures only one life is used
- **CloudScript** → Controls background movement
- **SoundManager** → Singleton pattern for sound control

---

## 🛠 Technologies Used

- Unity Engine (2D)
- C# Programming
- Unity UI System
- Scene Management
- Singleton Design Pattern

---

## 🎮 How to Play

1. Press Space to make the bird jump.
2. Avoid hitting pipes or ground.
3. Pass through pipes to gain score.
4. Press R to activate extra life (once).
5. Game freezes when bird dies.
6. Press Restart button to restart the game.

---

## 🔄 How Restart Works

- Uses SceneManager to reload current scene.
- Resets Time.timeScale to 1.
- Clears game state.

---

## ⚡ Optimization Techniques

- Destroy off-screen pipes
- Used Time.deltaTime for smooth movement
- Prevented duplicate GameOver calls
- Singleton pattern for sound management

---

## 🔮 Future Improvements

- Add object pooling for better performance
- Add main menu
- Add difficulty levels
- Add mobile touch controls
- Add leaderboard system

---

## 👨‍💻 Author

Developed by: Jaswanth  
College Project – Unity Game Development
