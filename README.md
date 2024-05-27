# Network Programming Boilerplate

This project is a simple client-server application built with WinForms and .NET. It facilitates communication between a client and a server through chat, file requests, and directory information retrieval. Additionally, the server can send images to the client. I've implemented this project during my journey to learn Network Programming.

## Features

- **Chat Functionality**: Allows the client and server to exchange messages.
- **File Request**: Enables the client to request specific files from the server.
- **Directory Information**: The client can request information about a specific directory, and the server responds with details about all files and directories within the specified path.
- **Image Transfer**: The server can select and send an image to the client.

## Installation

### Prerequisites

- .NET Framework (version 4.8 or higher recommended)
- Visual Studio (or any compatible IDE)

### Steps

1. **Clone the repository:**

   ```sh
   git clone git@github.com:mohamedhassan218/network-programming-boilerplate.git
   ```

2. **Open the solution:**

   Open each solution in separated tap.


3. **Run the application:**

   Run the client and the server then press `listen` in the server, and press `connect` in the client side and begin playing with the project.

## Usage

### Chat Functionality

- Open the client and server applications.
- Use the chat interface to send and receive messages between the client and server.

### File Request

- In the client application, enter the **file path** you wish to request from the server.
- The server will locate the file and send it to the client.

### Directory Information

- In the client application, specify the directory path.
- The server will respond with the list of files and directories within the specified path.

### Image Transfer

- On the server application, use the option to select an image file.
- The selected image will be sent to the client application and displayed.


## Project Structure

- **Client**: Contains the client-side application logic.
- **Server**: Contains the server-side application logic.


## Contributing

Contributions are welcome! Please fork the repository and use a feature branch. Pull requests are warmly welcome.

1. Fork the repository.
2. Create your feature branch:
    ```sh
    git checkout -b feature/your-feature
    ```

3. Commit your changes:
    ```sh
    git commit -m 'Add some feature'
    ```

4. Push to the branch:
    ```sh
    git push origin feature/your-feature
    ```
    
5. Create a new Pull Request.