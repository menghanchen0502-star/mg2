# minigame 2
## Devlog
1. An issue I encountered and how I fixed it:
I wrote _timeleft in the Spell script, but the variable is named _timeLeft. C# cares about capital letters, so it was a different name. I fixed it by changing it to _timeLeft. I also had to add parentheses to the if statement in Step 2.

2. My guess about the line of code:
I think the period means "get the color that belongs to the sprite renderer". I think "new" means making a brand new color. The three numbers are red, green and blue. As the chest's health goes down, r changes, so the chest turns darker red.

## Open-Source Assets
- Pixel art environment & character sprites: https://assetstore.unity.com/packages/2d/environments/pixel-art-top-down-basic-187605
