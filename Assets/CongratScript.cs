using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CongratScript : MonoBehaviour
{
    private TextMesh text;
    public ParticleSystem sparksParticles;
    private List<string> textToDisplay;
    private int currentText;
    private bool textSwitch;

    // Start is called before the first frame update
    void Start()
    {
        textToDisplay = new List<string>();
        text = GameObject.Find("TextDisplay").GetComponent<TextMesh>();
        currentText = 0;
        textSwitch = true;
        textToDisplay.Add("Congratulations");
        textToDisplay.Add("All Errors Fixed");
        text.text = textToDisplay[0];
        sparksParticles.Play();
        InvokeRepeating("changeText", 0, 1.5f);
    }

    void changeText()
    {
        switch (textSwitch)
        {
            case false:
                currentText = 1;
                text.text = textToDisplay[currentText];
                textSwitch = !textSwitch;
                break;
            case true:
                currentText = 0;
                text.text = textToDisplay[currentText];
                textSwitch = !textSwitch;
                break;
        }
    }
}

/**
CODE ERRORS:

- Missing bracket to close the update method
- Rotating Speed value lacking 'f' to define as float
- Missing semicolon after currentText
- Variables are not written in camel case
- Failed to define 'using System.Collections.Generic'; causing error with List variable type
- 'Congratulation' is incorrect grammar; should be 'Congratulations'
- textToDisplay is not defined
- currentText sets its value before its value is used in the if statement; causing text to not change
- Text switching is done in an inefficient manner; switched to boolean variable to determine what text to be displayed and changed if statement to switch
- Using the update method to run a counter is inefficient; created seperate function and InvokeRepeating method to repeat it from the start.
- timeToNextText is unnecessary and inefficient with InvokeRepeating.
- rotatingSpeed is unused and thus unnecessary.
- Update() is unused and thus unnecessary.

SCENE ERRORS:

- Text object not assigned to text display
- Particle object not assigned to text display
- Script assigned to the text object itself instead of an empty object

*/