using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    int level;
    enum Screen { MainMenu, WaitingForPassword, Win };
    Screen currentScreen;
    string password;

    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Select the difficulty:\n\n");
        Terminal.WriteLine("1) Easy.");
        Terminal.WriteLine("2) Medium.");
        Terminal.WriteLine("3) Hard.");
        Terminal.WriteLine("Enter your selection:");
    }




    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        if (currentScreen == Screen.WaitingForPassword)
        {
            
            CheckPassword(input);
        }
    }





    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "lol";
            print("You chose level 1!");
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "pussy";
            print("You chose level 2!");
            StartGame();
        }
        else
        {
            Terminal.WriteLine("You've chosen a valid selection!");
        }
    }





    void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You have choosen level " + level);
        Terminal.WriteLine("Please, enter your password:");
        currentScreen = Screen.WaitingForPassword;

    }



    void CheckPassword (string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Well done!");
        }
        else
        {
            Terminal.WriteLine("Wrong password! Try again.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
