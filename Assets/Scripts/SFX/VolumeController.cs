using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
    [SerializeField] AudioMixer gameMixer;
    [SerializeField] Slider generalVolumeSlider;
    [SerializeField] Slider musicVolumeSlider;
    [SerializeField] Slider effectsVolumeSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Music") || PlayerPrefs.HasKey("Effects") || PlayerPrefs.HasKey("Master"))
        {
            LoadMusicVolume();
            LoadMasterVolume();
            LoadEffectsVolume();
        }
        else
        {
            SetMusicVolume();
            SetGeneralVolume();
            SetEffectsVolume();
        }
    }
    public void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        gameMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Music", volume);
    }
    public void SetEffectsVolume()
    {
        float volume = effectsVolumeSlider.value;
        gameMixer.SetFloat("EffectsVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Effects", volume);
    }
    public void SetGeneralVolume()
    {
        float volume = generalVolumeSlider.value;
        gameMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Master", volume);
    }
    public void LoadMusicVolume()
    {
        musicVolumeSlider.value = PlayerPrefs.GetFloat("Music");
        SetMusicVolume();
    }
    public void LoadEffectsVolume()
    {
        effectsVolumeSlider.value = PlayerPrefs.GetFloat("Effects");
        SetEffectsVolume();
    }
    public void LoadMasterVolume()
    {
        generalVolumeSlider.value = PlayerPrefs.GetFloat("Master");
        SetGeneralVolume();
    }
}
