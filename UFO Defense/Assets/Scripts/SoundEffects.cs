using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
	public AudioSource laser;

	public void PlayLaser()
	{
		laser.Play();
	}
}
