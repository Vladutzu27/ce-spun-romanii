using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using SimpleFileBrowser;
using UnityEngine.SceneManagement;

public class ImportJSON : MonoBehaviour
{
    public static ImportJSON instance;

    void Awake()
    {
        instance = this;
    }

    public TextAsset gameData; // A variable to store the selected JSON file

    public void SelectJSONFile()
    {
        // Set filters (optional)
        FileBrowser.SetFilters(true, new FileBrowser.Filter("JSON Files", ".json"));

        // Show a load file dialog and wait for a response from the user
        StartCoroutine(ShowLoadDialogCoroutine());
    }

    private IEnumerator ShowLoadDialogCoroutine()
    {
        // Show a load file dialog and wait for a response from the user
        yield return FileBrowser.WaitForLoadDialog(FileBrowser.PickMode.Files, false, null, null, "Load JSON File", "Load");

        // Check if the user has selected a file
        if (FileBrowser.Success)
        {
            // Get the selected file path
            string filePath = FileBrowser.Result[0];

            // Read the contents of the file into a string
            string jsonString = File.ReadAllText(filePath);

            // Set the gameData variable to the selected JSON file
            gameData = new TextAsset(jsonString);

            PlayerPrefs.SetInt("slot", 69);
            SceneManager.LoadScene("Jocul");
        }
    }
}