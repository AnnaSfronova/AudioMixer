using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Button _button;

    private void Awake()
    {
        _button.onClick.AddListener(Play);
    }

    private void Play()
    {
        _audio.Play();
    }
}
