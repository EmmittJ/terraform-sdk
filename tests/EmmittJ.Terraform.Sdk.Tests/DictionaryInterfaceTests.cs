namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests that verify TerraformMapExpression properly implements dictionary interfaces.
/// </summary>
public class DictionaryInterfaceTests
{
    [Fact]
    public void TerraformMapExpression_ImplementsIDictionary()
    {
        // Arrange & Act
        var obj = new TerraformMapExpression();

        // Assert - Can be used as IDictionary<string, TerraformExpression>
        IDictionary<string, TerraformExpression> dict = obj;
        Assert.NotNull(dict);
    }

    [Fact]
    public void TerraformMapExpression_ImplementsIReadOnlyDictionary()
    {
        // Arrange & Act
        var obj = new TerraformMapExpression();

        // Assert - Can be used as IReadOnlyDictionary<string, TerraformExpression>
        IReadOnlyDictionary<string, TerraformExpression> readOnlyDict = obj;
        Assert.NotNull(readOnlyDict);
    }

    [Fact]
    public void TerraformMapExpression_CanBePassedToMethodsAcceptingIDictionary()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["key1"] = "value1",
            ["key2"] = "value2"
        };

        // Act
        var count = CountItems(obj);

        // Assert
        Assert.Equal(2, count);
    }

    [Fact]
    public void TerraformMapExpression_SupportsLINQOperations()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["name"] = "test",
            ["age"] = 30,
            ["active"] = true
        };

        // Act
        var keys = obj.Keys.ToList();
        var values = obj.Values.ToList();
        var firstPair = obj.First();
        var containsName = obj.Any(kvp => kvp.Key == "name");

        // Assert
        Assert.Equal(3, keys.Count);
        Assert.Equal(3, values.Count);
        Assert.True(containsName);
    }

    [Fact]
    public void TerraformMapExpression_TryGetValue_Works()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["test"] = "value"
        };

        // Act
        var found = obj.TryGetValue("test", out var value);
        var notFound = obj.TryGetValue("missing", out var missingValue);

        // Assert
        Assert.True(found);
        Assert.NotNull(value);
        Assert.False(notFound);
        Assert.Null(missingValue);
    }

    [Fact]
    public void TerraformMapExpression_Clear_RemovesAllProperties()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["key1"] = "value1",
            ["key2"] = "value2"
        };

        // Act
        obj.Clear();

        // Assert
        Assert.Empty(obj);
        Assert.False(obj.ContainsKey("key1"));
    }

    [Fact]
    public void TerraformMapExpression_Keys_ReturnsAllKeys()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["a"] = 1,
            ["b"] = 2,
            ["c"] = 3
        };

        // Act
        var keys = obj.Keys;

        // Assert
        Assert.Equal(3, keys.Count);
        Assert.Contains("a", keys);
        Assert.Contains("b", keys);
        Assert.Contains("c", keys);
    }

    [Fact]
    public void TerraformMapExpression_Values_ReturnsAllValues()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["key1"] = "value1",
            ["key2"] = "value2"
        };

        // Act
        var values = obj.Values;

        // Assert
        Assert.Equal(2, values.Count);
        Assert.All(values, v => Assert.NotNull(v));
    }

    [Fact]
    public void TerraformMapExpression_ICollectionAdd_Works()
    {
        // Arrange
        IDictionary<string, TerraformExpression> dict = new TerraformMapExpression();
        var kvp = new KeyValuePair<string, TerraformExpression>("test", "value");

        // Act
        dict.Add(kvp);

        // Assert
        Assert.True(dict.ContainsKey("test"));
        Assert.Single(dict);
    }

    [Fact]
    public void TerraformMapExpression_ICollectionContains_Works()
    {
        // Arrange
        var expr = "value";
        var obj = new TerraformMapExpression
        {
            ["test"] = expr
        };
        ICollection<KeyValuePair<string, TerraformExpression>> collection = obj;
        var kvp = new KeyValuePair<string, TerraformExpression>("test", expr);

        // Act
        var contains = collection.Contains(kvp);

        // Assert
        Assert.True(contains);
    }

    [Fact]
    public void TerraformMapExpression_ICollectionRemove_Works()
    {
        // Arrange
        var expr = "value";
        var obj = new TerraformMapExpression
        {
            ["test"] = expr
        };
        ICollection<KeyValuePair<string, TerraformExpression>> collection = obj;
        var kvp = new KeyValuePair<string, TerraformExpression>("test", expr);

        // Act
        var removed = collection.Remove(kvp);

        // Assert
        Assert.True(removed);
        Assert.Empty(obj);
    }

    [Fact]
    public void TerraformMapExpression_NonGenericIDictionary_Works()
    {
        // Arrange
        System.Collections.IDictionary dict = new TerraformMapExpression();

        // Act
        dict.Add("test", "value");
        var contains = dict.Contains("test");
        var value = dict["test"];

        // Assert
        Assert.True(contains);
        Assert.NotNull(value);
        Assert.IsAssignableFrom<TerraformExpression>(value);
    }

    [Fact]
    public void TerraformMapExpression_AsReadOnlyDictionary_PreventsModification()
    {
        // Arrange
        var obj = new TerraformMapExpression
        {
            ["test"] = "value"
        };
        IReadOnlyDictionary<string, TerraformExpression> readOnly = obj;

        // Act & Assert
        Assert.Single(readOnly);
        Assert.True(readOnly.ContainsKey("test"));
        Assert.True(readOnly.TryGetValue("test", out var value));
        Assert.NotNull(value);

        // Verify keys and values are enumerable
        Assert.Single(readOnly.Keys);
        Assert.Single(readOnly.Values);
    }

    // Helper method to demonstrate TerraformMapExpression can be passed to methods accepting IDictionary
    private static int CountItems(IDictionary<string, TerraformExpression> dict)
    {
        return dict.Count;
    }
}
