using Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.Models;
using Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator.TextualDecorator;
using CharacterCreator2D;
using CharacterCreator2D.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextualCreator : MonoBehaviour
{
    public CharacterViewer character;
    bool _processing = false;
    public string CharacterName;
    public RuntimeDialog dialog;
    public InputField inputfield;
    //public InputField bodyfield, hairfield, facialHairfield;


    public void LoadCharacterFromJSON(string path)
    {
        _processing = true;
        if (!string.IsNullOrEmpty(path))
        {
            this.character.LoadFromJSON(path);
            dialog.DisplayDialog("Generate Character", "Character generated succesfully.");
        }
        _processing = false;
    }

    public void GenerateCharater()
    {
        _processing = true;
        // Character is being created
        CharacterName = inputfield.text;
        string path = string.Format("Assets/TestCharacters/{0}.json", CharacterName);
        // path = ModelDecoratorDemo.Decorate(new Specification() { Gender = 1 });
        // string jsone = ModelDecoratorDemo.GetJSONFromSpecification();
        Debug.Log(path);
        //Debug.Log(jsone);
        LoadCharacterFromJSON(path);
        //Clears input field
        ClearInput();
        _processing = false;
    }

    public void ClearInput()
    {
        inputfield.Select();
        inputfield.text = "";
    }
}



