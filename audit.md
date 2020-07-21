# audit

## command line

  - create a file -> `touch`
  - create a directory -> `mkdir`
  - display the content of a directory -> `ls`, flags = `-a` (show everything), `-l` (with description)
  - change the directory -> 'cd'
  - remove file or directory -> `rm`, flags = `-r` (recursive), `-f` (force)
  - running privileged commands or as adminastrator -> `sudo`
  - install new packages -> `apt install`
  - read file content -> `cat`
  - edit file content -> `nano`
  - print current path -> `pwd`

## version control system

  - `git add` -> copy resources into virtual directory or local server
  - `git commit` -> save resources to virtual directory or local server
  - `git status` -> display changed resources in history
  - `git init` -> initialize virtual directory or local server
  - `git config` -> configure name, email or git options
  - `git remote` -> edit or remove connection to remote server
  - `git clone` -> copy resources from remote server to local server
  - `git push` -> copy resources from local server to remote server
  - `git log` -> print history of virtual directory or local server

## secure shell (ssh)

  - `ssh-keygen` -> generate a private/public key pair, similar to username and password, flags = `-t` (algorithm type), `-b` (binary length), `-C` (comment)
  - `ssh-agent` -> run current directory in privileged state with ssh
  - `ssh-add` -> add private key to priviliged state with ssh

## dotnet [.NET]

  - .NET Standard = supports both the .NET Framework (Windows only) and .NET Core (multi platform), a set of APIs to interface with your OS
  - .NET Core = supports languages, Desktop Apps, Mobile Apps, Web Apps
  - Languages = support for C#, F#, VB.NET, C, C++, Python, JavaScript
  - Desktop = support for UWP/UAP (Win10), XAML (Win10), WPF (Win7,8)
  - Mobile = support for Xamarin (Windows, Linux, iOS/ipadOS)
  - Web = support for MVC, Web API (REST), gRPC
  - `dotnet new`
  - `dotnet sln`
  - `dotnet build`
  - `dotnet run`
  - `dotnet test`
  - `dotnet add`

## csharp [C#]

  - CIL, MSIL, IL = code will compile to intermediate language, support CLI (Common Language Infrastructure/Interface)
  - Assembly = compiled codebase into DLL, EXE, or SVC (Web, Host)
  - Language = object-based, strongly-typed, compiled, managed, general programming
  - Datatypes = primitives, reference, value
  - Primative = int, long, float, double, decimal, char, string, bool (including unsigned)
  - Reference = string, class, interface
  - Value = all primitives except string, struct, enum
  - CLR = .NET Runtime from assembly to bytecode/machine code, supports BCL (base class lib), CTS (common type system), VES (virtual execution system), JIT (just in time compiler)
  - Runtime = portability, interoperablity, memory management, performance
  - Scopes = support for 4 levels of scoping, namely namespace, data structure, method/function (class, interface, struct, enum), ?method?, block (control flow, exception handling)
  - Collections = support for array (1-dimensional, multi-dimensional), list
  - Exception Handling = handle with try/catch/throw/finally, try with no catch (not recommended), catch (handle at error or throw to caller), finally (handle resources cleanup)
  - Unit Testing = running codebase logic without application start, structurally setup with arrange/act/assert blocks, test coverage
  - Serialization = convert data from one system to another, ie transfer object to xml text format
  - Debugging = support for running codebase in steps including breakpoints, conditions, handle logic error
  - Modifiers = 2 types, access (public > protected > internal > private) and regular/extended (`const`, `readonly`, `static`, `override`)
  - Method Overloading = support for methods in the same data structure, with same name but different signature
  - Method Overriding = support for methods in different data structure, with same name and same signature through inheritance
  - Object Oriented Programming = Abstraction, Encapsulation, Inheritance, Polymorphism
  - Casting = implicit (smaller to larger, no loss of definition) and explicit (exception casting `(datatype) object` or null casting `object as datatype`)
  - Reference = `ref` (pass by value with value being the reference/pointer to memory address) and `out` (pass by value with value being the copy of the variable in memory)

    --  
    
    int x; 
    int.TryParse (variable, out x);
    bool tryparse (string value, out int z)
    {
      try
      {
        z = int.Parse(value);
        return true;
      }
      catch
      {
        z = 0;
        return false;
      }
    }

    --

  - Parsing = support for converting between primitive datatypes, `Parse`/`TryParse` or consider using `Convert`
  
