# Unity3D-AKAILDP8
This package is a snimple snippet for using AKAI LDP8 midi controller using Keijiro Takashi Mini library : https://github.com/keijiro/Minis

## Install Package
This package uses the scoped registry feature to import dependent packages.
Please add the following sections to the package manifest file (Packages/manifest.json).

To the scopedRegistries section:
```
{
    "name": "Bonjour-lab",
    "url": "https://registry.npmjs.com",
    "scopes": [
    "com.bonjour-lab"
    ]
}
```

To the dependencies section:

```
"com.bonjour-lab.akaildp8": "X.X.X",
```

After changes, the manifest file should look like below:
```
{
  "scopedRegistries": [
    {
      "name": "Bonjour-lab",
      "url": "https://registry.npmjs.com",
      "scopes": [
        "com.bonjour-lab"
      ]
    }
  ],
  "dependencies": {
    "com.bonjour-lab.akaildp8": "X.X.X",
    ...
```

## Use inside unity
Add the ```AKAIController.cs``` to your controller.
You can then subscribe to the ```OnAKAIInputChange(AKAIController.AKAIInputChange data)``` event and retreive action whenever you its triggered.
The struct ```AKAIController.AKAIInputChange data``` is described as :

```
public struct AKAIInputChange{
    public TYPE type; //either AKAIController.TYPE.PAD or AKAIController.TYPE.KNOB
    public int index; //index from 0 to 7
    public float value; //value of the controller between 0 → 1
}
```

An example is setup on the GITHUB host
