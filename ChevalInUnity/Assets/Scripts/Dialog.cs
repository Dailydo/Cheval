using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour {

    #region Singleton

    public static Dialog instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Dialog found.");
            return;
        }

        instance = this;
    }

    #endregion

    public GameObject _background;
    public GameObject _dialogBox;
    public Animator _animator;

    public bool _skipEntryDialog = false;           //Temporary, to be removed along _testDialog at some point
    public Dialog_SO _testDialog;


	// Use this for initialization
	void Start () {
        _dialogBox.GetComponent<DialogBox>().InitializeDialogBox(_testDialog);
    }
	
	//Hides the dialog UI
    public void HideDialogUI()
    {
        FadeOut();
    }

    public void FadeIn()
    {
        _animator.SetTrigger("FadeIn");
    }

    public void FadeOut()
    {
        _animator.SetTrigger("FadeOut");
    }

    public void Appear()
    {
        _animator.SetTrigger("Appear");
    }

    public void Disappear()
    {
        _animator.SetTrigger("Disappear");
    }
}
