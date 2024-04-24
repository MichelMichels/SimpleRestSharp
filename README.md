> [!WARNING]
> This repository is archived and deprecated. Please use [`RestSharp`](https://restsharp.dev/) directly or [`HttpClient`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-8.0).

---

[![Nuget](https://img.shields.io/nuget/v/SimpleRestSharp)](https://www.nuget.org/packages/SimpleRestSharp/)

# SimpleRestSharp

C# .NET Standard library wrapper for RestSharp.

## Getting Started

Clone the repository and open in Visual Studio. Build the code and reference the .dll file.

Use the `SimpleRestClient` abstract class as a starting point for building your C# rest api wrapper.

## Usage

SimpleRestClient contains 4 protected virtual methods:
* `GetRequest`, which returns an `IRestRequest`
* `GetResponse`, which returns an `IRestResponse`
* `GetResponse<T>`, which returns an `IRestResponse<T>`
* `ValidateResponse`, which throws an `InvalidResponseException` if the response status code of the response is not 200

All methods are overridable so behaviour can be changed.

### Dependencies

* .NET Standard 2.0
* [RestSharp](https://github.com/restsharp/RestSharp)

## License

This project is licensed under the Apache-2.0 License - see the [LICENSE](LICENSE) file for details
