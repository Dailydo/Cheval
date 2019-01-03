using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour {

    public GameObject _dialogTitleText;
    public GameObject _dialogBodyText;
    public GameObject _dialogButtonText;

    private Text _titleText;
    private Text _bodyText;
    private Text _buttonText;

    private Dialog_SO _currentDialog;
    private int _dialogIndex = 0;       //Keeps track of the body line displayed


    //Assigns scripts to private variables to make them easily accessible
    public void Awake()
    {
        _titleText = _dialogTitleText.GetComponent<Text>();
        _bodyText = _dialogBodyText.GetComponent<Text>();
        _buttonText = _dialogButtonText.GetComponent<Text>();
    }

    //Assigns the dialog to the dialogBox
    public void InitializeDialogBox(Dialog_SO dialog)
    {
        _currentDialog = dialog;
        _dialogIndex = 0;

        _titleText.text = _currentDialog._title;
        _bodyText.text = _currentDialog._body[_dialogIndex];
        _buttonText.text = "Continue";
    }

    //Unfolds dialog as long as there are lines to display, then end up the dialog
    public void ContinueDialog()
    {
        if ((_dialogIndex + 1) < (_currentDialog._body.Count))
        {
            _dialogIndex++;
            _bodyText.text = _bodyText.text + "\n" + _currentDialog._body[_dialogIndex];

            if ((_dialogIndex + 1) >= (_currentDialog._body.Count))
                _buttonText.text = "Close";
        }
        else
        {
            Dialog.instance.HideDialogUI();
        }
    }
}
