using System;
using UnityEngine;
using SonicBloom.Koreo;

public class KoreographerTest : MonoBehaviour
{
    // Start is called before the first frame update
    public string trackEventID;
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(trackEventID, HandleEvent);
        Koreographer.Instance.RegisterForEventsWithTime(trackEventID, HandleEventWithTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void HandleEvent(KoreographyEvent koreoEvent)
    {
        throw new NotImplementedException();
    }
    private void HandleEventWithTime(KoreographyEvent koreoEvent, int sampleTime, int sampleDelta, DeltaSlice deltaSlice)
    {
        throw new NotImplementedException();
    }
}
