using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class GData
{
    public const string SCENE_NAME_TITLE = "01.TitleScene";
    public const string SCENE_NAME_PLAY = "02.PlayScene";

    public const string OBJ_NAME_CURRENT_LEVEL = "Level_1";
}

public enum TerrainType
{
    NONE = -1,
    PLAIN_PASS,
    OCEAN_N_PASS
}
