# Data Persistence in Unity

Learn how to save and load data in Unity - avoiding common mistakes and dangerous serialization techniques many other tutorials will tell you to use!

[![Youtube Tutorial](./Video%20Screenshot.png)](https://youtu.be/mntS45g8OK4)

In this repository and tutorial video we'll look at using text-based serialization using JSON and optionally encrypt that data. I also discuss some of the pros/cons for using text-based serialization, and what you should use instead if you really want to/need to use a binary serialization technique.

Common suggestions that you should absolutely not use to persist game state data are:

1. Player Prefs - these are not designed for storing game state. Only...Player Preferences such as graphic & audio settings.
2. BinaryFormatter - this class is dangerous and insecure. Use of this class can allow an attacker to take over the system. https://docs.microsoft.com/en-us/dotnet/standard/serialization/binaryformatter-security-guide 

## Patreon Supporters
Have you been getting value out of these tutorials? Do you believe in LlamAcademy's mission of helping everyone make their game dev dream become a reality? Consider becoming a Patreon supporter and get your name added to this list, as well as other cool perks.
Head over to https://patreon.com/llamacademy to show your support.

### Phenomenal Supporter Tier
* YOUR NAME HERE!

### Tremendous Supporter Tier
* YOUR NAME HERE!

### Awesome Supporter Tier
* Andrew Bowen
* Gerald Anderson
* AudemKay
* Paul Berry
* Matt Parkin
* Ivan
* YOUR NAME HERE!

### Supporters
* Bastian
* Trey Briggs
* YOUR NAME HERE!

## Other Projects
Interested in other AI Topics in Unity, or other tutorials on Unity in general? 

* [Check out the LlamAcademy YouTube Channel](https://youtube.com/c/LlamAcademy)!
* [Check out the LlamAcademy GitHub for more projects](https://github.com/llamacademy)

## Requirements
* Requires Unity 2020.3 LTS or higher.
