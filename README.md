# Keypad

Keypad is a console driven application that gives you ability to replicate various text-input formats of feature phones.

## Installation

1. Clone this repository
2. Ensure DotNet SDK version is `9.0` above (since `.slnx` is used)
3. Navigate to `Application/` project
4. Execute `dotnet run`

## Usage

1. If used with a runtime, simply navigate to `Application` project and execute `dotnet run`
2. Else, the project is also configured to be AOT-able, in which case, under the same project execute `dotnet publish`
3. Follow the invocation instructions post execution

> N.B. Currently only `t9` (rudimentary) and `multitap` methods are supported
