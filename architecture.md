---
layout: default
title: Architecture
description: People like building stuff.
---

### Our Group
  * Team name: Three’s Not a Crowd
  * Project: Virtual Retaliate
  * Team members: Miguel Fernandez, Zackery Meyer, Jisun Yoo
   

### Project Overview 

What we are working on is a 3D/VR game. Player has Hp (health) and Lv (level) which will change throughout the game. Levels will have different themes, and it will be composed of enemies spawning from set places to decrease player health. Player will eliminate the enemies and increase level while obtaining new weapons.


### Key Architectural Drivers

The primary requirements that drove our architecture decision were the 3D/VR implementation, including basic game controls, as well as interactions between the user and their environment. Tracking specific data regarding the user's level, health, and weapons as well as enemy data is a core requirement. 


### Architecture Style Choices

Our game is primarily event driven so the architectual styles we primarily considered were Publish-Subscribe and Black board. 
Publish-Subscribe consists of components interacting by broadcasting and reacting to events. The problem with this style is that the components know nothing about each other. 
Black board works by containing information about current state of system's execution and data-accessing components are reactive based on current contents. Both methods are easily scalable for system evolution and customization. 


### Our Architecture

![blackboard](https://user-images.githubusercontent.com/65105285/113374866-6ad2aa80-932b-11eb-80eb-6cbe83e91ca1.png?raw=true). 


### Conclusion

Ultimately we decided to use Black Board as our architecture style because the data management is more suitable for our 3D game. The event management in Publish-Subscribe would have been too complex for our interacting components. Some potential issues with Black Board are keeping knowledge sources consistent when sharing data between them, as well as difficulty testing the system. Dependencies between the black board and knowledge sources can be largely impacted by structure changes. 
 
