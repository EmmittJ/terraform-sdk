using System.Text.Json;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Maps Terraform schema types to C# types.
/// </summary>
public class TypeMapper : ITypeMapper
{
    /// <summary>
    /// Maps a Terraform type to a wrapped C# type (e.g., TerraformValue&lt;string&gt;).
    /// </summary>
    public string MapToWrappedCSharpType(object? type)
    {
        if (type is null)
        {
            return "TerraformValue<string>";
        }

        var typeStr = type.ToString() ?? "string";

        // Handle JSON element from deserialization
        if (type is JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.String)
            {
                typeStr = element.GetString() ?? "string";
            }
            else if (element.ValueKind == JsonValueKind.Array)
            {
                // Handle complex types like ["list", "string"]
                // TerraformList/Map/Set already wrap their elements in TerraformValue<T>
                // So we should map ["list", "string"] to TerraformList<string>, not TerraformList<TerraformValue<string>>
                var arr = element.EnumerateArray().ToList();
                if (arr.Count >= 2)
                {
                    var collectionType = arr[0].GetString();
                    var innerType = MapToRawCSharpType(arr[1]); // Use raw type for collection elements

                    return collectionType switch
                    {
                        "list" => $"TerraformList<{innerType}>",
                        "set" => $"TerraformSet<{innerType}>",
                        "map" => $"TerraformMap<{innerType}>",
                        _ => "TerraformValue<object>"
                    };
                }
            }
            else if (element.ValueKind == JsonValueKind.Object)
            {
                // Complex object type - use Dictionary for now
                return "TerraformMap<object>";
            }
        }

        return typeStr switch
        {
            "string" => "TerraformValue<string>",
            "number" => "TerraformValue<double>",
            "bool" => "TerraformValue<bool>",
            "dynamic" => "TerraformValue<object>",
            _ => "TerraformValue<string>"
        };
    }

    /// <summary>
    /// Maps a raw Terraform type (e.g., "string", "number") to the unwrapped C# type (e.g., "string", "double").
    /// Used for collection element types where the collection handles the wrapping.
    /// </summary>
    public string MapToRawCSharpType(object? type)
    {
        if (type is null)
        {
            return "string";
        }

        var typeStr = type.ToString() ?? "string";

        // Handle JSON element from deserialization
        if (type is JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.String)
            {
                typeStr = element.GetString() ?? "string";
            }
            else if (element.ValueKind == JsonValueKind.Array)
            {
                // Handle nested collections like ["list", ["list", "string"]]
                var arr = element.EnumerateArray().ToList();
                if (arr.Count >= 2)
                {
                    var collectionType = arr[0].GetString();
                    var innerType = MapToRawCSharpType(arr[1]);

                    return collectionType switch
                    {
                        "list" => $"TerraformList<{innerType}>",
                        "set" => $"TerraformSet<{innerType}>",
                        "map" => $"TerraformMap<{innerType}>",
                        _ => "object"
                    };
                }
            }
            else if (element.ValueKind == JsonValueKind.Object)
            {
                // Complex object type
                return "TerraformMap<object>";
            }
        }

        return typeStr switch
        {
            "string" => "string",
            "number" => "double",
            "bool" => "bool",
            "dynamic" => "object",
            _ => "string"
        };
    }

    /// <summary>
    /// Determines whether a C# type is a collection type.
    /// </summary>
    public bool IsCollectionType(string csharpType)
    {
        return csharpType.Contains("List<") ||
               csharpType.Contains("Dictionary<") ||
               csharpType.Contains("HashSet<") ||
               csharpType.Contains("TerraformList<") ||
               csharpType.Contains("TerraformMap<") ||
               csharpType.Contains("TerraformSet<");
    }

    /// <summary>
    /// Determines whether a C# type is a value type.
    /// </summary>
    public bool IsValueType(string csharpType)
    {
        // Extract the inner type from TerraformValue<T> if present
        if (csharpType.StartsWith("TerraformValue<"))
        {
            var innerType = csharpType.Substring("TerraformValue<".Length, csharpType.Length - "TerraformValue<".Length - 1);
            return innerType == "bool" || innerType == "double" || innerType == "int" || innerType == "long" || innerType == "float";
        }

        return csharpType == "bool" || csharpType == "double" || csharpType == "int" || csharpType == "long" || csharpType == "float";
    }
}
