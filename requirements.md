---
layout: default
title: Requirements
description: This is our homepage.
---

# Requirements Specification for TNaC - Virtual Retaliate
## 1. Introduction
### 1.1 Purpose of Product
The program we are trying to create is a 3D/VR game that implements melee combat against enemies that can move around and attack the user. The user will be able to move around, heal, pick up weapons, and level up in our game.

### 1.2 Scope of Product
A short description of your product's scope (what it includes and what it does not include). Part of your problem statement might be useful here, but focus on the scope of the product.
The product will allow the user to explore different maps and fight the waves of enemies. The player will be able to move around the map with enemies spawned from the set spawn locations. This game is aiming for four levels in total and will become harder as it progresses to upper number levels. The enemies will be balls for the easier levels and hopefully ragdolls for the more harder ones. Also, when enemies are killed, they will drop weapons that will help to increase the amount of damage that the player does and increase survivability.
 
### 1.3 Acronyms, Abbreviations, Definitions
Any important terms that are required to understand your project documents.
TNaC (Three is Not a Crowd) - The developer group name
Maps / Lv - the different 3D levels with unique themes and difficulty. Lv is an abbreviation for level.
Attackers / enemies - Non-playable characters that the user must fend off in each level in order to advance in the game. Ragdoll is the name we are using to describe the models of the enemies.
Hearts - This will be the player's health. 
Product / project / game - refers to the project Virtual Retaliate
Main page - displays all the levels and user setting 
Level design - themes that we thought of (...)

Gears - computer / VR headset and joy sticks
### 1.4 References
Any external references needed to understand your project documents. Use URL links if possible.
Unity asset store - https://assetstore.unity.com/

## 2. General Description of Product
This section contains a longer but not exhaustive description of your product.
Our product will be built in Unity as a 3D/VR game where you will be a first-person character going walking around a 3D environment fighting against waves of enemies. As a player, you will be able to fight these waves of enemies coming at you and gain experience points, pick up weapons dropped randomly by enemies, and level up. When leveling up, you will be able to distribute your experience points and be able to improve your stats, including but not limited to health, damage done, and damage taken. We have also decided that the health system we will be using for the player will be hearts, and you will not be able to heal while in your current level, but instead once you beat the level and move onto the next stage you will fully heal. This will incentivise players to be careful and work efficiently, safely, and tactfully when fighting enemies rather than being reckless. Also, when defeating an enemy, they will have a small chance to drop a pre-set weapon from a table of potential drops. As levels progress, the weapons within the table will improve in terms of quality, damage, and possibly the rate at which weapons would drop as well.

### 2.1 Context of Product
Context or environment that your product will be in.
The product will ideally operate in a virtual reality setting. The user will wear a headset to look around the maps, while moving using handheld controllers with buttons and joysticks. 

### 2.2 Domain Model with Description
Display and describe your domain model.
 
### 2.3 Product Functions (general)
Basic overview of the capabilities of your product. This is not your list of functional requirements, but an overview. Part of your problem statement might be good here.
The product is able to run
 
### 2.4 User Characteristics and Expectations
Describe your users and their abilities.
Our users will be in first-person, with the ability to look around the 3D environment and move freely in any direction with the confines of the current level. They will not be able to jump or sprint (move faster than standard walking), but they will be able attack enemies with melee weapons. They will also be able to acquire better weapons and level up with experience from killing enemies to increase health and damage.

### 2.5 Constraints
Player health will not be able to be refilled at any point during a level. The player/user will get a certain amount of hearts at the beginning of the level depending on difficulty and player experience. At the beginning of each level the player's health will be returned to full.

### 2.6 Assumptions and Dependencies
Does your system depend on external software packages? System assumptions? If so, describe them.
For our game, we will be requiring that for the full experience the user will be using a Virtual Reality headset and joycons in order to look around and traverse the environment. However, if they do not have access to these devices then we will have a built in option to use keyboard and mouse bindings, however this will not be exactly what we originally intended. For system assumptions, the user will need to have a system that is able to run Unity and connect to the VR headset. This is quite demanding, so I’m sure not all users will be able to run our game.

## 3. Functional Requirements
[User Stories](https://jsy4.github.io/TNaC/userstories)
## 4. System and Non-functional Requirements
### 4.1 External Interface Requirements (User,Hardware,Software,Communications)
Describe what kinds of interfaces your product has, and what they do. Then list specific requirements using item numbers as NF.4.1.X.
##NF.4.1.1 The device running our game must be able to connect, either physically with wired connections or remotely to a virtual reality headset and controllers. Alternatively the user can use keyboard controls from a computer.
##NF.4.1.2 The game can run on both Mac OS and Windows 10.
### 4.2 Performance Requirements
Describe your product's performance needs. Then list specific requirements using item numbers as NF.4.2.X.
##NF.4.2.1 USB 3.0 or faster required on computer.
##NF.4.2.2 8GB RAM or more memory required on computer.
### 4.3 Design Constraints
##NF.4.3.1 The graphic design of the game will be simplistic (geometric / or assets from the unity asset store).
 
### 4.4 Quality Requirements
What quality expectations do your users have? Is your system life-critical? Describe such issues, then list specific requirements using item numbers as NF.4.4.X.
The quality of this product requires the playable game for the user. The gears are properly functioning without any possible harm to the user.
### 4.5 Other Requirements
Anything else you need to say. Use item numbers NF.4.5.X.
##NF.4.5.1 The user should consent to the form saying that there may be a possible motion sickness.
 
## 5. Appendices
Include external documents that describe domain or constraints or any necessary information. Use URL links if possible.
https://www.roadtovr.com/how-to-tell-pc-virtual-reality-vr-oculus-rift-htc-vive-steam-vr-compatibility-tool/

