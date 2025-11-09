using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for TerraformValueResolver - the centralized value preparation and resolution helper.
/// </summary>
public class TerraformValueResolverTests
{
    private readonly MockTerraformContext _context = new();

    [Fact]
    public void PrepareValue_WithNull_DoesNothing()
    {
        // Act
        TerraformValueResolver.PrepareValue(null, _context);

        // Assert - no exception thrown
        Assert.True(true);
    }

    [Fact]
    public void PrepareValue_WithTerraformProperty_CallsPrepare()
    {
        // Arrange
        var property = new TerraformLiteralProperty<string>("test");

        // Act - should not throw
        TerraformValueResolver.PrepareValue(property, _context);

        // Assert - verify it can be resolved after preparation
        var result = TerraformValueResolver.ResolveValue(property, _context);
        Assert.NotNull(result);
        Assert.Equal("\"test\"", result.ToHcl());
    }

    [Fact]
    public Task PrepareValue_WithList_PreparesAllItems()
    {
        // Arrange
        var list = new List<TerraformProperty<string>>
        {
            new TerraformLiteralProperty<string>("item1"),
            new TerraformLiteralProperty<string>("item2"),
            new TerraformLiteralProperty<string>("item3")
        };

        // Act - should not throw
        TerraformValueResolver.PrepareValue(list, _context);

        // Assert - verify all items can be resolved after preparation
        var result = TerraformValueResolver.ResolveValue(list, _context);
        return Verify(result.ToHcl());
    }

    [Fact]
    public Task PrepareValue_WithHashSet_PreparesAllItems()
    {
        // Arrange
        var set = new HashSet<TerraformProperty<string>>
        {
            new TerraformLiteralProperty<string>("a"),
            new TerraformLiteralProperty<string>("b")
        };

        // Act - should not throw
        TerraformValueResolver.PrepareValue(set, _context);

        // Assert - verify all items can be resolved after preparation
        var result = TerraformValueResolver.ResolveValue(set, _context);
        return Verify(result.ToHcl());
    }

    [Fact]
    public Task PrepareValue_WithDictionary_PreparesAllValues()
    {
        // Arrange
        var dict = new Dictionary<string, TerraformProperty<int>>
        {
            ["one"] = new TerraformLiteralProperty<int>(1),
            ["two"] = new TerraformLiteralProperty<int>(2)
        };

        // Act - should not throw
        TerraformValueResolver.PrepareValue(dict, _context);

        // Assert - verify all values can be resolved after preparation
        var result = TerraformValueResolver.ResolveValue(dict, _context);
        return Verify(result.ToHcl());
    }

    [Fact]
    public Task PrepareValue_WithTerraformBlock_CallsPrepare()
    {
        // Arrange
        var block = new TestBlock()
            .WithProperty("name", new TerraformLiteralProperty<string>("block-name"));

        // Act - should not throw
        TerraformValueResolver.PrepareValue(block, _context);

        // Assert - verify block and its properties can be resolved after preparation
        var result = TerraformValueResolver.ResolveValue(block, _context);
        return Verify(result.ToHcl());
    }

    [Fact]
    public void ResolveValue_WithNull_ReturnsNullExpression()
    {
        // Act
        var result = TerraformValueResolver.ResolveValue(null, _context);

        // Assert - verify it renders as "null"
        Assert.Equal("null", result.ToHcl());
    }

    [Fact]
    public void ResolveValue_WithTerraformProperty_ResolvesToExpression()
    {
        // Arrange
        var property = new TerraformLiteralProperty<string>("hello");

        // Act
        var result = TerraformValueResolver.ResolveValue(property, _context);

        // Assert - verify it renders as a string literal
        Assert.Equal("\"hello\"", result.ToHcl());
    }

    [Fact]
    public Task ResolveValue_WithList_ResolvesToListExpression()
    {
        // Arrange
        var list = new List<TerraformProperty<int>>
        {
            new TerraformLiteralProperty<int>(1),
            new TerraformLiteralProperty<int>(2),
            new TerraformLiteralProperty<int>(3)
        };

        // Act
        var result = TerraformValueResolver.ResolveValue(list, _context);

        // Assert
        return Verify(result.ToHcl());
    }

