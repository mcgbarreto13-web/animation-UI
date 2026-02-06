using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
  
  public ParticleSystem systemParticle;
    public void OnClick()
    {
        systemParticle.Play();
    }
}
