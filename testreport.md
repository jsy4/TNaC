---
layout: default
title: Test Report
description: Life is a test itself.
---

### 1. Component Testing

The scripts were written separately in a different Unity project and were moved to the main Unity project to be implemented after testing if it worked separately. The components testing was done with a separate Unity project for each member. The test we chose mainly focused on the user requirements and were done within the Github project. The requirements were partially met with alpha testing. Each member played the game, testing the requirements and overall performance. The choice of testing was appropriate because the product was not ready to be published.  

### 2. System Testing

When performing system testing for our project, we took into account the different operating systems that the users may be using trying to run our program. In order to conduct these tests, we decided to push our files to Github and pull them from the different operating systems that we think the users may use. The two systems that we tested were Mac and Windows, as we doubted many players would use Linux in order to play games. When testing with these two operating systems, we noticed that we had to constantly change a handful of files every time we pulled because Unity runs differently on each operating system. In order to overcome this obstacle we decided that we would create two different files, one for Mac specific and one for Windows, and simply have them share the files that do not need any file conversion when pushing and pulling. 

### 3. Acceptance Testing

We did our acceptance testing by running our project in the Unity programming environment and compared the simulation to our desired results in order to make a decision on whether the feature was considered to be accepted by the user. The majority of our acceptance criteria was user-oriented and required us to play the game in order to accept features. As a result, most of our system testing was done by running the game in Unity and finding issues by becoming the users.   

**1.0** Movement Controls: Accepted as completely implemented. To test this, we made sure that the user was able to look around with their mouse and move using WASD on the keyboard.  
**1.1** Attacking Controls: Not accepted / not completely implemented. To test this, we will make sure that when an enemy is close enough to the player when they click the left mouse button, the enemy will take damage.  
**2.0** Level Design: Accepted as completely implemented. Level components were designed pleasing to the eye.  
**2.1** Level Content: Accepted as completely implemented. Levels are unique and interesting to explore.   
**2.2** Monster Spawning: Not accepted / not completely implemented. We will check monster spawn locations upon loading in to ensure game fairness.  
**3.1** Experience Points:  Accepted as partially implemented. The user was able to see changes in their points during the playtime. In order to test this, we are displaying the experience point amount on screen while the user is playing so they can see the changes in real time.  
**3.2** Point Distribution: Not accepted / not completely implemented. Refer to 1.1. In order to test this, we will create a separate menu so that when the player reaches certain point thresholds, they will be able to distribute their points.  
**4.1** Different Weapons: Accepted as completely implemented. Choices of weapons were possible with bugs.  
**4.2** Inventory: Not accepted / not completely implemented. Refer to 2.2.  
**4.3** Weapon Effects: Not accepted / not completely implemented. In order to test this we will make it so that there will be visual effects on screen.  
**5.0** Game Installment: Accepted as completely implemented. The game can be downloaded and run in a reasonable amount of time on MAC and Windows.  
**5.1** Game Load Time: Accepted as completely implemented. The load time is within limits.  
**6.0** Game Integrity: Accepted as completely implemented. There is an information page and the game is safe to download and run on your computer without introducing issues/viruses.
