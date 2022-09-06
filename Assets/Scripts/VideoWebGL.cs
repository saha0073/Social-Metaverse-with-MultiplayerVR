using Photon.Pun;
using UnityEngine;
using UnityEngine.Video;

public class VideoWebGL : MonoBehaviour
{
    [Header("References...")]
    public VideoPlayer Video;
    private Transform PlayersView;
    //public string VideoLocation;
    private GameObject Player;

    [Header("Audio...")]
    public AnimationCurve distanceInterpolation = AnimationCurve.Linear(0, 0, 1, 1);
    public float minDistance = 1;
    public float maxDistance = 30;
    

    private void Start()
    {
        /*
        //string myUserId = PhotonNetwork.LocalPlayer.UserId;
        Player = GameObject.Find(PhotonNetwork.LocalPlayer.UserId.ToString());
        //Player = GameObject.Find("Player(Clone)");
        if (Player != null)
        {
            Debug.Log("in player start");
            PlayersView = Player.GetComponent<Transform>();

        }*/
        
        //Video.url = System.IO.Path.Combine(Application.streamingAssetsPath, VideoLocation);
    }

    private void Update()
    {
        if (Player == null)
        {
            //Player = GameObject.Find(PhotonNetwork.LocalPlayer.UserId.ToString());
            Player = GameObject.Find("Generic VR Player(Clone)");
            if (Player.GetComponent<PhotonView>().IsMine)
            {
                GameObject XRRig = Player.transform.GetChild(0).gameObject;
                PlayersView = XRRig.GetComponent<Transform>();
                

            }
            
        }
        Debug.Log("player position  " + PlayersView.position);
        var currentDistance = Vector3.Distance(transform.position, PlayersView.position);
        var relativeDistance = Mathf.Clamp01((currentDistance - minDistance) / (maxDistance - minDistance));
        var currentVolume = distanceInterpolation.Evaluate(1 - relativeDistance);
        Debug.Log("currentdistance " + currentDistance);
        Debug.Log("currentvolume  " + currentVolume + " relativeDistance " + relativeDistance);
        Video.SetDirectAudioVolume(0, currentVolume);

    }

    private void FixedUpdate()
    {
        //Debug.Log("player position  "+transform.position);
    }

    /*
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(.5f, .5f, 1, 1);
        Gizmos.DrawWireSphere(transform.position, minDistance);
        Gizmos.DrawWireSphere(transform.position, maxDistance);
    }*/
}
