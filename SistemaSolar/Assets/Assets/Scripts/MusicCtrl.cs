using UnityEngine;

public class MusicCtrl: MonoBehaviour {

	private int pMusicNum = 0;
	static public int musicNum = 0;

	public AudioClip[] musics;

	private AudioSource audioS;

	void Start() {
		this.audioS = GetComponent<AudioSource>();

		this.audioS.clip = this.musics[0];
		this.audioS.Play();
	}

	void Update() {
		if (this.pMusicNum != musicNum) {
			this.pMusicNum = musicNum;
			this.audioS.clip = this.musics[musicNum];
			this.audioS.Play();
		}
	}
}
