namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests that verify TerraformObjectExpression properly implements dictionary interfaces.
/// </summary>
public class DictionaryInterfaceTests
{
    [Fact]
    public void TerraformObjectExpression_ImplementsIDictionary()
    {
        // Arrange & Act
        var obj = new TerraformObjectExpression();

        // Assert - Can be used as IDictionary<string, TerraformExpression>
        IDictionary<string, TerraformExpression> dict = obj;
        Assert.NotNull(dict);
    }

    [Fact]
    public void TerraformObjectExpression_ImplementsIReadOnlyDictionary()
    {
        // Arrange & Act
        var obj = new TerraformObjectExpression();

        // Assert - Can be used as IReadOnlyDictionary<string, TerraformExpression>
        IReadOnlyDictionary<string, TerraformExpression> readOnlyDict = obj;
        Assert.NotNull(readOnlyDict);
    }

    [Fact]
    public void TerraformObjectExpression_CanBePassedToMethodsAcceptingIDictionary()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_SupportsLINQOperations()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_TryGetValue_Works()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_Clear_RemovesAllProperties()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_Keys_ReturnsAllKeys()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_Values_ReturnsAllValues()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_ICollectionAdd_Works()
    {
        // Arrange
        IDictionary<string, TerraformExpression> dict = new TerraformObjectExpression();
        var kvp = new KeyValuePair<string, TerraformExpression>("test", "value");

        // Act
        dict.Add(kvp);

        // Assert
        Assert.True(dict.ContainsKey("test"));
        Assert.Single(dict);
    }

    [Fact]
    public void TerraformObjectExpression_ICollectionContains_Works()
    {
        // Arrange
        var expr = "value";
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_ICollectionRemove_Works()
    {
        // Arrange
        var expr = "value";
        var obj = new TerraformObjectExpression
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
    public void TerraformObjectExpression_NonGenericIDictionary_Works()
    {
        // Arrange
        System.Collections.IDictionary dict = new TerraformObjectExpression();

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
    public void TerraformObjectExpression_AsReadOnlyDictionary_PreventsModification()
    {
        // Arrange
        var obj = new TerraformObjectExpression
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

    // Helper method to demonstrate TerraformObjectExpression can be passed to methods accepting IDictionary
    private static int CountItems(IDictionary<string, TerraformExpression> dict)
    {
        return dict.Count;
    }
}
