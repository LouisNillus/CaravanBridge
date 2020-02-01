using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{

    MovingBehaviour mb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<MovingBehaviour>())
        {
            mb = collision.GetComponent<MovingBehaviour>();

            if(mb.racerType.reward != RacerTyper.Reward.NoReward)
            AddRewards(mb, VirtualPlayer.instance);
        }
    }

    public void AddRewards(MovingBehaviour _mb, VirtualPlayer _vp)
    {
        switch(_mb.racerType.reward)
        {
            case RacerTyper.Reward.Iron:
                _vp.iron += _mb.racerType.amount;
                break;
            case RacerTyper.Reward.Wood:
                _vp.wood += _mb.racerType.amount;
                break;
            case RacerTyper.Reward.Money:
                _vp.money += _mb.racerType.amount;
                break;
            case RacerTyper.Reward.Nails:
                _vp.nails += _mb.racerType.amount;
                break;
        }
    }

}
