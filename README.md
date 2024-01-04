# KitchenChaos
<div>
 <h1>Multiplayer Unity game done by following a course made by
 <a href="https://www.youtube.com/@CodeMonkeyUnity">CodeMonkey</a>. Learning Unity, C# and github</h1> 
</div>
 

 Massive course that teaches Unity/C# basics like Character Controllers, collisions, C# events and further on more advanced topics like Unity multiplayer system
 with Unity Netcode for gameobjects, Lobby and Relay. Whole project is made by doing clean code, same quality that CodeMonkey himself uses in his own steam games.

 Audios, Containers and Food objects were downloaded.
 <div>
  <h2>
  <a href="https://youtu.be/AmGSEH7QcDg">Singleplayer course video</a><br />
  <a href="https://youtu.be/7glCsF9fv3s">Multiplayer implementation course video</a><br />
   </h2>
 </div>
 
![kitchenchaoskuva](https://github.com/SKIPAH/KitchenChaos/assets/61183450/a5286547-6d7e-400d-801c-ac473d371692)

## Topics and small details what I've learned

Lecture topics in order:  
<div>
  <a href="https://unitycodemonkey.com/kitchenchaoscourse.php">SINGLEPLAYER LECTURES</a><br />  
 </div> 
 
Create project (Setup proper Unity version and Render pipeline)  
Unity layout (modify Unity layout windows to work easier)  
Visual studio (Setup Visual Studio and some extensions)  
Code Style, Naming Rules (defining rules for coding that I follow always)  
Importing Assets (All assets used in course imported)  
Post processing (Learn about Anti aliasing, Screen Space Ambient Occlusion etc)  
Character Controller   
Character visual, Rotation (basics of Vectors and transform)  
Animations  
Cinemachine  
Input System  
Collision Detection (Raycasts)  
Clear counter  
Interact Action, C# Events (Interact action on Clear Counter, EventHandler, Delegates)  
Selected Counter Visual, Singleton Pattern  
Kitchen Object, Scriptable Objects (Storing kitchenobject prefab data into Scriptable objects)  
Kitchen Object Parent (Setup feature to place a kitchen object to a empty parent place)  
Player Pick up, C# Interfaces (Setting up that Counter or a Player can be a Parent to a KitchenObject by implementing interfaces)  
Container Counter (Spawn kitchenobjects)  
Player Pick Up, Drop Objects  
Cutting Counter, Interact alternate (Cut kitchenobjects with another interact button)  
Cutting Recipe SO  
Cutting Progress, World Canvas (Setup world space canvas to show how much a object has been cut)  
Look At Camera (C# enums)  
Trash Counter (Destroy kitchenobject properly)  
Stove Counter, State Machine (Another UI, states for frying a meat)  
Plates Counter  
Plate Pick Up Objects (Add objects to a plate that player is holding)  
Plate complete Visual  
Plate World UI Icons (Show what objects are on the plate)  
Delivery Counter, Shader Graph (Learn about Shader Graphs to create visuals)  
Deliver Manager (Script that creates recipes, that a player must create to earn points)  
Deliver Manager UI (Show recipes)  
Sound Effects (Add music, footsteps, completed/failed recipe)  
Game Start (State machine for different game states)  
Game Over (End game and show points)  
Main Menu, Loading (Loading scenes)  
Pause, Clear Statics (Fix issues related to Scene loading and Statics)  
Options, Audio levels  
Options, Key rebinding  
Controller Input, Menu Navigation  
Polish (Particles, UI elements)  

 <div>
  <a href="https://unitycodemonkey.com/kitchenchaosmultiplayercourse.php">MULTIPLAYER COURSE LECTURES</a>  
 </div>


Install Netcode and Basic Setup (Netcode for Game objects setup and spawn Player with it. How Network Objects work)  
Sync Player Movement, Client VS Server Authoritative (ClientRPC and ServerRPC)  
Sync Player Animations (NetworkAnimator component)  
Sync Delivery Manager (Show same recipes to all players)  
Fix Selected Counter Visual  
Sync Pick up Objects (NetworkObject.Spawn(), synchronizing objects across the network)  
Sync Kitchen Object Parent (How parenting works to dynamically spawned Objects)  
Sync plates Counter (show same amount of plates on each player)  
Sync Trash Counter (Despawn/Destroy network objects properly)  
Sync Cutting Counter (Show same state for each player for the cutting progress)  
Sync Stove Counter (Network Variables, ternary conditional operator)  
Sync Plate Add Ingredients  
Player Collisions   
Sync Game State (Synchronizing states for all players)  
Sync Pausing   
Handle Disconnects  
Handle Late Joins  
Connection Scene Flow (Network scene Loading)  
Character Select Scene (Choose player color and name)  
Lobby (Setup a lobby system to create public/private lobbies)  
Relay (Setup accessible server on the internet that any player can join without firewall/port problems)  
Game Server Hosting(Multiplay), Matchmaker, Vivox  
Multiplayer Debugging Tools (Test game with different latencies and packet loss and fix problems caused by those)  
Singleplayer Option  
Gamepad Test (Setup controller support for Multiplayer menus)  
