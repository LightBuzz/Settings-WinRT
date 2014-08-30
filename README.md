# Settings utility for WinRT apps

An easy-to-use mchanism for managing the settings within a Windows Phone or Windows 8 app.

## Installation
You can download and build this project or simply install it via NuGet:
	
	PM> Install-Package lightbuzz-settings

## Examples
Import the assembly to your project and include its namespace:
	
	using LightBuzz.Settings;

### Add / Update a setting
	
	string name = "Vangos Pterneas";
	Settings.Set<string>("name", name);

### Retrieve a setting

	string name = Settings.Get<string>("name");

### Delete a setting

	Settings.Remove("name");

## Contributors
* [Vangos Pterneas](http://pterneas.com) from [LightBuzz](http://lightbuzz.com)

## License
You are free to use these libraries in personal and commercial projects by attributing the original creator of the project. [View full License](https://github.com/LightBuzz/Settings-WinRT/blob/master/LICENSE).
