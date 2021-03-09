---
layout: default
title: Problem Statement
description: It could go on and on...
---


## 1. Introduction

For our project, we are attempting to create a 3D virtual reality game where you progress through levels by defeating waves of enemies. The three biggest parts of our project that we have to get done are the level designs, user interaction, and enemy UI. We will be using Unity engine to develop our project with C# language.


## 2. General Description of Product

Throughout the users play-through, they will be moving through different environments and stages we’ll be referring to as “levels”. These levels will all be 3D environments that will allow the players to walk within a square room and fight the enemies. The player will only be able to walk around in these rooms, they won’t be able to climb, jump, or sprint while moving around. This presents a problem that we have to be able to keep the mechanics simple but enjoyable and have a replay value. In order to accomplish this task, we’ll be implementing enemies that the user will be able to fight against within these levels.


## 3. Functional Requirements

The enemies the user will fight against will be approaching them from all different directions from specified locations, as we believe having them spawn randomly in the map could cause trouble for the player if the enemies were to spawn right on top of the player or out of bounds. The enemies will slowly approach the player and attack them with close-ranged melee attacks only. When an enemy is defeated, they will have a very small chance to drop a weapon from a premade loot table for each level, so that players can’t get an overpowered weapon in the beginning and have the rest of the game be an absolute breeze. When they are defeated the player will also be rewarded with a set amount of experience points which they can use to level up and distribute points to improve themselves.

As for the player, they will be able to pick up weapons, level up, take damage, and move around the terrain. We are planning for the player to be able to walk around the environments and fight the enemies wave after wave, slowly gaining experience points and picking up weapons from fallen enemies in order to become stronger and progress through the game in a much easier way. The player will only be able to use melee weapons like the enemies because we believe that would be easiest to implement into our game for now. 

The weapons will also only improve based on the amount of damage they do as well, but if we are able to implement special “powers” onto the weapons then we may make it so that the weapons could do special things, such as deal extra damage in the form of fire or ice, or knock the enemy further back. However we do not currently know how hard this would be to implement so we are opting to just improve the base damage of the weapons for now. 

After defeating an enemy, the player will also receive experience points that will help contribute to a level up, which will allow the player to improve themselves passively for the rest of the game. These upgrades will include but are not limited to increases in base damage or an increase in their maximum health. The player's health will also be made up of hearts rather than a bar, since we believe it may be easier to portray the users health like that as well as keep track of it.

The possible extension to this project will be including the music and sound effects. Again, our short term goal is to have the basic structure of a game and make it functional before adding onto the graphical and sound designs. Our team will be required to learn continuously and work together to implement the ideas to a usable program by the end of the semester.


<b>Sample Domain Model for Problem statement: </b>

![](https://user-images.githubusercontent.com/65105285/110419294-48b07a00-8056-11eb-9f7a-3b76ec3fb6cd.png?raw=true)


## 4. System and Non-functional Requirements

The device running our game must be able to connect, either physically with wired connections or remotely to a virtual reality headset and controllers. Alternatively the user can use keyboard controls from a computer. The targeted platform will be android. The current concern is that we are developing in unity 3D before testing with VR controllers, but we are hoping to convert when we have the basic mechanics down. If not, we will probably end up having a 3D game.
