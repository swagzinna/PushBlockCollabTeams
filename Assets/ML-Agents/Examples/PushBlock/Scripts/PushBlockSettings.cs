using UnityEngine;

public class PushBlockSettings : MonoBehaviour
{
    /// <summary>
    /// The "walking speed" of the agents in the scene.
    /// </summary>
    public float agentRunSpeed;

    /// <summary>
    /// The agent rotation speed.
    /// Every agent will use this setting.
    /// </summary>
    public float agentRotationSpeed;

    /// <summary>
    /// The spawn area margin multiplier.
    /// ex: .9 means 90% of spawn area will be used.
    /// .1 margin will be left (so players don't spawn off of the edge).
    /// The higher this value, the longer training time required.
    /// </summary>
    public float spawnAreaMarginMultiplier;

    /// <summary>
    /// When a goal is scored by team green the ground will switch to this
    /// material for a few seconds.
    /// </summary>
    public Material teamGreenGoalScored;

    /// <summary>
    /// When a goal is scored by team red the ground will switch to this
    /// material for a few seconds.
    /// </summary>
    public Material teamRedGoalScored;

    /// <summary>
    /// When an agent fails, the ground will turn this material for a few seconds.
    /// </summary>
    public Material failMaterial;


    /// <summary>
    /// True when it is a single team environment. False if there are Multiple teams.
    /// </summary>
    public bool isMultiTeam;

    public bool calcAverageTime;

}
