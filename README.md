Unity Junior Programmer – Unit 4 Projects
Arena Battle & Fixing the Soccer Game

This repository contains my work for Unit 4 – Gameplay Mechanics from the Unity Junior Programmer pathway.
The unit includes two main projects:

Arena Battle (Sumo-Style Push Game) – A full prototype I built from scratch.

Soccer Game Debugging Project – A pre-built prototype filled with bugs that I identified and fixed.

🥋 Project 1: Arena Battle – “Prototype 4”

Description:
A sumo-style arena game where enemies spawn and attempt to push the player off the platform.
The player collects power-ups to increase push force, and each defeated wave increases difficulty.

Key Features

Physics-based enemy knockback system

Power-ups with temporary strength boosts

Wave-based spawning with increasing difficulty

Enemy AI that charges at the player

Player movement and interactions built with Unity 6

⚽ Project 2: Soccer Game Debug Fixes – “Challenge 4”

This project was provided with several bugs that broke core gameplay mechanics.
I fixed all issues and restored the intended behavior.

Gameplay Overview

Player ball defends their goal from incoming enemies.

Power-ups allow stronger knockback.

Enemies spawn in waves and try to score.

🐞 List of Bugs I Fixed
1. Wrong Knockback Direction

Problem: Enemies got pulled toward the player instead of pushed away.

Fix: Corrected vector math in PlayerControllerX.cs → enemy position - player position.

2. New Waves Not Spawning

Problem: Enemy waves would not respawn after clearing the arena.

Fix: Ensured enemyCount updates correctly in SpawnManagerX.cs.

3. Powerup Timer Never Started

Problem: The power-up stayed forever because its coroutine never ran.

Fix: Called StartCoroutine(PowerupCoolDown()) in PlayerControllerX.cs.

4. Wrong Number of Enemies Per Wave

Problem: Wave scaling was incorrect (wave 1 should spawn 1 enemy, wave 2 = 2, etc.)

Fix: Corrected loop logic in SpawnManagerX.cs to use the enemiesToSpawn parameter.

5. Enemies Not Moving Toward the Goal

Problem: EnemyX.cs threw a NullReferenceException due to the playerGoal not being assigned.

Fix: Assigned the reference and fixed the movement logic.

📑 What I Learned

Debugging in Unity 6

Fixing NullReference exceptions

Using Coroutines for timed events

Physics & vector math for knockback

Building scalable wave spawning systems

Structuring gameplay scripts cleanly

🚀 How to Run

Clone the repository

Open the project in Unity 6

Open one of the scenes:

Prototype 4 (Arena Battle)

Challenge 4 (Soccer Game Fix)

Press Play and test the gameplay
