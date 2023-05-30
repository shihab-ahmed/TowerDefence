# TowerDefence
Description will be added later


Actor Blueprints: These are used for objects placed or spawned in the game world, such as a character, a piece of scenery, or an interactive object. Actor Blueprints can contain components (like a Static Mesh, Camera, or Light component), and they can have behaviors defined through Blueprint scripting.

Pawn Blueprints: These are a subclass of Actor Blueprints that can receive input from a player or AI controller. These are commonly used for controllable characters or vehicles in the game.

Character Blueprints: These are a subclass of Pawn Blueprints that include additional built-in functionality for character movement and animation, like walking, running, and jumping.

PlayerController Blueprints: These are used for interpreting player input and controlling Pawns. Each player in a game has a PlayerController which determines how the player interacts with the game world.

GameMode Blueprints: These define the rules of the game, like the win/lose conditions, the number of players, which PlayerController to use, and so on.

Widget Blueprints: These are used to create interactive UI elements in the game, like buttons, sliders, health bars, and menus.

Animation Blueprints: These control complex animation behavior, defining how a character or object should animate in response to different game states or conditions.







Animation Blueprints in Unreal Engine 5 (UE5) are special types of blueprints specifically designed to handle complex animation logic for characters and other Skeletal Meshes. They control how a character or object should animate in response to different game states or conditions.

The key components of an Animation Blueprint are:

Animation Graph: This is where you set up the logic for what animations to play and when to play them. You use nodes to blend animations, modify them, and control them based on various conditions.

State Machines: These are often used in the Animation Graph to manage complex animation logic. They allow you to define different "states" that an animation can be in (like "running", "jumping", or "idle"), and then define how to transition between these states.

Event Graph: This is similar to the event graph in a regular Blueprint. It's used for procedural processing, like reacting to events in the game or calculating values each frame. You can use this to process variables that control your Animation Graph.

Anim Notifies: These are markers that can be added to specific frames of an animation sequence and can be used to trigger events when those frames are played.

Blend Spaces: These are special assets used to smoothly blend between different animations based on one or two input variables. For example, a Blend Space could be used to blend between walking and running animations based on the character's speed.

Animation Montages: These are used to override or add to the base animations defined in the Animation Blueprint. Montages are typically used for one-off actions like a jump or attack animation that should interrupt the base animations.

With Animation Blueprints, developers can create intricate, dynamic, and responsive animations for their games, providing a higher level of immersion and realism. As such, Animation Blueprints are an essential part of character design and control in UE5.
