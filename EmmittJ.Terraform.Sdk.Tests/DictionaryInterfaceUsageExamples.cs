namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Demonstrates the benefits of TerraformObjectExpression implementing standard dictionary interfaces.
/// </summary>
public class DictionaryInterfaceUsageExamples
{
    [Fact]
    public void Example_PassTerraformObjectToMethodAcceptingIDictionary()
    {
        // Arrange - Create a TerraformObjectExpression with backend configuration
        var backend = new TerraformObjectExpression
        {
            ["bucket"] = "my-bucket",
            ["key"] = "terraform.tfstate",
            ["region"] = "us-west-2"
        };

        // Act - Pass to a method that accepts any IDictionary
        var summary = CreateConfigSummary(backend);

        // Assert
        Assert.Contains("3 configuration items", summary);
        Assert.Contains("bucket", summary);
    }

    [Fact]
    public void Example_UseLINQWithTerraformObject()
    {
        // Arrange
        var tags = new TerraformObjectExpression
        {
            ["Name"] = "my-resource",
            ["Environment"] = "production",
            ["Owner"] = "platform-team",
            ["CostCenter"] = "engineering"
        };

        // Act - Use LINQ to filter and transform
        var tagNames = tags.Keys.OrderBy(k => k).ToList();
        var hasEnvironment = tags.Any(kvp => kvp.Key == "Environment");
        var productionTag = tags.FirstOrDefault(kvp => kvp.Key == "Environment");

        // Assert
        Assert.Equal(4, tagNames.Count);
        Assert.Equal("CostCenter", tagNames[0]); // Alphabetically first
        Assert.True(hasEnvironment);
        Assert.NotNull(productionTag.Value);
    }

    [Fact]
    public void Example_UseAsReadOnlyDictionary()
    {
        // Arrange - Create a config that should be read-only
        var config = new TerraformObjectExpression
        {
            ["version"] = "1.0.0",
            ["readonly"] = true
        };

        // Act - Pass as read-only to prevent accidental modification
        var version = GetConfigVersion(config);

        // Assert
        Assert.Equal("1.0.0", ExtractLiteralValue(version));
    }

    [Fact]
    public void Example_InteroperabilityWithGenericMethods()
    {
        // Arrange
        var settings = new TerraformObjectExpression
        {
            ["timeout"] = 30,
            ["retries"] = 3,
            ["enabled"] = true
        };

        // Act - Can use with any generic method that accepts IDictionary<string, TValue>
        var hasTimeout = ContainsKey(settings, "timeout");
        var count = GetCount(settings);

        // Assert
        Assert.True(hasTimeout);
        Assert.Equal(3, count);
    }

    [Fact]
    public void Example_CollectionInitializerWithDictionaryInterface()
    {
        // Arrange & Act - Collection initializer works because of IEnumerable + Add()
        IDictionary<string, TerraformExpression> dict = new TerraformObjectExpression
        {
            { "key1", "value1" },
            { "key2", "value2" }
        };

        // Assert
        Assert.Equal(2, dict.Count);
        Assert.True(dict.ContainsKey("key1"));
    }

    // Helper methods that demonstrate interoperability

    /// <summary>
    /// Generic method that works with any IDictionary - TerraformObjectExpression now works here!
    /// </summary>
    private static string CreateConfigSummary(IDictionary<string, TerraformExpression> config)
    {
        var keys = string.Join(", ", config.Keys);
        return $"{config.Count} configuration items: {keys}";
    }

    /// <summary>
    /// Method that accepts read-only dictionary - prevents accidental modification.
    /// </summary>
    private static TerraformExpression? GetConfigVersion(IReadOnlyDictionary<string, TerraformExpression> config)
    {
        config.TryGetValue("version", out var version);
        return version;
    }

    /// <summary>
    /// Generic method that works with any dictionary type.
    /// </summary>
    private static bool ContainsKey<TKey, TValue>(IDictionary<TKey, TValue> dict, TKey key)
        => dict.ContainsKey(key);

    /// <summary>
    /// Generic method that works with any collection.
    /// </summary>
    private static int GetCount<T>(ICollection<T> collection)
        => collection.Count;

    /// <summary>
    /// Helper to extract literal string value from expression (for demo purposes).
    /// </summary>
    private static string ExtractLiteralValue(TerraformExpression? expr)
    {
        // In real code, you'd use the proper expression API
        // This is just for demonstration
        return expr?.ToHcl().Trim('"') ?? "";
    }
}
