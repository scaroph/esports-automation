﻿using System;
using Framework.Selenium;
using League.Com.Pages;

namespace League.Com
{
    public static class Esports
    {
        [ThreadStatic] public static HomePage Home;

        [ThreadStatic] public static StandingsPage Standings;

        public static void Init()
        {
            Home = new HomePage();
            Standings = new StandingsPage();
        }

        public static void Goto()
        {
            Driver.Goto("https://nexus.leagueoflegends.com/en-us/esports/");
            Driver.Wait.Until(driver => Home.Map.PlayNowSignupButton.Displayed);
        }
    }
}