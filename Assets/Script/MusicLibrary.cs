using UnityEngine;

[System.Serializable]
public struct MusicTrack
{
    public string trackname;
    public AudioClip clip;
}
public class MusicLibrary : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public MusicTrack[] tracks;
    public AudioClip GetFromName(string trackname)
    {
        foreach (var track in tracks)
        {
        if (track.trackname == trackname)
        {
            return track.clip;

        }
    }
    return null;
    }
}