# in-class-activities
## Devlogs
Wei Chen, he/him
### W1
When you run the game, the Camera will no longer move with the Cat. The Cat can move around, but the Camera stays in its original position. This happens because the Camera is no longer a child of the Cat, so it does not automatically follow the Cat’s position or movement.

[Working Itch page](https://muphone.itch.io/gdim-31-w1-in-class-activity)

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. The r, g, and b are floats because they are color values and can have decimal values such as 0.3f or 0.9f. An Int cannot hold decimal values; it only holds whole numbers. bools store either true or false, and strings store text.
2. I think _bounce is an int because it counts how many times the ball has bounced. A bounce is always a whole number, so there is no reason to use a decimal value.
3. The error informed me that the line was missing a semicolon at the end. I learned that C# statements need a semicolon to show that the statement is complete.

### W3
Table Number: 15

Activity 1: methods discussion
1. For this method, I think the parameters should be an int for the player's friendship level and a bool for whether the player knows the character's secret. The return type should be a string as this method has to return as the text of the character’s dialogue. The response could change depending on the player's friendship level and whether they know the secret.
2. For this method, I would use a float for the player's sanity level because the percentage could include decimal numbers. The return type should be void since the method only changes the brightness of the lights and doesn't need to return a value.
3. This method should take two float parameters, one of them being the time when the player presses the key and the other one being the time of the beat happens. The return type should be a bool as we do not need any other information than whether the player has successfully hit the beat or not. It would return true if the timing was close enough and false if it wasn't.

Activity 2: Components & classes metaphor
In our table, we discussed that the classes and Components can be compared to recipes and  the finished dishes of a restaurant. A class can be compared to a recipe that tells the composition of what it should have in a dish and how to make it. A component can be compared to a dish prepared on the basis of a recipe, and there can be different dishes prepared on the same recipe with different details. The member variables are like the ingredients and their amounts, such as how much salt or sugar to use. Methods are like the cooking instructions because they describe what the dish can do or how it is prepared. In Unity, we can use the same class to create Components with different values, just like a restaurant can use one recipe to make several slightly different dishes.

Activity 3: methods coding activity
I think the balls get extremely bright because every time they bounce fast enough, the code multiplies their current color by 1.5. Because the ball's color keeps getting multiplied instead of returning to its original value, the brightness increases more and more after each bounce. Eventually, the color values become very high, which makes the balls look extremely bright in the Scene.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
