using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMuter : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private Toggle _toggle;

    private float _minVolume = -80f;
    private float _maxVolume = 0f;

    private void Awake()
    {
        _toggle.onValueChanged.AddListener(Mute);
    }

    private void Mute(bool _)
    {
        if (_toggle.isOn)
            _mixer.audioMixer.SetFloat(_mixer.name, _maxVolume);
        else
            _mixer.audioMixer.SetFloat(_mixer.name, _minVolume);
    }
}