    [Fact]
    public Task ResolveValue_WithHashSet_ResolvesToListExpression()
    {
        // Arrange
        var set = new HashSet<TerraformProperty<string>>
        {
            new TerraformLiteralProperty<string>("a"),
            new TerraformLiteralProperty<string>("b")
        };

        // Act
        var result = TerraformValueResolver.ResolveValue(set, _context);

        // Assert
        return Verify(result.ToHcl());
    }

    [Fact]
    public Task ResolveValue_WithDictionary_ResolvesToMapExpression()
    {
        // Arrange
        var dict = new Dictionary<string, TerraformProperty<string>>
        {
            ["key1"] = new TerraformLiteralProperty<string>("value1"),
            ["key2"] = new TerraformLiteralProperty<string>("value2")
        };

        // Act
        var result = TerraformValueResolver.ResolveValue(dict, _context);

        // Assert
        return Verify(result.ToHcl());
    }

    [Fact]
    public Task ResolveValue_WithTerraformBlock_ResolvesToMapExpression()
    {
        // Arrange
        var block = new TestBlock()
            .WithProperty("name", new TerraformLiteralProperty<string>("test-block"))
            .WithProperty("count", new TerraformLiteralProperty<int>(42));

        // Act
        var result = TerraformValueResolver.ResolveValue(block, _context);

        // Assert
        return Verify(result.ToHcl());
    }

    [Fact]
    public void ResolveValue_WithLiteral_ResolvesToLiteralExpression()
    {
        // Arrange
        var literal = "plain string";

        // Act
        var result = TerraformValueResolver.ResolveValue(literal, _context);

        // Assert - verify it renders as a quoted string
        Assert.Equal("\"plain string\"", result.ToHcl());
    }

    [Fact]
    public Task PrepareAndResolve_WithNestedStructures_HandlesCorrectly()
    {
        // Arrange - List of blocks with dictionaries
        var blocks = new List<TestBlock>
        {
            new TestBlock()
                .WithProperty("tags", new Dictionary<string, TerraformProperty<string>>
                {
                    ["env"] = new TerraformLiteralProperty<string>("dev"),
                    ["owner"] = new TerraformLiteralProperty<string>("team")
                }),
            new TestBlock()
                .WithProperty("tags", new Dictionary<string, TerraformProperty<string>>
                {
                    ["env"] = new TerraformLiteralProperty<string>("prod")
                })
        };

        // Act
        TerraformValueResolver.PrepareValue(blocks, _context);
        var result = TerraformValueResolver.ResolveValue(blocks, _context);

        // Assert
        return Verify(result.ToHcl());
    }

    /// <summary>
    /// Test block for testing purposes.
    /// </summary>
    private class TestBlock : TerraformBlock
    {
        public new TestBlock WithProperty(string key, object? value, int? priority = null)
        {
            base.WithProperty(key, value, priority);
            return this;
        }
    }

    /// <summary>
    /// Mock context that tracks prepared values.
    /// </summary>
    private class MockTerraformContext : ITerraformContext
    {
        public List<object> PreparedValues { get; } = new();
        public int IndentLevel { get; private set; }
        public string Indent => new string(' ', IndentLevel * 2);
        public TerraformStack Scope => throw new NotImplementedException();
        public DependencyGraph DependencyGraph => throw new NotImplementedException();

        public void RegisterConstruct(TerraformConstruct construct)
        {
        }

        public void OnPrepare(Action<ITerraformContext> action)
        {
            // Track literal values being prepared
            action(this);
        }

        public IDisposable PushIndent()
        {
            IndentLevel++;
            return new IndentScope(() => IndentLevel--);
        }

        public IDisposable SetCurrentConstruct(TerraformConstruct? construct)
        {
            return new IndentScope(() => { });
        }

        public void RecordDependency(TerraformConstruct dependency)
        {
        }

        public TerraformVariable CreateVariable(string name, object? defaultValue = null)
        {
            throw new NotImplementedException();
        }

        public TerraformOutput CreateOutput(string name, TerraformExpression value)
        {
            throw new NotImplementedException();
        }

        private class IndentScope : IDisposable
        {
            private readonly Action _onDispose;

            public IndentScope(Action onDispose)
            {
                _onDispose = onDispose;
            }

            public void Dispose()
            {
                _onDispose();
            }
        }
    }
}
