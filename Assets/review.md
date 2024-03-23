- Advatages:
    - Quiet clear separation in handling logic and UI, organized according to the MVC pattern.
    - All UI is in 1 scene, opening and closing is managed by UIManager proving good performance.
    - The games is managed by states and has event registration for each state when changing states proving a strict and easy to control logic.

- Disadvantages:
  - The game uses many constants of absolute paths leading to risks when moving files 
  - The structure of the game is too tight, making it difficult to expand or separate modules
  - The game board is recreated every time a level is started. If the game board has many components, it will lead to performance degradation.
  - In initializing the table, creating too many cell items over and over without considering using the pool reduces performance (This has been modified in the exam answers)