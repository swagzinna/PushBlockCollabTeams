using UnityEngine;
using UnityEngine.Events;

public class GoalDetectTrigger : MonoBehaviour
{

    [Header("Trigger Collider Tag To Detect")]
    public string redTag = "redGoal"; //collider tag to detect
    public string greenTag = "greenGoal"; //collider tag to detect

    public string tagToDetect = "goal"; //collider tag to detect

    [Header("Goal Value")]
    public float GoalValue = 1;

    private Collider m_col;
    [System.Serializable]
    public class TriggerEvent : UnityEvent<Collider, Collider, float>
    {
    }

    [Header("Trigger Callbacks")]
    public TriggerEvent onTriggerEnterEvent = new TriggerEvent();
    public TriggerEvent onTriggerStayEvent = new TriggerEvent();
    public TriggerEvent onTriggerExitEvent = new TriggerEvent();

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(redTag) || col.CompareTag(greenTag) || col.CompareTag(tagToDetect))
        {
            onTriggerEnterEvent.Invoke(m_col, col, GoalValue);
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.CompareTag(redTag) || col.CompareTag(greenTag) || col.CompareTag(tagToDetect))
        {
            onTriggerStayEvent.Invoke(m_col, col,GoalValue);
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag(redTag) || col.CompareTag(greenTag) || col.CompareTag(tagToDetect))
        {
            onTriggerExitEvent.Invoke(m_col, col,GoalValue);
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        m_col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
