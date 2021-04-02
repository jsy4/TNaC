---
layout: default
title: Architecture
description: People like building stuff.
---
<p>This is architecture.md</p>

The primary requirements that drove our architecture decision were the 3D/VR implementation, including basic game controls, as well as interactions between the user and their environment. Tracking specific data regarding the user's level, health, and weapons as well as enemy data is a core requirement. 

Our game is primarily event driven so the architectual styles we primarily considered were Publish-Subscribe and Black board. 
Publish-Subscribe consists of components interacting by broadcasting and reacting to events. The problem with this style is that the components know nothing about each other. 
Black board works by containing information about current state of system's execution and data-accessing components are reactive based on current contents. Both methods are easily scalable for system evolution and customization. 

Ultimately we decided to use Black Board as our architecture style because the data management is more suitable for our 3D game. The event management in Publish-Subscribe would have been too complex for our interacting components. Some potential issues with Black Board are keeping knowledge sources consistent when sharing data between them, as well as difficulty testing the system. Dependencies between the black board and knowledge sources can be largely impacted by structure changes. 
 
