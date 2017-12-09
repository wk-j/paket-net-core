## Paket + .NET Core

## Setup

```bash
paket init
forge new project --name Hello --dir src --no-fake
paket add FSharp.Data --project src/Hello/Hello.fsproj
```

## Test

```bash
dotnet restore src/Hello/Hello.fsproj
dotnet run --project src/Hello/Hello.fsproj
```

## Fixed Type Provider Issue on mac OS

```xml
  <PropertyGroup>
    <FscToolPath>/Library/Frameworks/Mono.framework/Versions/Current/Commands</FscToolPath>
    <FscToolExe>fsharpc</FscToolExe>
  </PropertyGroup>
```
