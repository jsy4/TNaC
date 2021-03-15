---
layout: default
title: User Stories
description: Every person has stories to tell.
---

## 1.0: Movement Controls
As a player I want to be able to look around the levels/environments in first person while being able to move around so that virtual reality experience is enhanced.

Elaboration: Players should be able to look around with the virtual reality headset or the arrow keys from a first person point of view as if they were actually in the level. They should also be able to move around the level (using WASD, mouse, or VR controllers) while also looking around for a more realistic playing experience. 

Constraints: Must be compatible with Oculus VR headset or keyboard and mouse controls.

Effort Estimation: 6 person hours

Acceptance Test: Run the game simulation with different control types and the game camera anchored to the character’s head. Show that the user can control their character properly with both VR headset/controller and keyboard/mouse.

## 1.1: Attacking Controls
As a player I want to be able to attack enemies with melee weapons using one button clicks so that I can kill enemies and survive the waves/complete the levels.

Elaboration: Players should be able to attack/hit enemies at a close range with weapons obtainable in game. The range of weapons should be very short (within swinging distance) with a simple motion of the VR controller or a button click to complete the action. The hit box of enemies should also be reasonable and their health should go down with each successful attack until they die.

Constraints: None

Effort Estimation: 2 person hours

Acceptance Test: Run game simulation with sample enemies and weapons preloaded in. The player should be able to only hit enemies at close range and the enemies should die/disappear after a sufficient amount of damage has been dealt. 

## 2.0: Level Design 
As a virtual reality gamer I want to have a good looking environment so that I could explore the game with a comfortable/smooth experience.

Elaboration: The virtual reality player should be able to look and walk around the environment/levels without lagging or skipping around. We want the player to feel comfortable when playing in VR and not cause headaches. Even in the 3D computer environment the levels should render reasonably quickly and without lighting issues that take away from the game. 

Constraints: Processing power/graphics may vary. At least 72 frames per second desired.

Effort Estimation: 8 person hours

Acceptance Test: Player is loaded into first level with VR headset. They should be able to look around and feel like they are in the game with smooth clean graphics. They should also be able to move around the level to explore all aspects for a realistic experience.

## 2.1: Level Content
As a player I want the levels to be unique and with adequate content so that the game is not boring or ugly.

Elaboration: Ideally the player will want to replay levels because they are nice to look at and enjoyable to explore. The levels should be more complex than a simple forest with a few trees and shrubs. It might even be nice to have little secret items hidden throughout the levels so that the player is motivated to explore the whole area. 

Constraints: None

Effort Estimation: 8 hours

Acceptance Test: Player loaded into multiple levels with VR headset. The above user story should be observed, while paying extra attention to level design details. The textures should look natural/appealing and flow well with the theme of the level. 

## 2.2: Monster Spawning
As a player I don’t want monsters spawning right on top of me while I am moving around the levels so that I don’t die or be scared unnecessarily. 

Elaboration: The game should not spawn enemies randomly because of the chance that they will spawn where the player is, making that aspect of the game unfair. Either the enemies should spawn in dark areas (like minecraft) or have preset spawn locations that are inaccessible to the user. We don’t want the player to fail the level for reasons outside of their control.

Constraints: No enemy spawning within certain radius of player

Effort Estimation: 3 hours

Acceptance Test: Player loaded into multiple levels and moving around the environment for an adequate amount of time. The enemies should never spawn too close to the player at any time during the test or they must only spawn in designated locations regardless of user location. 



## 5.0: Game Installment
As a player who likes playing on VR headsets (or on computer), I want the game without a complicated installment so that the game is enjoyable.

Elaboration: The player should not feel discomfort in installment due to program flaws and they should be able to install the game within reasonable time.

Constraints: The game have the equipment for the game controls and source where the software could be downloaded as mentioned in **1.0** and **2.0**.

Effort Estimation: 2 person hours

Acceptance Test: Test installing the gaming environment after the game is published. Preferably the installment should not be more than 2 hours.

## 6.0: Game Integrity
As a player who is afraid of installing broken programs, I want to know that the game is reliable enough so that I could install it on my computer system.

Elaboration: The player should be able to know where the game is from and be able to trust the distributing party.

Constraints: The game should have a section about the developers and clear purpose of the game and the player should be able to read it if they want to.

Effort Estimation: 1 person hours

Acceptance Test: The player will read the documentation about the program and feel enough confidence that this game wouldn't break their computer.

