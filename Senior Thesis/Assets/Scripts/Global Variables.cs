using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static int itemsFound;
    public static int numberOfPeopleTalkedTo;
    public static bool inEmailCollider;
    public static bool inNewsArticleCollider;
    public static bool inKeycardItemCollider;
    public static bool foundKeycard;
    public static bool triedKeycardOnDoor;
    public static bool foundNewsArticle;
    public static bool foundEmail;
    public static bool foundJanitorHint;
    public static bool foundSecretaryHint;

    public static bool talkedST = false;
    public static bool talkedMY = false;
    public static bool talkedSR = false;
    public static bool talkedYZ = false;
    public static bool talkedPB = false;
    public static bool talkedXJ = false;
    public static bool talkedYR = false;
    public static bool talkedJH = false;
    public static bool talkedYH = false;

    public static UnityEngine.Vector3 characterPosition1 = new Vector3(-1.3f, -3.52f, 0.0f);
    public static UnityEngine.Vector3 characterPosition2 = new Vector3(1.0f, -1.0f, 0.0f);
    public static UnityEngine.Vector3 characterPosition1meeting = new Vector3(-0.96f, -2.05f, 0.0f);
    public static UnityEngine.Vector3 characterPosition2meeting = new Vector3(-0.96f, -2.05f, 0.0f);
    public static UnityEngine.Vector3 characterPosition1mbath = new Vector3(-1.08f, -1.037f, 0.0f);
    public static UnityEngine.Vector3 characterPosition2mbath = new Vector3(-1.08f, -1.037f, 0.0f);
    public static UnityEngine.Vector3 characterPosition1fbath = new Vector3(-0.999f, -1.032f, 0.0f);
    public static UnityEngine.Vector3 characterPosition2fbath = new Vector3(-0.999f, -1.032f, 0.0f);
    public static UnityEngine.Vector3 characterPositionInfirmary = new Vector3(-0.91f, 1.21f, 0.0f);
    public static UnityEngine.Vector3 characterPositionLounge = new Vector3(2.34f, -2.85f, 0.0f);
    public static UnityEngine.Vector3 characterPositionBroadcast = new Vector3(-0.26f, -0.7f, 0.0f);
    public static UnityEngine.Vector3 characterPositionMachineRoom = new Vector3(-0.26f, -0.7f, 0.0f);


    public static string sceneNameSaver;

    public static bool inElevatorCollider1;
    public static bool inElevatorCollider2;
    public static bool inMeetingRoomCollider1;
    public static bool inMaleBathroomCollider1;
    public static bool inFemaleBathroomCollider1;
    public static bool inMeetingRoomCollider2;
    public static bool inMaleBathroomCollider2;
    public static bool inFemaleBathroomCollider2;
    public static bool inKeycardCollider;
    public static bool inSTCollider;
    public static bool inMYCollider;
    public static bool inMYCollider2;
    public static bool inMYCollider32;
    public static bool inSRCollider;
    public static bool inYRCollider;
    public static bool inYRCollider33;
    public static bool inYZCollider;
    public static bool inYZCollider2;
    public static bool inYZCollider33;
    public static bool inPBCollider;
    public static bool inXJCollider;
    public static bool inXJCollider2;
    public static bool inJHCollider;
    public static bool inYHCollider;




    public static bool interrogatingYing;
    public static bool interrogatingSuRong;
    public static bool interrogatingYiZheng;
    public static bool interrogatingXiaoJing;
    public static bool interrogatingYingHei;
    public static bool interrogatingShaoTing;
    public static bool interrogatingYongRuan;
    public static bool interrogatingPinBi;
    public static bool interrogatingMinKai;

    public static bool currentlyTalking;

    public static bool foundFuse;
    public static bool foundBobbyPin;
    public static bool foundMagnet;

    public static bool inFuseCollider;
    public static bool inFuse2Collider;
    public static bool inHoleCollider;
    public static bool inHoleCollider2;
    public static bool inBobbyPinCollider;
    public static bool inDrawerCollider;
    public static bool inDrawer2Collider;
    public static bool inDragonCollider2;
    public static bool inSnakeCollider2;
    public static bool inRabbitCollider2;
    public static bool talkedYZ2;
    public static bool inElevatorLevel2;

    public static bool switchingFuseColliders;
    public static bool switchingXJColliders;
    public static bool switchingHoleColliders;
    public static bool switchingDrawerColliders;
    public static bool powerOn;

    public static bool displayedCubeText;
    public static bool displayedStatuesText;


    public static bool finishedBlock;


    public static string dragonColor;
    public static string snakeColor;
    public static string rabbitColor;
    public static bool changedColor;



    public static bool hasFuse;
    public static bool hasWire;
    public static bool hasCube;
    public static bool hasBobbyPin;
    public static bool hasMagnet;
    public static bool hasMedReport;




    //Notebook
    public static bool noteMei;
    public static bool noteMinKai;
    public static bool notePinBi;
    public static bool noteShaoTing;
    public static bool noteSuRong;
    public static bool noteXiaoJing;
    public static bool noteYingHei;
    public static bool noteYiZheng;
    public static bool noteYongRuan;

    public static bool noteMei2;
    public static bool noteMinKai2;
    public static bool notePinBi2;
    public static bool noteSuRong2;
    public static bool noteXiaoJing2;
    public static bool noteYiZheng2;
    public static bool noteYongRuan2;

    public static bool ElevatorHint;
    public static bool FuseHint;
    public static bool HoleHint;
    public static bool DrawerHint;
    public static bool MagnetHint;
    public static bool MedicalReportHint;
    public static bool OrangeHint;

    public static bool noteMei3;
    public static bool noteMinKai3;
    public static bool noteSuRong3;
    public static bool noteYiZheng3;
    public static bool noteYongRuan3;

    public static bool CrowbarHint;
    public static bool MonitorHint;
    public static bool PhotoHint;
    public static bool CCTVHint;
    public static bool MeiHealthHint;
    public static bool ToolboxKeyHint;
    public static bool DNAHint;

    //level3
    public static bool inNoteTextCollider;
    public static bool inPhotoCollider;
    public static bool inMonitor2Collider;
    public static bool inPaintingCollider;
    public static bool inInvestigationReportCollider;
    public static bool inSafeCollider;
    public static bool sawInvestigationReport;
    public static bool hasMedicalPills;
    public static bool beatSimonSays;
    public static bool beatFreeFlow;

    public static bool hasYingDNA;
    public static bool hasSuRongDNA;
    public static bool hasJanitorDNA;
    public static bool hasYiZhengDNA;
    public static bool hasYongRuanDNA;
    public static bool hasDNAResults;

    public static bool switchJanitor3Collider;
    public static bool switchToolboxCollider;
    public static bool hasCrowbar;


    //Music
    public static bool music1Started;
    public static bool music2Started;
    public static bool music3Started;
    public static bool music4Started;
    public static bool music5Started;
    public static bool music6Started;






    //public static bool inKeycardGuesser;


}
