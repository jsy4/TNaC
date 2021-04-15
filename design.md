---
layout: default
title: Design Document
description: To understand design...
---
### Class-level Design

The major classes are the Player and Enemy with their variables and their mode of interaction. The interactions will be mostly collision detection with the game objects. For example, if the player comes in contact with the enemy object, the health of the player will decrease. We are not using threading, so there is no external communication that affects the user control within the game runtime.

### Our Architecture

The design of the architecture aims to be a singleton pattern, with occasional static variables. The events during the game will trigger to update the Player and Enemy status accordingly. Below is the diagram for how classes will have resource read and write to same variables.

![blackboard](https://user-images.githubusercontent.com/65105285/113374866-6ad2aa80-932b-11eb-80eb-6cbe83e91ca1.png?raw=true). 
