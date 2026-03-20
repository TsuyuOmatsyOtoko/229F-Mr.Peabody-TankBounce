using UnityEngine;

[System.Serializable]
public struct MusicTrack
{
    public string trackname;
    public AudioClip clip;
}
public class MusicLibarary : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public MusicTrack[] tracks;
    public AudioClip GetFromName(string trackname)
    {
        foreach (var track in track)
        {
        if (Track.trackname == tracks)
        {
            return track.clip;

        }
    }
    return null;
    }
}