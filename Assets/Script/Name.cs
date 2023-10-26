using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{
    void Start()
    {
        FindPartyMember("Tristan Alanne", 3);
    }
    public void FindPartyMember(string MyName, int MyNumber)
    {
        List<string> QuestPartyMembers = new List<string>()
    {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the Knight"
    };
        
        QuestPartyMembers.Insert(MyNumber, MyName);
        int listLength = QuestPartyMembers.Count;
        //QuestPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", listLength);
        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i,
    QuestPartyMembers[i]);
        }
    }
    // Update is called once per frame
    void Update()
{

}
}