# Video-streamming-.NET

You can see the demo site at:

https://videostreaming.azurewebsites.net/

This is a simple video streaming web application built using .NET, MVC and Razor View Engine. It showcases a range of videos that users can click on to view. Note that there is a limit of 60 CPU minutes for the server per day, so videos might stop accidentally if the limit is reached.

## Features

- Displays a list of videos with their corresponding images and titles.
- Click on the image or title to navigate to the page that streams the selected video.
- Responsive design, adjusts the layout for smaller screens.
- Supports various actions defined in HomeController such as navigating to different video pages.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Core SDK 3.1 or later
- Any text editor or IDE that supports .NET development (e.g. Visual Studio, Visual Studio Code, etc)

### Installing

1. Clone the repository to your local machine using `git clone <repository-link>`.
2. Navigate to the cloned directory.
3. Run `dotnet restore` to restore the dependencies and tools for the project.
4. Run `dotnet build` to build the project and its dependencies to verify that everything works correctly.

### Running the Application

1. Run `dotnet run` to start the application.
2. Open your web browser and navigate to `https://localhost:5001` or `http://localhost:5000`. (or other address, depends on how you launch it.)

## Project Structure

Here's a brief info about what each file does:

- `style.css` - Contains styles for the image and video containers, as well as responsive design rules for smaller screens.
- `index.cshtml` - The homepage view. It displays a list of videos with their corresponding images and titles.
- `aladdin.cshtml` - An example of a movie view. It displays the video player and some information about the movie. There can be more views like this for each video.
- `HomeController.cs` - Handles routing to various pages of the application.

## Contributing

If you want to contribute to this project, please feel free to fork the repository, make your changes and submit a pull request.

## License

This project is licensed under the MIT License. Please see the [LICENSE.md](LICENSE.md) file for details.
