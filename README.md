# .NET core for AWS lambda
I was trying to follow the instructions on [AWS official size](http://docs.aws.amazon.com/lambda/latest/dg/lambda-dotnet-coreclr-deployment-package.html)
but as a result code was not compiling and working:

1. After `dotnet new console` there was no `project.json` file created.
2. I created this file by myself, but then I got compilation errors:

```
$ dotnet publish
Microsoft (R) Build Engine version 15.1.1012.6693
Copyright (C) Microsoft Corporation. All rights reserved.

Program.cs(8,22): error CS0161: 'LambdaHandler.myHandler(Stream)': not all code paths return a value [/Users/s***d/Development/lambda-cs/lambda-cs.csproj]
CSC : error CS5001: Program does not contain a static 'Main' method suitable for an entry point [/Users/s***d/Development/lambda-cs/lambda-cs.csproj]
```

or

```
$ dotnet publish
Microsoft (R) Build Engine version 15.1.1012.6693
Copyright (C) Microsoft Corporation. All rights reserved.

Assembly.cs(1,11): error CS0246: The type or namespace name 'LambdaSerializerAttribute' could not be found (are you missing a using directive or an assembly reference?) [/Users/s***d/Development/lambda-cs/lambda-cs.csproj]
Assembly.cs(1,11): error CS0246: The type or namespace name 'LambdaSerializer' could not be found (are you missing a using directive or an assembly reference?) [/Users/s***d/Development/lambda-cs/lambda-cs.csproj]
Assembly.cs(1,35): error CS0246: The type or namespace name 'Amazon' could not be found (are you missing a using directive or an assembly reference?) [/Users/s***d/Development/lambda-cs/lambda-cs.csproj]
```

It turned out that it is not that easy (for me as for a newbie) to fix that. The reason was that `project.json` was replaced by `.csproj` files in the newer version of .NET core.

So, this repository contains the minimal project that runs on AWS lambda.

Main differences are:
1. Using `.csproj` instead of `project.json`.
2. Newer version of `AWS.Lambda` libraries.
3. Makefile to make the life easier.

Happy coding, brothers and sisters!
