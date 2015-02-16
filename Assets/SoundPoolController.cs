using UnityEngine;
using System.Collections;

public class SoundPoolController : MonoBehaviour
{
    const int NUMBER_OF_NOTES = 49;

    #region Note Constants
    const int DO1 = 0, DO2 = 12, DO3 = 24, DO4 = 36, DO5 = 48,
              DOS1 = 1, DOS2 = 13, DOS3 = 25, DOS4 = 37,
               RE1 = 2, RE2 = 14, RE3 = 26, RE4 = 38,
              RES1 = 3, RES2 = 15, RES3 = 27, RES4 = 39,
               MI1 = 4, MI2 = 16, MI3 = 28, MI4 = 40,
               FA1 = 5, FA2 = 17, FA3 = 29, FA4 = 41,
              FAS1 = 6, FAS2 = 18, FAS3 = 30, FAS4 = 42,
               SO1 = 7, SO2 = 19, SO3 = 31, SO4 = 43,
              SOS1 = 8, SOS2 = 20, SOS3 = 32, SOS4 = 44,
               LA1 = 9, LA2 = 21, LA3 = 33, LA4 = 45,
              LAS1 = 10, LAS2 = 22, LAS3 = 34, LAS4 = 46,
               SI1 = 11, SI2 = 23, SI3 = 35, SI4 = 47;
    #endregion

    private bool isNotesSetUp = false;
    GameObject[] notesArray;
    private static SoundPoolController sPrivateInstance;
    public static SoundPoolController sInstance
    {
        get
        {
            if (sPrivateInstance == null)
            {
                sfCreatePool();
            }
            return sPrivateInstance;
        }
    }

    private static void sfCreatePool()
    {
        GameObject lPool = GameObject.Instantiate(Resources.Load("Prefab/SystemPool/SoundPool") as GameObject) as GameObject;
        sPrivateInstance = lPool.GetComponent<SoundPoolController>();
        if (!sPrivateInstance.isNotesSetUp) sPrivateInstance.fSetupNotes();
    }

    private void fSetupNotes()
    {
        isNotesSetUp = true;
        notesArray = new GameObject[NUMBER_OF_NOTES];

        notesArray[0] = transform.FindChild("DO1").gameObject;
        notesArray[1] = transform.FindChild("DOS1").gameObject;
        notesArray[2] = transform.FindChild("RE1").gameObject;
        notesArray[3] = transform.FindChild("RES1").gameObject;
        notesArray[4] = transform.FindChild("MI1").gameObject;
        notesArray[5] = transform.FindChild("FA1").gameObject;
        notesArray[6] = transform.FindChild("FAS1").gameObject;
        notesArray[7] = transform.FindChild("SO1").gameObject;
        notesArray[8] = transform.FindChild("SOS1").gameObject;
        notesArray[9] = transform.FindChild("LA1").gameObject;
        notesArray[10] = transform.FindChild("LAS1").gameObject;
        notesArray[11] = transform.FindChild("SI1").gameObject;
        notesArray[12] = transform.FindChild("DO2").gameObject;
        notesArray[13] = transform.FindChild("DOS2").gameObject;
        notesArray[14] = transform.FindChild("RE2").gameObject;
        notesArray[15] = transform.FindChild("RES2").gameObject;
        notesArray[16] = transform.FindChild("MI2").gameObject;
        notesArray[17] = transform.FindChild("FA2").gameObject;
        notesArray[18] = transform.FindChild("FAS2").gameObject;
        notesArray[19] = transform.FindChild("SO2").gameObject;
        notesArray[20] = transform.FindChild("SOS2").gameObject;
        notesArray[21] = transform.FindChild("LA2").gameObject;
        notesArray[22] = transform.FindChild("LAS2").gameObject;
        notesArray[23] = transform.FindChild("SI2").gameObject;
        notesArray[24] = transform.FindChild("DO3").gameObject;
        notesArray[25] = transform.FindChild("DOS3").gameObject;
        notesArray[26] = transform.FindChild("RE3").gameObject;
        notesArray[27] = transform.FindChild("RES3").gameObject;
        notesArray[28] = transform.FindChild("MI3").gameObject;
        notesArray[29] = transform.FindChild("FA3").gameObject;
        notesArray[30] = transform.FindChild("FAS3").gameObject;
        notesArray[31] = transform.FindChild("SO3").gameObject;
        notesArray[32] = transform.FindChild("SOS3").gameObject;
        notesArray[33] = transform.FindChild("LA3").gameObject;
        notesArray[34] = transform.FindChild("LAS3").gameObject;
        notesArray[35] = transform.FindChild("SI3").gameObject;
        notesArray[36] = transform.FindChild("DO4").gameObject;
        notesArray[37] = transform.FindChild("DOS4").gameObject;
        notesArray[38] = transform.FindChild("RE4").gameObject;
        notesArray[39] = transform.FindChild("RES4").gameObject;
        notesArray[40] = transform.FindChild("MI4").gameObject;
        notesArray[41] = transform.FindChild("FA4").gameObject;
        notesArray[42] = transform.FindChild("FAS4").gameObject;
        notesArray[43] = transform.FindChild("SO4").gameObject;
        notesArray[44] = transform.FindChild("SOS4").gameObject;
        notesArray[45] = transform.FindChild("LA4").gameObject;
        notesArray[46] = transform.FindChild("LAS4").gameObject;
        notesArray[47] = transform.FindChild("SI4").gameObject;
        notesArray[48] = transform.FindChild("DO5").gameObject;
    }

    void Awake()
    {
        sPrivateInstance = this;
        if (!isNotesSetUp) fSetupNotes();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayNote(DO1);
        }
    }

    public void PlayNote(int pNote)
    {
        PlayNote(pNote, 1.0f);
    }

    public void PlayNote(int pNote, float pVolume)
    {
        AudioSource lAudio = notesArray[pNote % NUMBER_OF_NOTES].audio;
        lAudio.volume = pVolume;
        lAudio.Play();
    }

    public class SongData
    {
        
    }

    public class NoteData
    {

    }
}
