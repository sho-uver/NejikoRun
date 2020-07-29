using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour {
    const int StageChipSize = 30;
    int currentChipIndex;
    public Transform character;
    public GameObject[] stageChips;
    public int startChipIndex;
    public int preInstantiate;
    public List<GameObject> generateStageList = new List<GameObject> ();

    // Start is called before the first frame update
    void Start () {
        currentChipIndex = startChipIndex - 1;
        UpdateStage (preInstantiate);
    }

    // Update is called once per frame
    void Update () {
        int charaPositionIndex = (int) (character.position.z / StageChipSize);
        if (charaPositionIndex + preInstantiate > currentChipIndex) {
            UpdateStage (charaPosition)
        }
    }
}