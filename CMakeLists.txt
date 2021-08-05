cmake_minimum_required(VERSION 3.2)

PROJECT(dmsharp LANGUAGES CSharp)

LIST(APPEND CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake)
INCLUDE(cmake/ModuleImport.cmake)
INCLUDE(cmake/ModuleCompileOptions.cmake)
ModuleSetCompileOptions()

include(CSharpUtilities)

set(CMAKE_CSharp_FLAGS "/langversion:latest")

FILE(GLOB_RECURSE SRC_SOURCES
  src/*.cs
)

csharp_set_designer_cs_properties(
  ${SRC_SOURCES}
)

add_executable(dmsharp ${SRC_SOURCES})

set_property(TARGET dmsharp PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")
set_property(TARGET dmsharp PROPERTY WIN32_EXECUTABLE TRUE)
set_property(TARGET dmsharp PROPERTY VS_CSHARP_DependentUpon ${SRC_SOURCES})

set_property(TARGET dmsharp PROPERTY VS_DOTNET_REFERENCES
	"Google.Protobuf"
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

