# Progression
6. added trigger
    - created a new game object in the middle who was a Box Collider 2D with trigger checkmark
    - set the script to find the ui logic script to call with FindGameObjectByTag
4. pipes moving across the scene
    - started by making the pipe game object which was then dragged to the project folder to create "Pipe.prefab"
        - Pipe contained a top which had a Box Collider 2D and PipeScript.cs
        - Pipe deletes/culls itself (whether the top or the bottom pipe)
    - pipe spawner creates a new copy of the top and bottom pipes offset by some distance every 2 seconds regardless of fps
3. reacts to input
    - added RigidBody2D
        - gravity scale to 4 (saved by SampleScene.unity)
    - added CircleCollider2D
    - added BirdScript.cs
        - gravity scale to 12  (saved by BirdScript.cs)
            - values found by experimentation in play mode, though the play settings arent sticky and will always revert to whatever the script had and whatever the scene had
2. initial "worlds most boring game"
    - added images folder
    - created Bird game object
        - sprite renderer
        - dragged the image onto the sprite renderer's sprite
    - zoomed out the camera and changed background color
1. start with initial "universal 2d" project, committed that
