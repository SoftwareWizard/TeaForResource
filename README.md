# TeaForResource
T4 Template Generation for C# Resource Files

## The Problem

Microsoft provides Resource Files (*.resx) for holding language dependent strings.
Visual Studio automatically generates a resource class file for usage.

With these generated files you can easily access the language dependent strings.

But if you have to share your language dependent strings over network boundaries
you mostly need to transfer individual Resource Keys as a *Magic string*.

This is error prone and annoying in case of type errors.

In order to ship arround this problem you can create a static class,
thats holds your resource Keys and provides you with *intellisense*

But it is a lot of work for creating and maintaining this class.

With **TeaForResource** you can automatically generate this static class
and other useful files for your purpose.

## Advantages of T4 Templates
- T4 Templates are fully integrated in Visual Studio.
- Easy installation, as you just need to copy some files into your project.
- It does not pollute your own project.
- You can modify or extend the templates for your own purposes.
- Available VS Plugins for T4 Template development (e.g. *T4 Editor from Devart*, Resharper Plugin *TeaFor*)

## Content

**TeaForResource** consists of two parts:

- The core file (*\Resources\TeaForResource.Core.ttinclude*) with plain C# code to read your Resource Files 
- The T4 template files (*\Resources\ResourceKeys.tt*, ...) that generates the output.

## Installation

### Install Sample Project 
1. Clone the project
2. Open the Visual Studio Solution file (*TeaForResource.sln*)
3. Run T4 Template generation (e.g. from VS menu: Build->Transform All T4 Templates)
4. Check the generated files for the Sample Resources (*\Resources\ResourceKeys.generated.cs*, *\Typescript\text.resources.generated.ts*)

### Use it in your own Project

1. Copy the core file and T4 template files to your project wherever you need it.
2. Optionally rename the T4 template files for your needs.
3. Set the reference path to the core file in your T4 template. (see configuration section)
3. Adapt configuration parameters in T4 template files. (see configuration section)
4. Optionally add *.generated.cs, *.generated.ts to your gitignore file

## Configuration

### Reference to .ttinclude file

The first line in the T4 Template references the core file.
`<#@ include file="TeaForResource.Core.ttinclude" #>`

Adapt the path correctly, for example 
`<#@ include file="$(SolutionDir)\MyProject\Resources\TeaForResource.Core.ttinclude" #>`

### Parameter

Each T4 Template file has a configuration section with parameters.

#### ResourceKeys.t4

+ ResourcePath -> Path to your resource files (*.resx)
+ StaticResourceNamespaceName -> Namespace of your static resource class

#### text.resources.t4

+ ResourcePath  -> Path to your resource files (*.resx)
+ TextResourceModuleName -> Module name of your generated typescript file
+ TextResourceClassName -> Class name of your generated resource class

