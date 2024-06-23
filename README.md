# Cursor-Follow-Particle
**Unity scene exploring Unity's particle system to emit particles as the cursor moves across the screen.**

Scene 1: Particles Follow the Cursor on the 2D screen/ Particle system in UI.
- Use of an additional camera, "UI Camera", with the main camera for rendering particles on canvas.
- Works with different screen sizes (16:9, 16:9, Free aspect, etc).
     - ScreenToWorldPoint function converts cursor's actual location to window size.
- To show the particle system in UI, follow this [tutorial](https://youtu.be/X_0bocG-jXI)

https://github.com/Himanshu-N/Cursor-Follow-Particle/assets/100259622/63ede372-b1c5-43c0-8c79-c5c45f5fb4c1


Scene 2: Cursor Follow in a 3-Dimensional environment.
- Use of a constant for the distance between the mouse cursor and the particles enables 3D cursor following.
- For the black gradient background
     - Either enable fog in the Windows>Rendering>Lighting>Environment, or
     - Use a spotlight instead of a Directional one.
- Shards are [custom-built](https://www.youtube.com/shorts/pr4waAA293Y?feature=share).
     - Shard images from Google are converted to texture and material.

https://github.com/Himanshu-N/Cursor-Follow-Particle/assets/100259622/bfb1b2d6-d279-4a37-9113-02b90f5b2d64

Black Floor Grid material from [Grid prototype material](https://assetstore.unity.com/packages/2d/textures-materials/grid-prototype-materials-214264).
Ember material from [Unity Particle package](https://assetstore.unity.com/packages/vfx/particles/particle-pack-127325#content).

For in-depth details about the particle system setting, see this [tutorial](https://youtu.be/QPzs2pTZ2sQ).
