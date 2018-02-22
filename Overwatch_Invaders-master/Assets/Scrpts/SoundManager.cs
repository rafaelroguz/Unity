using UnityEngine;
using UnityEngine.Audio;
using Misc;
namespace Script.Managers
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        public AudioMixer masterAudioMixer;
        //public User_Data user;
        private bool fxEnabled = true;
        private bool musicEnabled = true;
        private bool masterEnabled = true;
        //private SaveManager saveManager;
        private AudioSource musicSource;
        //private AudioSource musicBefore;

        void Start()
        {
            //user.load ();
            instance = this;
            musicSource = GetComponent<AudioSource>();
            //saveManager = SaveManager.GetInstance ();
            //fxEnabled = saveManager.LoadFXVolume ();
            //musicEnabled = saveManager.LoadMusicVolume ();
            //musicBefore = musicSource;
            //musicEnabled = user.getMusicStatus();
            //fxEnabled = user.getFxStatus ();
            setMusicStatus();
            setFxStatus();
            SetFXVolume();
            SetMusicVolume();
        }


        private void setMusicStatus()
        {
            //if (user.getMusicStatus () == 0) {
            //	musicEnabled = false;
            //}            
            musicEnabled = PlayerPrefs.GetInt("musicEnabled", 1) == 1;            
        }

        private void setFxStatus()
        {
            fxEnabled = PlayerPrefs.GetInt("fxEnabled", 1) == 1;
            //if (user.getFxStatus () == 0) {
            //	fxEnabled = false;
            //}
        }


        public void ToggleFXVolume()
        {
            fxEnabled = !fxEnabled;
            PlayerPrefs.SetInt("fxEnabled", !fxEnabled ? 0 : 1);            
            //saveManager.SaveFXVolume (fxEnabled);
            SetFXVolume();
        }

        private void SetFXVolume()
        {
            if (fxEnabled)
            {
                masterAudioMixer.SetFloat("VolumeFX", 0f);
            }
            else
            {
                masterAudioMixer.SetFloat("VolumeFX", -80f);
            }
        }


        public void ToggleMusicVolume()
        {
            musicEnabled = !musicEnabled;
            PlayerPrefs.SetInt("musicEnabled", musicEnabled ? 1 : 0);            
            SetMusicVolume();
        }



        private void SetMusicVolume()
        {
            if (musicEnabled)
            {
                masterAudioMixer.SetFloat("VolumeMusic", 0f);
            }
            else
            {
                masterAudioMixer.SetFloat("VolumeMusic", -80f);
            }
        }



        public void ToggleMasterVolume()
        {
            masterEnabled = !masterEnabled;
            SetMasterVolume();
        }

        private void SetMasterVolume()
        {
            if (masterEnabled)
            {
                masterAudioMixer.SetFloat("VolumeMaster", 0f);
            }
            else
            {
                masterAudioMixer.SetFloat("VolumeMaster", -80f);
            }
        }



        public bool GetMusicEnabled()
        {
            return musicEnabled;
        }

        public bool GetFXEnabled()
        {
            return fxEnabled;
        }


        public void ChangeMusic(AudioClip newMusic)
        {
            musicSource.clip = newMusic;
        }
    }
}
