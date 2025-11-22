using UnityEngine;

[CreateAssetMenu(fileName = "PPiece", menuName = "Scriptable Objects/Items")]
public class PPiece : ScriptableObject
{
    public string pieceName;
    public GameObject goalPlacement;
    public Sprite icon;
    public bool rightPiece;
}

