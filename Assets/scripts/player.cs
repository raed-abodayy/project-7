using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class player 
{
public string playerName = "";
public int health;
public int fullhealth;
public static int playercount = 0;

public void InitializPlayer (string name ,int initialHealth)
{
playercount++; 
playerName = name;
health=initialHealth;
}
public void Heal(int amount)
{
health=health+amount;
Debug.Log(health);
}
public void Heal(bool fullRestore)
{if (fullRestore)
{health=100;
Debug.Log("health is full");
}}
public void ShowPlayerCount()
{
Debug.Log("total number of players:"+playercount);
}}