using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

	public Text 	  decision;
	public Text 	  sliderValue;
	public Text 	  sliderSpdValue;
	public Button 	  quitBtn;
	public GameObject headsImage;
	public GameObject tailsImage;
	//public float 	  xMin, xMax, yMin, yMax, zMin, zMax;
	public Slider 	  sliderTurns;
	public Slider 	  sliderSpd;

//	[Range(1.0f, 8.0f)]
//	public float 	  turn;
//
//	[Range(1.0f, 50.0f)]
//	public float 	  speed;

	public AudioClip  coinDrop;
	public AudioClip  coinFlip;

	[Range(1.0f, 50.0f)]
	public float flipHeight;
	public bool  flipIt;

	private Rigidbody   _rb;
	private AudioSource _audioSrc;
	private RawImage 	_headsImage;
	private RawImage 	_tailsImage;

	// Use this for initialization
	void Start () 
	{
		_rb 	  = GetComponent<Rigidbody>();
		_audioSrc = GetComponent<AudioSource>();

//		Button exitBtn = quitBtn.GetComponent<Button>();
//
//		exitBtn.onClick.AddListener(quitApp);
	}

	// Update is called once per frame
	void Update () 
	{
		sliderValue.text    = "" + sliderTurns.value + "";
		sliderSpdValue.text = "" + sliderSpd.value + "";

//		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
//		{
//			
//			flipIt = true;
//			_headsImage.gameObject.SetActive(false);
//			_tailsImage.gameObject.SetActive(false);
//
//		}

		if (Input.GetKey("escape"))
			Application.Quit();

	}

	void FixedUpdate()
	{
		if(flipIt)
		{
			//_audioSrc = GetComponent<AudioSource>();
			//_audioSrc.PlayOneShot(coinFlip, 1f);

			//Vector3 up = new Vector3(0.0f, flipHeight, 0.0f);
			_rb.AddForce(0, sliderTurns.value, 0, ForceMode.Impulse);

			_rb.transform.Rotate(transform.right, 45 * Time.deltaTime * sliderSpd.value);

		}

	}

	void OnTriggerEnter(Collider col)
	{
		
		if(col.gameObject.CompareTag("ground"))
		{
			Debug.LogWarning("ground: it is false");

			_audioSrc.PlayOneShot(coinDrop, 1f);

			flipIt = false;
		}

		if(col.gameObject.CompareTag("ceiling"))
		{
			Debug.LogWarning("ceiling: it is false");
			_rb.velocity = new Vector3(_rb.position.x, -20.0f, _rb.position.z);

			flipIt = false;
		}
	}

	public void ShowDecision(Text decide)
	{
		decision = decide;

	}

	void quitApp()
	{
//		if (Input.GetKey(KeyCode.Escape))
//		{
//			if (Application.platform == RuntimePlatform.Android)
//			{
//				Application.Quit();
//			}
//		}

	
	}

}
