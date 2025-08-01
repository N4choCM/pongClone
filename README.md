# Pong Clone

A simple 2D clone of the classic Pong game built with Unity and C#. Play against a basic CPU opponent, track scores, hear collision sounds, and enjoy start/end menus.

---

## 🎮 Description

This project recreates the legendary Pong game in 2D. The player controls a paddle with the up/down arrow keys and competes against a CPU paddle. Reach the target score to see the Game Finished screen and play again.

---

## ⚙️ Prerequisites

- **Unity** 2020.3 LTS or newer  
- A code editor (Visual Studio, Rider, VS Code, etc.)  
- Audio files for collision effects  

**Scenes included in the project**:  
- **MainMenu** (Start button)  
- **Board** (Gameplay)  
- **GameFinished** (End screen)  

---

## 🚀 Installation & Running

1. **Clone the repo**  
   ```bash
   git clone https://github.com/your-username/pong-clone.git
   cd pong-clone

2. **Open in Unity**  
   ```bash
   # Launch Unity Hub and add the project folder.
   # Open the MainMenu scene and press “Play”.

3. **WebGL Build (optional)**  
   ```bash
   # In Unity:
   # 1. File > Build Settings
   # 2. Select WebGL
   # 3. Click Switch Platform
   # 4. Click Build

## 📋 Controls

**Player Paddle**  
- **Up Arrow**: Move up  
- **Down Arrow**: Move down  

**Fullscreen (WebGL)**  
- Add a button that calls `iframe.requestFullscreen()` around the build.

---

## 📂 Script Overview

| Script                       | Purpose                                                                                   |
| ---------------------------- | ----------------------------------------------------------------------------------------- |
| **BallMovement.cs**          | Initializes and moves the ball, handles speed increase, resets on score.                 |
| **CPUPaddle.cs**             | Simple AI: follows the ball’s Y position when it’s more than 50 units away vertically.    |
| **PlayerPaddle.cs**          | Reads keyboard input and moves the player’s paddle accordingly.                           |
| **PaddleCollisionControl.cs**| Detects collisions, calculates bounce direction, updates score via `Scoring`.             |
| **Scoring.cs**               | Manages player & CPU scores, updates UI Text, transitions to GameFinished on win.         |
| **SoundControl.cs**          | Plays paddle or wall collision sounds.                                                    |
| **StartButton.cs**           | Loads the game scene (Board) on button click.                                             |

---

## 🔧 Customization

- **Ball Speed**: Tweak `speed`, `increase`, and `maxSpeed` in `BallMovement.cs`.  
- **Paddle Speed**: Adjust `speed` in `PlayerPaddle.cs` and `CPUPaddle.cs`.  
- **Winning Score**: Modify the `goal` value in `Scoring.cs`.  
- **Sounds**: Assign your own audio clips to `paddleSound` and `wallSound`.  
- **UI & Scenes**: Enhance or replace **MainMenu**, **Board**, and **GameFinished** with custom graphics and animations.

---

## 📈 Potential Improvements

- **Advanced AI**: Implement predictive movement or difficulty levels.  
- **Networking**: Add multiplayer over LAN or WebSockets.  
- **Mobile Support**: Integrate touch controls and screen scaling.  
- **React Integration**: Embed your WebGL build in a React app via an `<iframe>` or use a library like `react-unity-webgl`.  

