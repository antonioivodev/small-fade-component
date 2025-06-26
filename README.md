# Small Fade Component

A simple and small component to make *fade-in* and *fade-out* with alpha channel.

## Installation

1. Open Unity and go to `Window` > `Package Manager`.
2. Click on the `+` button in the top left corner.
3. Select `Add package from git URL...`.
4. Enter the URL of the package repository.
5. Click `Add` to install the package.

## Usage

After installing the package, follow these steps:

1. Add the `SmallFadeImageComponent` to any GameObject in your scene.
2. You can then call `FadeIn()` to start the fade-in effect or `FadeOut()` to start the fade-out effect.

### Example

```csharp
public class ExampleUsage : MonoBehaviour
{
    [SerializeField] private SmallFadeImageComponent fadeComponent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SmallFadeImage.FadeIn();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SmallFadeImage.FadeOut();
        }
    }
}
```

<p align="center">
  <img src="demonstration.gif" alt="A demonstration of fade-in and fade-out effect in Unity.">
  <p align="center">Result</p>
</p>
