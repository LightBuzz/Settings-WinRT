# Settings utility for WinRT apps

An easy-to-use mchanism for managing the settings within a Windows Phone or Windows 8 app. Supports local and roaming settings.

## Installation
You can download and build this project or simply install it via NuGet:
	
	PM> Install-Package lightbuzz-settings

## Examples
Import the assembly to your project and include its namespace:
	
	using LightBuzz.Settings;

There is one primary class, named Settings, that contains two static properties, Local and Roaming. You can specify whether you want to save a setting locally or under the user's Microsoft account.

### Add / Update a setting
	
	string name = "Vangos Pterneas";
	Settings.Local.Set<string>("name", name);	// Save in the local settings
	Settings.Roaming.Set<string>("name", name);	// Save in the roaming settings

### Retrieve a setting

	string name = Settings.Local.Get<string>("name");	// Retrieve from the local settings
	string name = Settings.Local.Get<string>("name");	// Retrieve from the roaming settings

### Delete a setting

	Settings.Local.Remove("name");		// Delete from the local settings
	Settings.Roaming.Remove("name");	// Delete from the roaming settings

Please read [Microsoft's guidelines](http://msdn.microsoft.com/en-us/library/windows/apps/hh465094.aspx) about using roaming data.

## Contributors
* [Vangos Pterneas](http://pterneas.com) from [LightBuzz](http://lightbuzz.com)

## License
You are free to use these libraries in personal and commercial projects by attributing the original creator of the project. [View full License](https://github.com/LightBuzz/Settings-WinRT/blob/master/LICENSE).
