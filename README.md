# TN_vs_world

TN_vs_world is a small, polished Unity platformer prototype created as a personal project. This repository contains the full Unity project, art assets, and scenes used to build and run the game.

## Key Features

- Tight 2D platforming controls and character animations
- Collectible items and simple scoring system
- Multiple animation states (idle, run, throw, etc.)
- Unity-friendly project structure ready for iteration and polish

## Gameplay

Control a character through short platforming levels, collect gold, and avoid hazards while using responsive movement and animations.

## Controls

- Keyboard: Arrow keys / A-D to move, Space to jump, E or left-click to interact/throw

## Requirements

- Unity 2020.3 LTS or newer (recommended). If you used a different version, open the project in that version.
- Windows/macOS with the Unity Editor installed

## Getting Started

1. Install the recommended Unity version via Unity Hub.
2. Open Unity Hub and click "Add" then select this project's root folder.
3. Open the project in the Unity Editor and allow Unity to import assets and compile scripts.

## Running the Game (Editor)

1. Open the main scene from `Assets/Scenes` (look for a scene named like `Main` or `SampleScene`).
2. Press the Play button in the Unity Editor to run the game locally.

## Building

To create a standalone build:

1. In Unity, go to `File > Build Settings`.
2. Add the desired scene(s) to the Build Settings Scenes list.
3. Choose your target platform (PC, Android, etc.), configure player settings, and click `Build`.

## Project Structure

- `Assets/` — game assets, scripts, scenes, animations, prefabs
- `Library/`, `Temp/`, `Logs/` — Unity-generated folders (do not commit these to version control)
- `ProjectSettings/` — Unity project settings (safe to commit)

Tips: Keep `Assets/` and `ProjectSettings/` under version control and exclude `Library/`, `Temp/`, and `Logs/`.

## Contributing

Contributions are welcome. To contribute:

1. Fork the repository and create a feature branch.
2. Make your changes and test them in the Editor.
3. Open a pull request with a clear description of your changes.

## License

This project is provided "as-is". If you want a formal license, add a `LICENSE` file (for example, MIT).

## Acknowledgements

- Unity documentation and community assets

## Contact

If you'd like help developing this further or want to collaborate, open an issue or reach out via the repo's issue tracker.

