using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GroundController : MonoBehaviour {

	//public GameObject decisionText;
	public GameObject headsImage;
	public GameObject tailsImage;
	public GameObject flipBtn;
	public GameObject coin;

	//private Text _decision;
	private RawImage 	   _headsImage;
	private RawImage 	   _tailsImage;
	private CoinController _coin;

	// Use this for initialization
	void Start () 
	{
		_headsImage = headsImage.GetComponent<RawImage>();
		_tailsImage = tailsImage.GetComponent<RawImage>();

		_coin = coin.GetComponent<CoinController>();

		_headsImage.gameObject.SetActive(false);
		_tailsImage.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		Button btn = flipBtn.GetComponent<Button>();
		btn.onClick.AddListener(flipIt);

		if(!_coin.flipIt)
		{

			if(col.gameObject.CompareTag("headSide"))
			{
				//_decision.text = "Heads";
				_tailsImage.gameObject.SetActive(true);

				_coin.flipIt = false;

			
			}
			else if(col.gameObject.CompareTag("tailSide"))
			{
	//			_decision.text = "Tails!";
				_headsImage.gameObject.SetActive(true);
				_coin.flipIt = false; 


			}
		
		}
	}
		
	//AA: used to test the flipt it button
	void flipIt()
	{
		_coin.flipIt = true;

		_headsImage.gameObject.SetActive(false);
		_tailsImage.gameObject.SetActive(false);
		
	}

}
