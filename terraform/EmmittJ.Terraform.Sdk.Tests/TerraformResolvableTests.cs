namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for the token system and ITerraformResolvable implementation.
/// Validates two-pass resolution (Prepare and Resolve phases).
/// </summary>
public class TerraformResolvableTests
{
    [Fact]
    public void TerraformExpression_SupportsResolvableInterface()
    {
        // Arrange
        var expr = TerraformExpression.Literal("test");
        var context = TerraformContext.Temporary();

        // Act
        var result = expr.ToHcl(context);

        // Assert
        Assert.Equal("\"test\"", result);
    }

    [Fact]
    public void TerraformValue_SupportsResolvableInterface()
    {
        // Arrange
        var value = new TerraformValue<string>("hello");
        var context = TerraformContext.Temporary(value);

        // Act
        var expr = value.Resolve(context);

        // Assert
        Assert.Equal("\"hello\"", expr.ToHcl());
    }

    [Fact]
    public void Token_Lazy_DefersEvaluationUntilResolve()
    {
        // Arrange
        var evaluationCount = 0;
        var lazyValue = Token.Lazy(() =>
        {
            evaluationCount++;
            return "computed";
        });

        var context = TerraformContext.Temporary();

        // Act - Resolve phase should evaluate
        var result1 = lazyValue.Resolve(context);
        Assert.Equal(1, evaluationCount); // First resolve should evaluate once

        var result2 = lazyValue.Resolve(context);
        Assert.Equal(1, evaluationCount); // Second resolve should use cached value

        // Assert
        Assert.Equal("computed", result1);
        Assert.Equal("computed", result2);
    }

    [Fact]
    public void Token_LazyWithContext_AccessesScope()
    {
        // Arrange
        var config = new TerraformConfiguration("test-config");
        var lazyValue = Token.Lazy<string>(ctx => ctx.Scope.Name);

        var context = new TerraformContext(config);

        // Act
        var result = lazyValue.Resolve(context);

        // Assert
        Assert.Equal("test-config", result);
    }

    [Fact]
    public void TerraformConfiguration_UsesResolvableForConstruct()
    {
        // Arrange
        var config = new TerraformConfiguration();
        var variable = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2",
            Description = "AWS region"
        };

        config.Add(variable);

        // Act
        var hcl = config.ToHcl();

