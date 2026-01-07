# Steel-Ball

---

![License](https://img.shields.io/github/license/HammonDDDDD/Steel-Ball?style=flat&logo=opensourceinitiative&logoColor=white&color=blue)
[![OSA-improved](https://img.shields.io/badge/improved%20by-OSA-yellow)](https://github.com/aimclub/OSA)

---

## Overview

Steel-Ball is a physics-based adventure game where players navigate through multiple levels, collect gems, and battle bosses. It offers customizable difficulty modes and character appearances, providing an engaging progression experience with persistent gem tracking across levels.

---

## Table of Contents

- [Core Features](#core-features)
- [Installation](#installation)
- [Contributing](#contributing)
- [License](#license)
- [Citation](#citation)

---

## Core Features

1. **Player Movement System**: Physics-based player movement with forward force and side-to-side controls using Rigidbody physics, including adjustable force parameters and casual/hardcore mode variations.
2. **Gem Collection Mechanic**: Collectible gem system with persistent tracking across levels, audio feedback on collection, and visual display of collected gems in the UI.
3. **Boss Battle System**: Dynamic boss fight mechanics with health tracking, visual state changes (red eyes), special attack interactions, and defeat sequence with player transformation.
4. **Level Progression**: Multi-level game structure with scene management, gem persistence between levels, and automatic progression to next level upon completion.
5. **Life System & Obstacle Interaction**: Player life counter system with obstacle collisions reducing lives and game over mechanics when lives are depleted.
6. **Game State Management**: Centralized game manager handling game restart, level completion UI, gem tracking, and player state reset functionality.

---

## Installation

Install Steel-Ball using one of the following methods:

**Build from source:**

1. Clone the Steel-Ball repository:
```sh
git clone https://github.com/HammonDDDDD/Steel-Ball
```

2. Navigate to the project directory:
```sh
cd Steel-Ball
```

3. Install the project dependencies:
```sh
pip install -r requirements.txt
```

---

## Contributing

- **[Report Issues](https://github.com/HammonDDDDD/Steel-Ball/issues)**: Submit bugs found or log feature requests for the project.
- **[Submit Pull Requests](https://github.com/HammonDDDDD/Steel-Ball/tree/main/.github/CONTRIBUTING.md)**: To learn more about making a contribution to Steel-Ball.

---

## License

This project is protected under the The Unlicense. For more details, refer to the [LICENSE](https://github.com/HammonDDDDD/Steel-Ball/tree/main/LICENSE) file.

---

## Citation

If you use this software, please cite it as below.

### APA format:

    HammonDDDDD (2025). Steel-Ball repository [Computer software]. https://github.com/HammonDDDDD/Steel-Ball

### BibTeX format:

    @misc{Steel-Ball,
        author = {HammonDDDDD},
        title = {Steel-Ball repository},
        year = {2025},
        publisher = {github.com},
        journal = {github.com repository},
        howpublished = {\url{https://github.com/HammonDDDDD/Steel-Ball.git}},
        url = {https://github.com/HammonDDDDD/Steel-Ball.git}
    }

---