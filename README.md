# Progression
1. start with initial "universal 2d" project, committed that
2. initial "worlds most boring game"
    - added images folder
    - created Bird game object
        - sprite renderer
        - dragged the image onto the sprite renderer's sprite
    - zoomed out the camera and changed background color
3. reacts to input
    - added RigidBody2D
        - gravity scale to 4 (saved by SampleScene.unity)
    - added CircleCollider2D
    - added BirdScript.cs
        - gravity scale to 12  (saved by BirdScript.cs)
            - values found by experimentation in play mode, though the play settings arent sticky and will always revert to whatever the script had and whatever the scene had
