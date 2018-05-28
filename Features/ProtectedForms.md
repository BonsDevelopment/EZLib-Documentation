# ProtectedForms

**Description**

The ProtectedForms feature is an anti-form patcher solution. It stops tools like `Cheat Engine` and alike tools.

Please note that this feature is optional and is not required for your application to run.

## Using ProtectedForms

__Requirements__
* A created [application](https://ezlib.io/apps/new)
* EZLib referenced to your project

__Enabling the ProtectedForms feature__

1. Navigate to the forms that require a user to be authenticated and have a valid serial
2. Change the inheritance of `Form` to `ProtectedForms`

C#:
```csharp
using EZLib;

namespace EZLib.Example
{
    public partial class MainForm : ProtectedForms
    {
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
```

VB:
```vb
Imports EZLib

Namespace EZLib.Example
    Public Partial Class MainForm
        Inherits ProtectedForms

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
End Namespace
```
