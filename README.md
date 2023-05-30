# TowerDefence
Description will be added later


Actor Blueprints: These are used for objects placed or spawned in the game world, such as a character, a piece of scenery, or an interactive object. Actor Blueprints can contain components (like a Static Mesh, Camera, or Light component), and they can have behaviors defined through Blueprint scripting.

Pawn Blueprints: These are a subclass of Actor Blueprints that can receive input from a player or AI controller. These are commonly used for controllable characters or vehicles in the game.

Character Blueprints: These are a subclass of Pawn Blueprints that include additional built-in functionality for character movement and animation, like walking, running, and jumping.

PlayerController Blueprints: These are used for interpreting player input and controlling Pawns. Each player in a game has a PlayerController which determines how the player interacts with the game world.

GameMode Blueprints: These define the rules of the game, like the win/lose conditions, the number of players, which PlayerController to use, and so on.

Widget Blueprints: These are used to create interactive UI elements in the game, like buttons, sliders, health bars, and menus.

Animation Blueprints: These control complex animation behavior, defining how a character or object should animate in response to different game states or conditions.
