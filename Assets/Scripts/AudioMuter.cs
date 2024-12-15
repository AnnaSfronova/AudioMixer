using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMuter : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private Toggle _toggle;

    private float _minVolume = -80f;
    private float _maxVolume = 0f;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(Mute);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(Mute);
    }

    private void Mute(bool value)
    {
        _mixer.audioMixer.SetFloat(_mixer.name, _toggle.isOn ? _maxVolume : _minVolume);
    }
}
