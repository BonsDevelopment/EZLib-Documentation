# Free Mode

**Description**

The free mode feature allows developers have their application in a development stage until it is in a production stabe.

Please note that this feature is optional and is not required for your application to run.

## Using Free Mode

__Requirements__
* A created [application](https://ezlib.io/apps/new)

__Enabling the free mode feature__

1. Navigate to the EZLib website and onto the application page
2. Click `Edit Application`
3. Click `Application Settings`
4. Enable the `Free Mode` feature

__Checking if the application is in free mode__

1. Navigate to the class where you initialize EZLib

C#:
```csharp
using System;
using System.Windows.Forms;

namespace EZLib.Example
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = new EzLibSettings
            {
                AntiDebug = false,
                AntiDump = false,
                AntiVm = false,
                AntiSandboxie = false
            };

            var init = new Initialize("APP_TOKEN", "APP_VERSION", settings);

            if (init.IsFreeMode())
                Application.Run(new MainForm());
            else
                Application.Run(new LoginForm());
        }
    }
}
```

VB:
```vb
Imports System
Imports System.Windows.Forms

Namespace EZLib.Example
    Friend Module Program
        Private Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim settings = New EzLibSettings With {
                .AntiDebug = False,
                .AntiDump = False,
                .AntiVm = False,
                .AntiSandboxie = False
            }
            Dim init = New Initialize("APP_TOKEN", "APP_VERSION", settings)

            If init.IsFreeMode() Then
                Application.Run(New MainForm())
            Else
                Application.Run(New LoginForm())
            End If
        End Sub
    End Module
End Namespace
```
