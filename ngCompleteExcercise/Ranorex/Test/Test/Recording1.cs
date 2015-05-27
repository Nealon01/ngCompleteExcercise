﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("a8a3414a-67d1-4604-8c44-c936e55e55d4", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestRepository repository.
        /// </summary>
        public static TestRepository repo = TestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://wikipedia.com' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("http://wikipedia.com", "chrome", "", false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Wikipedia.EnglishWikipediaTheFreeEncyclopedi' at 86;22.", repo.Wikipedia.EnglishWikipediaTheFreeEncyclopediInfo, new RecordItemIndex(1));
            repo.Wikipedia.EnglishWikipediaTheFreeEncyclopedi.Click("86;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WikipediaTheFreeEncyclopedia.GuidanceOnHowToUseAndEditWikipedi' at 9;7.", repo.WikipediaTheFreeEncyclopedia.GuidanceOnHowToUseAndEditWikipediInfo, new RecordItemIndex(2));
            repo.WikipediaTheFreeEncyclopedia.GuidanceOnHowToUseAndEditWikipedi.Click("9;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -5280 units.", new RecordItemIndex(3));
            Mouse.ScrollWheel(-5280);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WikipediaTheFreeEncyclopedia.WikipediaFAQ' at 35;5.", repo.WikipediaTheFreeEncyclopedia.WikipediaFAQInfo, new RecordItemIndex(4));
            repo.WikipediaTheFreeEncyclopedia.WikipediaFAQ.Click("35;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -1320 units.", new RecordItemIndex(5));
            Mouse.ScrollWheel(-1320);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by 2400 units.", new RecordItemIndex(6));
            Mouse.ScrollWheel(2400);
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}