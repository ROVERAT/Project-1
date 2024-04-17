using UnityEngine;

[CreateAssetMenu(fileName = "Parameters", menuName = "GameParameters/Parameters", order = 1)]
public class Parameters : ScriptableObject
{
    public GameObject[] peshki;
    public Sprite[] sprites;
    public int[] lvls;
    public int tcena, manna;
}
