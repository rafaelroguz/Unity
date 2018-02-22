using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using GlobalData;

public class SaveManager : MonoBehaviour//Singleton<SaveManager>
{
	/*const string PASSWORD = "Q63LC2aT6cAZrjgL";
	public const string MAX_WAVE_REACHED_ID = "MAX_WAVE_REACHED_ID";
	public const string CURRENT_WAVE_ID = "CURRENT_WAVE_ID";
	public const string MAX_SCORE_ID = "MAX_SCORE_ID";
	public const string MONEY_ID = "MONEY_ID";
	public const string COINS_ID = "COINS_ID";
	public const string MAX_ENEMIES_KILLED_ID = "MAX_ENEMIES_KILLED_ID";
	public const string CURRENT_ENEMIES_KILLED_ID = "CURRENT_ENEMIES_KILLED_ID";
	public const string TIME_PASSED_ID = "TIME_PASSED_ID";
	public const string ACTIVE_ITEM_ID = "ACTIVE_ITEM_ID";
	public const string MUSIC_VOLUME_ID = "MUSIC_VOLUME_ID";
	public const string FX_VOLUME_ID = "FX_VOLUME_ID";
	public const string CURRENT_SKIN_INDEX_ID = "CURRENT_SKIN_INDEX_ID";
	public const string SKINS_LIST_ID = "SKINS_LIST_ID";
	public const string DEFAULT_BOY_SKIN_ID = "DEFAULT_BOY_SKIN_ID";
	public const string DEFAULT_GIRL_SKIN_ID = "DEFAULT_GIRL_SKIN_ID";
	public const string BEATRIX_KIDDO_SKIN_ID = "BEATRIX_KIDDO_SKIN_ID";
	public const string DEADPOOL_SKIN_ID = "DEADPOOL_SKIN_ID";
	public const string TEACHER_SKIN_ID = "TEACHER_SKIN_ID";
	public const string WONDER_WOMAN_SKIN_ID = "WONDER_WOMAN_SKIN_ID";
	public const string CURRENT_LANGUAGE_ID = "CURRENT_LANGUAGE_ID";

	string getNameFileWithSettings()
	{
		return FILE_KEYS.SAVE_DATA_ROOT.ToString () +".bytes?encrypt=true&password=" + PASSWORD + "&tag=";
	}

	public void SaveMaxWaveReached(int waveReached)
	{
		if (waveReached > LoadMaxWaveReached ()) 
		{
			GameManager.GetInstance ().newWavesRecord = true;
			saveIntData (MAX_WAVE_REACHED_ID, waveReached);
			//ES2.Save (waveReached, getNameFileWithSettings () + FILE_KEYS.MAX_WAVE_REACHED.ToString ());
		} else 
			{
				GameManager.GetInstance ().newWavesRecord = false;
			}
	}

	public int LoadMaxWaveReached()
	{
		if (IsSavedData(MAX_WAVE_REACHED_ID))
		{
			return loadIntData (MAX_WAVE_REACHED_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.MAX_WAVE_REACHED.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.MAX_WAVE_REACHED.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}


	public void SaveCurrentWave(int waveReached)
	{
		saveIntData (CURRENT_WAVE_ID, waveReached);
		//ES2.Save (waveReached, getNameFileWithSettings () + FILE_KEYS.CURRENT_WAVE.ToString ());
	}

	public int LoadCurrentWave()
	{
		if (IsSavedData(CURRENT_WAVE_ID))
		{
			return loadIntData (CURRENT_WAVE_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.CURRENT_WAVE.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.CURRENT_WAVE.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}

	public void SaveMaxScore(int score)
	{
		if (score > LoadMaxScore ()) 
		{
			GameManager.GetInstance ().newScoreRecord = true;
			saveIntData (MAX_SCORE_ID, score);
			//ES2.Save (score, getNameFileWithSettings () + FILE_KEYS.SCORE.ToString ());
		} else 
			{
				GameManager.GetInstance ().newScoreRecord = false;
			}
	}

	public int LoadMaxScore()
	{
		if (IsSavedData(MAX_SCORE_ID))
		{
			return loadIntData (MAX_SCORE_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.SCORE.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.SCORE.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}

	public void SaveMoney(int money)
	{
		saveIntData (MONEY_ID, money);
		//ES2.Save (money, getNameFileWithSettings() + FILE_KEYS.MONEY_COLLECTED.ToString());
	}


	public int LoadMoney()
	{
		if (IsSavedData(MONEY_ID))
		{
			return loadIntData (MONEY_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.MONEY_COLLECTED.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.MONEY_COLLECTED.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}

	public void SaveCoins(int coins)
	{
		saveIntData (COINS_ID, coins);
		//ES2.Save (coins, getNameFileWithSettings() + FILE_KEYS.COINS_COLLECTED.ToString());
	}

	public int LoadCoins()
	{
		if (IsSavedData(COINS_ID))
		{
			return loadIntData (COINS_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.COINS_COLLECTED.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.COINS_COLLECTED.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}


	public void SaveMaxEnemiesKilled(int enemiesKilled)
	{
		if (enemiesKilled > LoadMaxEnemiesKilled ()) 
		{
			GameManager.GetInstance ().newEnemiesKilledRecord = true;
			saveIntData (MAX_ENEMIES_KILLED_ID, enemiesKilled);
			//ES2.Save (enemiesKilled, getNameFileWithSettings () + FILE_KEYS.MAX_ENEMIES_KILLED.ToString ());
		} else 
			{
				GameManager.GetInstance ().newEnemiesKilledRecord = false;
			}
	}

	public int LoadMaxEnemiesKilled()
	{
		if (IsSavedData(MAX_ENEMIES_KILLED_ID))
		{
			return loadIntData (MAX_ENEMIES_KILLED_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.MAX_ENEMIES_KILLED.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.MAX_ENEMIES_KILLED.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}


	public void SaveCurrentEnemiesKilled(int enemiesKilled)
	{
		saveIntData (CURRENT_ENEMIES_KILLED_ID, enemiesKilled);
		//ES2.Save (enemiesKilled, getNameFileWithSettings () + FILE_KEYS.CURRENT_ENEMIES_KILLED.ToString ());
	}

	public int LoadCurrentEnemiesKilled()
	{
		if (IsSavedData(CURRENT_ENEMIES_KILLED_ID))
		{
			return loadIntData (CURRENT_ENEMIES_KILLED_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.CURRENT_ENEMIES_KILLED.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.CURRENT_ENEMIES_KILLED.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}


	public void SaveTimePassed(float timePassed)
	{
		saveFloatData (TIME_PASSED_ID, timePassed);
		//ES2.Save (timePassed, getNameFileWithSettings() + FILE_KEYS.TIME_PASSED.ToString());
	}

	public float LoadTimePassed()
	{
		if (IsSavedData(TIME_PASSED_ID))
		{
			return loadFloatData (TIME_PASSED_ID);
		} else 
			{
				return 0f;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.TIME_PASSED.ToString ())) 
//		{
//			return ES2.Load<float> (getNameFileWithSettings () + FILE_KEYS.TIME_PASSED.ToString ());
//		} else 
//			{
//				return 0f;
//			}
	}

	public void SaveActiveItem(ShopItemObject itemToSave)
	{
		//TODO
		ES2.Save (itemToSave, getNameFileWithSettings() + FILE_KEYS.ACTIVE_ITEMS.ToString() + itemToSave.itemFunctionType.ToString());
	}

	public ShopItemObject LoadActiveItem(ActiveItemTypes itemType)
	{
		//TODO
		ShopItemObject newItemObject = new ShopItemObject ();
		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.ACTIVE_ITEMS.ToString () + itemType.ToString())) 
		{
			return ES2.Load<ShopItemObject> (getNameFileWithSettings () + FILE_KEYS.ACTIVE_ITEMS.ToString () + itemType.ToString());
		} else 
			{
				return newItemObject;
			}
	}
		

	#region OPTIONS

	public void SaveMusicVolume(bool isEnabled)
	{
		saveBoolData (MUSIC_VOLUME_ID, isEnabled);
		//ES2.Save (isEnabled, getNameFileWithSettings() + FILE_KEYS.MUSIC_VOLUME_KEY.ToString());
	}

	public bool LoadMusicVolume()
	{
		if (IsSavedData(MUSIC_VOLUME_ID))
		{
			return loadBoolData (MUSIC_VOLUME_ID);
		} else 
			{
				return true;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.MUSIC_VOLUME_KEY.ToString ())) 
//		{
//			return ES2.Load<bool> (getNameFileWithSettings () + FILE_KEYS.MUSIC_VOLUME_KEY.ToString ());
//		} else 
//			{
//				return true;
//			}
	}

	public void SaveFXVolume(bool isEnabled)
	{
		saveBoolData (FX_VOLUME_ID, isEnabled);
		//ES2.Save (isEnabled, getNameFileWithSettings() + FILE_KEYS.FX_VOLUME_KEY.ToString());
	}

	public bool LoadFXVolume()
	{
		if (IsSavedData(FX_VOLUME_ID))
		{
			return loadBoolData (FX_VOLUME_ID);
		} else 
			{
				return true;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.FX_VOLUME_KEY.ToString ())) 
//		{
//			return ES2.Load<bool> (getNameFileWithSettings () + FILE_KEYS.FX_VOLUME_KEY.ToString ());
//		} else 
//			{
//				return true;
//			}
	}

	public void SaveCurrentSkinIndex(int skinIndex)
	{
		saveIntData (CURRENT_SKIN_INDEX_ID, skinIndex);
		//ES2.Save (skinIndex, getNameFileWithSettings() + FILE_KEYS.CURRENT_SKIN.ToString());
	}


	public int LoadCurrentSkin()
	{
		if (IsSavedData(CURRENT_SKIN_INDEX_ID))
		{
			return loadIntData (CURRENT_SKIN_INDEX_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.CURRENT_SKIN.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.CURRENT_SKIN.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}

	public void SaveSkin(SkinStoreObject skinToSave, string skinId)
	{
		string skinData = JsonUtility.ToJson (skinToSave);
		//Debug.Log ("Save skin method, skin data: " + skinData);
		saveStringData (skinId, skinData);
		//ES2.Save (skinToSave, getNameFileWithSettings() + skinToSave.skinTheme.ToString() + FILE_KEYS.SKIN_OBJECT.ToString());
	}

	public SkinStoreObject LoadSkin(ClothesTheme skinTheme, string skinId)
	{
		if (IsSavedData(skinId))
		{
			//Debug.Log ("Loaded skin: " + skinId);
			string dataString = loadStringData (skinId);
			return JsonUtility.FromJson<SkinStoreObject> (dataString);
		} else 
			{
				return new SkinStoreObject ();
			}
//		if (ES2.Exists (getNameFileWithSettings () + skinTheme.ToString () + FILE_KEYS.SKIN_OBJECT.ToString ())) 
//		{
//			return ES2.Load<SkinStoreObject> (getNameFileWithSettings () + skinTheme.ToString () + FILE_KEYS.SKIN_OBJECT.ToString ());
//		} else 
//			{
//				return new SkinStoreObject ();
//			}
	}

//	public Dictionary<int, bool> LoadSkinsDictionary()
//	{
//		
//	}

	public void SaveLanguageIndex(int languageIndex)
	{
		saveIntData (CURRENT_LANGUAGE_ID, languageIndex);
		//ES2.Save (languageIndex, getNameFileWithSettings() + FILE_KEYS.CURRENT_LANGUAGE.ToString());
	}

	public int LoadLanguageIndex()
	{
		if (IsSavedData(CURRENT_LANGUAGE_ID))
		{
			return loadIntData (CURRENT_LANGUAGE_ID);
		} else 
			{
				return 0;
			}
//		if (ES2.Exists (getNameFileWithSettings () + FILE_KEYS.CURRENT_LANGUAGE.ToString ())) 
//		{
//			return ES2.Load<int> (getNameFileWithSettings () + FILE_KEYS.CURRENT_LANGUAGE.ToString ());
//		} else 
//			{
//				return 0;
//			}
	}

	#endregion OPTIONS

	public void ClearData()
	{
//		if(ES2.Exists(getNameFileWithSettings()))
//		{
//			ES2.Delete (getNameFileWithSettings());
//		}
	}




	public void DeleteAllSaved()
	{
		deleteAllKeys();
	}
			
	#region data_access_manager_conection
	private bool IsSavedData(string saveId)
	{
		return DataAccessManager.isSavedKey(saveId);
	}

	private string loadStringData(string saveId)
	{
		return DataAccessManager.loadString (saveId);
	}

	private float loadFloatData(string saveId)
	{
		return DataAccessManager.loadFloat(saveId);
	}

	private int loadIntData(string saveId)
	{
		return DataAccessManager.loadInt (saveId);
	}

	private bool loadBoolData(string saveId)
	{
		return DataAccessManager.loadBool (saveId);
	}

	private Dictionary<TOne,TTwo> loadDictionaryData<TOne,TTwo>(string saveId)
	where TOne : struct
	where TTwo : struct
	{
		return DataAccessManager.loadDictionary<TOne,TTwo>(saveId);
	}

	private List<T> loadList<T>(string saveId)
	where T:struct
	{
		return DataAccessManager.loadList<T> (saveId);
	}

	private void saveDictionaryData<TOne,TTwo>(string saveId, Dictionary<TOne,TTwo> dictionary)
	where TOne :struct
	where TTwo :struct
	{
		DataAccessManager.saveDictionary (saveId, dictionary);
	}

	private void saveListData<T>(string saveId, List<T> list)
	where T:struct
	{
		DataAccessManager.saveList (saveId, list);
	}

	private void saveFloatData(string saveId, float value)
	{
		DataAccessManager.saveFloat (saveId, value);
	}

	private void saveIntData(string saveId, int value)
	{
		DataAccessManager.saveInt (saveId, value);
	}

	private void saveBoolData(string saveId, bool value)
	{
		DataAccessManager.saveBool (saveId, value);
	}

	private void saveStringData(string saveId, string value)
	{
		DataAccessManager.saveString (saveId, value);
	}

	private void deleteKey(string saveId)
	{
		DataAccessManager.deleteKey (saveId);
	}

	private void deleteAllKeys()
	{
		DataAccessManager.deleteAllKeys();
	}
	#endregion*/
}