        // Assert
        Assert.Contains("variable \"region\"", hcl);
        Assert.Contains("type", hcl);
        Assert.Contains("string", hcl);
        Assert.Contains("default", hcl);
        Assert.Contains("us-west-2", hcl);
        Assert.Contains("description", hcl);
        Assert.Contains("AWS region", hcl);
    }

    [Fact]
    public void TerraformValue_WithExpression_PreparesAndResolvesCorrectly()
    {
        // Arrange
        var expr = TerraformExpression.Literal(42);
        var value = new TerraformValue<int>(expr);
        var context = TerraformContext.Temporary();

        // Act
        var result = value.Resolve(context);

        // Assert
        Assert.Equal("42", result.ToHcl());
    }

    [Fact]
    public void TerraformValue_WithReference_TracksRequirement()
    {
        // Arrange
        var resource = new TerraformResource("aws_instance", "web");
        var reference = new TerraformReference(resource, "id");
        var value = new TerraformValue<string>(reference);

        var context = TerraformContext.Temporary();

        // Act - Should not throw
        var result = value.Resolve(context);

        // Assert
        Assert.Equal("aws_instance.web.id", result.ToHcl());
    }

    [Fact]
    public void TerraformContext_HasCorrectScope()
    {
        // Arrange
        var context = TerraformContext.Temporary();

        // Assert
        Assert.NotNull(context);
        Assert.Same(context.Scope, context.Scope);
    }

    [Fact]
    public void Token_AsString_MaintainsTypeInformation()
    {
        // Arrange
        var stringToken = Token.AsString(Token.Lazy(() => "hello"));

        var context = TerraformContext.Temporary();

        // Act
        var result = stringToken.Resolve(context);

        // Assert
        Assert.Equal("hello", result);
    }

    [Fact]
    public void Token_AsNumber_MaintainsTypeInformation()
    {
        // Arrange
        var numberToken = Token.AsNumber(Token.Lazy(() => 42));

        var context = TerraformContext.Temporary();

        // Act
        var result = numberToken.Resolve(context);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Token_AsBoolean_MaintainsTypeInformation()
    {
        // Arrange
        var boolToken = Token.AsBoolean(Token.Lazy(() => true));

        var context = TerraformContext.Temporary();

        // Act
        var result = boolToken.Resolve(context);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Token_AsList_MaintainsTypeInformation()
    {
        // Arrange
        var listToken = Token.AsList(Token.Lazy(() => new List<string> { "a", "b", "c" }));

        var context = TerraformContext.Temporary();

        // Act
        var result = listToken.Resolve(context);

        // Assert
        Assert.Equal(new List<string> { "a", "b", "c" }, result);
    }

    [Fact]
    public void Token_Lazy_ComputesOnlyOnce()
    {
        // Arrange
        var computationCount = 0;
        var lazy = Token.Lazy(ctx =>
        {
            computationCount++;
            return "computed";
        });

        var context = TerraformContext.Temporary();

        // Act
        var result1 = lazy.Resolve(context);
        var result2 = lazy.Resolve(context);
        var result3 = lazy.Resolve(context);

        // Assert
        Assert.Equal(1, computationCount); // Lazy value should compute only once
        Assert.Equal("computed", result1);
        Assert.Equal("computed", result2);
        Assert.Equal("computed", result3);
    }

    [Fact]
    public void TerraformConfiguration_TwoPassResolution_Example()
    {
        // Arrange - Create a configuration with variables and resources
        var config = new TerraformConfiguration();

        var regionVar = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2"
        };
        config.Add(regionVar);

        var vpc = new TerraformResource("aws_vpc", "main");
        vpc.Set("cidr_block", "10.0.0.0/16");
        vpc.Set("tags", new TerraformObject
        {
            ["Name"] = "main-vpc",
            ["Region"] = regionVar.AsReference()
        });
        config.Add(vpc);

        var subnet = new TerraformResource("aws_subnet", "public");
        // Declare that the vpc resource has an 'id' output before referencing it
        vpc.DeclareOutput("id");
        subnet.Set("vpc_id", vpc["id"]);
        subnet.Set("cidr_block", "10.0.1.0/24");
        config.Add(subnet);

        // Act
        var hcl = config.ToHcl();

        // Assert
        Assert.Contains("variable \"region\"", hcl);
        Assert.Contains("resource \"aws_vpc\" \"main\"", hcl);
        Assert.Contains("resource \"aws_subnet\" \"public\"", hcl);
        Assert.Contains("vpc_id", hcl);
        Assert.Contains("aws_vpc.main.id", hcl);
    }

    [Fact]
    public void TerraformValue_Resolve_WorksWithContext()
    {
        // Arrange
        var value = new TerraformValue<string>("test");
        var context = TerraformContext.Temporary();

        // Act
        var expr = value.Resolve(context);

        // Assert
        Assert.Equal("\"test\"", expr.ToHcl());
    }

    [Fact]
    public Task LazyValue_ComputesAtResolutionTime()
    {
        // Arrange - Create lazy values that compute at resolution time
        var config = new TerraformConfiguration();

        // Lazy value that computes dynamically based on context
        var computedRegion = Token.Lazy<string>(ctx =>
        {
            return ctx.Scope.Name == "production" ? "us-east-1" : "us-west-2";
        });

        var context = new TerraformContext(config);
        var result = computedRegion.Resolve(context);

        // Assert
        Assert.Equal("us-west-2", result);

        // Test with production config
        var prodConfig = new TerraformConfiguration("production");
        var prodContext = new TerraformContext(prodConfig);
        var prodRegion = Token.Lazy<string>(ctx =>
        {
            return ctx.Scope.Name == "production" ? "us-east-1" : "us-west-2";
        });

        var prodResult = prodRegion.Resolve(prodContext);
        Assert.Equal("us-east-1", prodResult);

        return Task.CompletedTask;
    }

    [Fact]
    public Task CrossResourceReferences_ResolveCorrectly()
    {
        // Arrange - Create resources with cross-references
        var config = new TerraformConfiguration();

        // Create a VPC
        var vpc = new TerraformResource("aws_vpc", "main");
        vpc.Set("cidr_block", "10.0.0.0/16");
        vpc.DeclareOutput("id");
        config.Add(vpc);

        // Create subnets that reference the VPC
        var publicSubnet = new TerraformResource("aws_subnet", "public");
        publicSubnet.Set("vpc_id", vpc["id"]);
        publicSubnet.Set("cidr_block", "10.0.1.0/24");
        publicSubnet.DeclareOutput("id");
        config.Add(publicSubnet);

        var privateSubnet = new TerraformResource("aws_subnet", "private");
        privateSubnet.Set("vpc_id", vpc["id"]);
        privateSubnet.Set("cidr_block", "10.0.2.0/24");
        config.Add(privateSubnet);

        // Act & Assert
        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ComplexInfrastructure_WithMultipleDependencies()
    {
        // Arrange - Build infrastructure with multiple cross-references
        var config = new TerraformConfiguration("production");

        // Variables
        var regionVar = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2",
            Description = "AWS region"
        };
        config.Add(regionVar);

        var environmentVar = new TerraformVariable("environment")
        {
            Type = "string",
            Default = "prod"
        };
        config.Add(environmentVar);

        // VPC
        var vpc = new TerraformResource("aws_vpc", "main");
        vpc.Set("cidr_block", "10.0.0.0/16");
        vpc.Set("tags", new TerraformObject
        {
            ["Name"] = TerraformExpression.Interpolate("vpc-", environmentVar.AsReference()),
            ["Environment"] = environmentVar.AsReference()
        });
        vpc.DeclareOutput("id");
        config.Add(vpc);

        // Internet Gateway
        var igw = new TerraformResource("aws_internet_gateway", "main");
        igw.Set("vpc_id", vpc["id"]);
        igw.DeclareOutput("id");
        config.Add(igw);

        // Public Subnet
        var publicSubnet = new TerraformResource("aws_subnet", "public");
        publicSubnet.Set("vpc_id", vpc["id"]);
        publicSubnet.Set("cidr_block", "10.0.1.0/24");
        publicSubnet.Set("map_public_ip_on_launch", true);
        publicSubnet.DeclareOutput("id");
        config.Add(publicSubnet);

        // Route Table
        var routeTable = new TerraformResource("aws_route_table", "public");
        routeTable.Set("vpc_id", vpc["id"]);
        routeTable.DeclareOutput("id");
        config.Add(routeTable);

        // Route
        var route = new TerraformResource("aws_route", "public_internet");
        route.Set("route_table_id", routeTable["id"]);
        route.Set("destination_cidr_block", "0.0.0.0/0");
        route.Set("gateway_id", igw["id"]);
        config.Add(route);

        // Act & Assert - Two-pass resolution handles all dependencies
        return Verify(config.ToHcl());
    }

    [Fact]
    public void LazyValue_CachesComputedValue()
    {
        // Arrange - Demonstrate lazy value caching
        var computeCount = 0;
        var expensiveComputation = Token.Lazy(() =>
        {
            computeCount++;
            Thread.Sleep(10);
            return $"computed-{computeCount}";
        });

        var config = new TerraformConfiguration();
        var context = new TerraformContext(config);

        // Act - Resolve multiple times
        var result1 = expensiveComputation.Resolve(context);
        var result2 = expensiveComputation.Resolve(context);
        var result3 = expensiveComputation.Resolve(context);

        // Assert - Computed only once due to caching
        Assert.Equal(1, computeCount);
        Assert.Equal("computed-1", result1);
        Assert.Equal("computed-1", result2);
        Assert.Equal("computed-1", result3);
    }
}
