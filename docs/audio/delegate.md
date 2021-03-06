# DelegateAudioSource

The `DelegateAudioSource` class brings you to playback waveforms generated by callback functions. It provides access to PCM-level, low-layer audio processing.

In the constructor of the DelegateAudioSource class, specify the callback function to handle the actual waveform to be played. For example:

```cs
var player = new AudioPlayer();
var source = new DelegateAudioSource((sampleCount, _) =>
{
    var s = (short)(MathF.Sin(2 * MathF.PI * sampleCount * 440 / 44100) * 10000);
    return (s, s);
});

player.Play(source);
```

In this example, a 440Hz sine wave is generated in the callback function. First argument of the callback is sample index, and the second is start index of loop (null when don't loop), and the return value is `(short, short)` tuple or `null`. Returning null indicates the end of the performance.

See [the actual example](/demo/Scenes/Examples/audio/DelegateExampleScene.cs).