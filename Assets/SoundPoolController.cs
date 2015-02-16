using UnityEngine;
using System.Collections;

public class SoundPoolController : MonoBehaviour
{
    const int numberOfNotes = 49;

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
    GameObject[] vNotesArray;
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
        vNotesArray = new GameObject[numberOfNotes];

        vNotesArray[0] = transform.FindChild("DO1").gameObject;
        vNotesArray[1] = transform.FindChild("DOS1").gameObject;
        vNotesArray[2] = transform.FindChild("RE1").gameObject;
        vNotesArray[3] = transform.FindChild("RES1").gameObject;
        vNotesArray[4] = transform.FindChild("MI1").gameObject;
        vNotesArray[5] = transform.FindChild("FA1").gameObject;
        vNotesArray[6] = transform.FindChild("FAS1").gameObject;
        vNotesArray[7] = transform.FindChild("SO1").gameObject;
        vNotesArray[8] = transform.FindChild("SOS1").gameObject;
        vNotesArray[9] = transform.FindChild("LA1").gameObject;
        vNotesArray[10] = transform.FindChild("LAS1").gameObject;
        vNotesArray[11] = transform.FindChild("SI1").gameObject;
        vNotesArray[12] = transform.FindChild("DO2").gameObject;
        vNotesArray[13] = transform.FindChild("DOS2").gameObject;
        vNotesArray[14] = transform.FindChild("RE2").gameObject;
        vNotesArray[15] = transform.FindChild("RES2").gameObject;
        vNotesArray[16] = transform.FindChild("MI2").gameObject;
        vNotesArray[17] = transform.FindChild("FA2").gameObject;
        vNotesArray[18] = transform.FindChild("FAS2").gameObject;
        vNotesArray[19] = transform.FindChild("SO2").gameObject;
        vNotesArray[20] = transform.FindChild("SOS2").gameObject;
        vNotesArray[21] = transform.FindChild("LA2").gameObject;
        vNotesArray[22] = transform.FindChild("LAS2").gameObject;
        vNotesArray[23] = transform.FindChild("SI2").gameObject;
        vNotesArray[24] = transform.FindChild("DO3").gameObject;
        vNotesArray[25] = transform.FindChild("DOS3").gameObject;
        vNotesArray[26] = transform.FindChild("RE3").gameObject;
        vNotesArray[27] = transform.FindChild("RES3").gameObject;
        vNotesArray[28] = transform.FindChild("MI3").gameObject;
        vNotesArray[29] = transform.FindChild("FA3").gameObject;
        vNotesArray[30] = transform.FindChild("FAS3").gameObject;
        vNotesArray[31] = transform.FindChild("SO3").gameObject;
        vNotesArray[32] = transform.FindChild("SOS3").gameObject;
        vNotesArray[33] = transform.FindChild("LA3").gameObject;
        vNotesArray[34] = transform.FindChild("LAS3").gameObject;
        vNotesArray[35] = transform.FindChild("SI3").gameObject;
        vNotesArray[36] = transform.FindChild("DO4").gameObject;
        vNotesArray[37] = transform.FindChild("DOS4").gameObject;
        vNotesArray[38] = transform.FindChild("RE4").gameObject;
        vNotesArray[39] = transform.FindChild("RES4").gameObject;
        vNotesArray[40] = transform.FindChild("MI4").gameObject;
        vNotesArray[41] = transform.FindChild("FA4").gameObject;
        vNotesArray[42] = transform.FindChild("FAS4").gameObject;
        vNotesArray[43] = transform.FindChild("SO4").gameObject;
        vNotesArray[44] = transform.FindChild("SOS4").gameObject;
        vNotesArray[45] = transform.FindChild("LA4").gameObject;
        vNotesArray[46] = transform.FindChild("LAS4").gameObject;
        vNotesArray[47] = transform.FindChild("SI4").gameObject;
        vNotesArray[48] = transform.FindChild("DO5").gameObject;
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

    }
}
