cmake_minimum_required(VERSION 3.2)

PROJECT(dmsharp LANGUAGES CSharp)

include(CSharpUtilities)

set(CMAKE_CSharp_FLAGS "/langversion:latest")

FILE(GLOB_RECURSE SRC_SOURCES
  src/main.cs
)

csharp_set_designer_cs_properties(
  src/main.cs
)

add_executable(dmsharp ${SRC_SOURCES})

set_property(TARGET dmsharp PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
set_property(TARGET dmsharp PROPERTY WIN32_EXECUTABLE TRUE)
set_property(TARGET dmsharp PROPERTY VS_CSHARP_DependentUpon src/main.cs)

set_property(TARGET dmsharp PROPERTY VS_DOTNET_REFERENCES
	"Microsoft.CSharp"
	"PresentationCore"
	"PresentationFramework"
	"System"
	"System.Core"
    "System.Data"
    "System.Web"
    "System.Web.Services"
	"System.Data.DataSetExtensions"
	"System.Net.Http"
	"System.Xaml"
	"System.Xml"
	"System.Xml.Linq"
	"WindowsBase")

