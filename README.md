# SharpAreaPicker
A (WinForms) .NET plugin library to add snipping dialog to your project

## How to use It
1. Download the latest version of SharpAreaPicker dll;
2. Create a new Windows Forms project on your Visual Studio (Community 2017 is the version I use). It has to be pointing to version 4.5.2 or higher of .Net Framework;
3. Go to solution explorer, right click references and choose add reference. Then under the Assemblies tab, click on the search button and add a reference to the SharpAreaPicker.dll You just downloaded;
4. Now, You can use get a snip of the screen like:
 ```csharp
Image img = AreaPicker.screenshot(this);
if (img != null)
{
    /*
      img is your screenshot, use It
    */
}
 ```
 Note: By passing the caller form to the screenshot function, It will be automatically minimized when the snipping dialog comes up.
 
 
## How the user is supposed to use It
The dialog lacks on instructions, but It's really simple to understand. The AreaPicker dialog is a resizable Form, without a ControlBox (3 common buttons of the top right), that can be dragged with the mouse. It has a context menu that You can bring up by right clicking the dialog, with two items: Capture, which will close the dialog and return the screenshot, and cancel, which will close the form and return null.

"Capture" can be fired by return/enter Keypress as well as cancel will be invoked by pressing the ESC key.

