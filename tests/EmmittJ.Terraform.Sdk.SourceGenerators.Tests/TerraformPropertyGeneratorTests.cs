using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Immutable;
using Xunit;

namespace EmmittJ.Terraform.Sdk.SourceGenerators.Tests;

public class TerraformPropertyGeneratorTests
{
    [Fact]
    public Task GeneratesPropertyImplementationForPartialProperty()
    {
        // Arrange
        var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestResource : TerraformResource
{
    public TestResource(string name) : base(""test_resource"", name) { }

    [TerraformArgument(""test_property"")]
    public partial TerraformValue<string> TestProperty { get; set; }
}
";

        // Act
        var (diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
    public Task GeneratesReadOnlyPropertyForPartialGetterOnly()
    {
        // Arrange
        var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestDataSource : TerraformDataSource
{
    public TestDataSource(string name) : base(""test_data"", name) { }

    [TerraformArgument(""computed_property"")]
    public partial TerraformValue<string> ComputedProperty { get; }
}
";

        // Act
        var (diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
    public Task DoesNotGenerateForNonPartialProperties()
    {
        // Arrange
        var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestResource : TerraformResource
{
    public TestResource(string name) : base(""test_resource"", name) { }

    [TerraformArgument(""auto_property"")]
    public TerraformValue<string> AutoProperty { get; set; }
}
";

        // Act
        var (diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
    public Task GeneratesRequiredGetterForRequiredProperty()
    {
        // Arrange
        var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestProvider : TerraformProvider
{
    public TestProvider() : base(""test"") { }

    [TerraformArgument(""required_config"")]
    public required partial TerraformValue<string> RequiredConfig { get; set; }
}
";

        // Act
        var (diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
    public Task GeneratesRequiredGetterForNonNullableProperty()
    {
        // Arrange
        var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestProvider : TerraformProvider
{
    public TestProvider() : base(""test"") { }

    [TerraformArgument(""non_nullable_config"")]
    public partial TerraformValue<string> NonNullableConfig { get; set; }
}
";

        // Act
        var (diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
    public Task GeneratesOptionalGetterForNullableProperty()
    {
        // Arrange
        var source = @"
#nullable enable
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestProvider : TerraformProvider
{
    public TestProvider() : base(""test"") { }

    [TerraformArgument(""nullable_config"")]
    public partial TerraformValue<string>? NullableConfig { get; set; }
}
";

        // Act
        var (diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
    public Task GeneratesReferenceGetterForBlockReadOnlyProperty()
    {
        // Arrange
        // Block classes should return references for read-only (output) properties
        // Example: AzurermRedisCache.PrimaryConnectionString should return a reference to azurerm_redis_cache.<name>.primary_connection_string
        var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class TestBlock : TerraformBlock
{
    public override string BlockType => \"test\";

    [TerraformArgument(\"\"primary_connection_string\"\")]
    public partial TerraformValue<string> PrimaryConnectionString { get; }
}
";

        // Act
        var(diagnostics, output) = GetGeneratedOutput(source);

        // Assert
        return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
    }

    [Fact]
public Task GeneratesReferenceGetterForResourceReadOnlyProperty()
{
    // Arrange
    // Resources should return references for read-only (output) properties
    var source = @"
using EmmittJ.Terraform.Sdk;

namespace TestNamespace;

public partial class AzurermRedisCache : TerraformResource
{
    public AzurermRedisCache(string name) : base(""azurerm_redis_cache"", name) { }

    [TerraformArgument(""primary_connection_string"")]
    public partial TerraformValue<string> PrimaryConnectionString { get; }
}
";

    // Act
    var (diagnostics, output) = GetGeneratedOutput(source);

    // Assert
    return Verify(new { diagnostics = diagnostics.Select(d => d.ToString()), output });
}

private static (ImmutableArray<Diagnostic> Diagnostics, string Output) GetGeneratedOutput(string source)
{
    var syntaxTree = CSharpSyntaxTree.ParseText(source);

    var references = AppDomain.CurrentDomain.GetAssemblies()
        .Where(assembly => !assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
        .Select(assembly => MetadataReference.CreateFromFile(assembly.Location))
        .ToList();

    // Add reference to our SDK assembly
    var sdkAssembly = typeof(TerraformResource).Assembly;
    references.Add(MetadataReference.CreateFromFile(sdkAssembly.Location));

    var compilation = CSharpCompilation.Create(
        "TestAssembly",
        new[] { syntaxTree },
        references,
        new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

    var generator = new TerraformPropertyGenerator();
    var driver = CSharpGeneratorDriver.Create(generator);

    driver = (CSharpGeneratorDriver)driver.RunGeneratorsAndUpdateCompilation(
        compilation,
        out var outputCompilation,
        out var diagnostics);

    var runResult = driver.GetRunResult();

    var output = runResult.GeneratedTrees.Length > 0
        ? runResult.GeneratedTrees[0].ToString()
        : string.Empty;

    return (diagnostics, output);
}
}
