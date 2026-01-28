# Unity-Pet-Shop-System
A modular pet shop management system

Unity Project: Pet Shop Management System
A clean, modular C# system demonstrating Object-Oriented Programming (OOP) and Script Communication in Unity. This project showcases how to manage multiple objects through a central "Manager" hub using tags and batch processing.

🚀 Key Features
State Management: Pets track their own hunger states and visual representation.

Batch Processing: Uses GameObject.FindGameObjectsWithTag to handle multiple entities simultaneously.

Component-Based Design: Utilizes GetComponent for cross-script communication.

UI Integration: Designed to be triggered via Unity's OnClick event system.

🛠 How it Works
1. The Pet Logic (PetScript.cs)
Every dog in the scene has a PetScript. It starts in a "Hungry" state. When the Eat() method is called:

The isHungry boolean is flipped to false.

The object's Material Color changes to green to provide immediate visual feedback.

A confirmation is sent to the Console.

2. The Command Hub (ShopManager.cs)
Instead of manually clicking every dog, the ShopManager handles the heavy lifting:

It scans the entire scene for any object with the "Dog" tag.

It stores these objects in an Array.

It uses a foreach loop to "reach inside" every dog, grab its specific PetScript, and trigger the Eat() action.
