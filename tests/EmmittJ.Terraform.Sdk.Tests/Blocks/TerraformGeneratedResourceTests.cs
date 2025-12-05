using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Tests.TestHelpers;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests.Blocks;

/// <summary>
/// Tests for typed resource properties (mimicking source-generated resources).
/// These tests validate the lineage system for properties that use GetArgument/SetArgument.
/// </summary>
[Trait("Category", "Integration")]
[Trait("Layer", "Blocks")]
public class TerraformGeneratedResourceTests
{
    #region Test Resource Classes

    /// <summary>
    /// A test resource that mimics source-generated resources with typed properties.
    /// Uses IsRequiredArgument pattern: GetRequiredArgument/SetArgument
    /// </summary>
    private class TestResourceGroup(string name) : TerraformResource("test_resource_group", name)
    {
        // IsRequiredArgument pattern (required keyword)
        public required TerraformValue<string> Name
        {
            get => GetRequiredArgument<TerraformValue<string>>("name");
            set => SetArgument("name", value);
        }

        // IsRequiredArgument pattern (required keyword)
        public required TerraformValue<string> Location
        {
            get => GetRequiredArgument<TerraformValue<string>>("location");
            set => SetArgument("location", value);
        }

        // IsOptionalArgument pattern (nullable)
        public TerraformMap<string>? Tags
        {
            get => GetArgument<TerraformMap<string>>("tags");
            set => SetArgument("tags", value);
        }

        // IsOptionalAndComputed pattern: returns stored value OR a reference if not set
        public TerraformValue<string> Id
        {
            get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
            set => SetArgument("id", value);
        }

        // IsComputedAttribute pattern: always returns a reference (read-only computed)
        public TerraformValue<string> Arn
            => CreateReference("arn");
    }

    /// <summary>
    /// A test resource that depends on another resource via properties.
    /// </summary>
    private class TestLogAnalytics(string name) : TerraformResource("test_log_analytics", name)
    {
        public required TerraformValue<string> Name
        {
            get => GetRequiredArgument<TerraformValue<string>>("name");
            set => SetArgument("name", value);
        }

        public required TerraformValue<string> Location
        {
            get => GetRequiredArgument<TerraformValue<string>>("location");
            set => SetArgument("location", value);
        }

        public required TerraformValue<string> ResourceGroupName
        {
            get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
            set => SetArgument("resource_group_name", value);
        }

        // IsOptionalAndComputed pattern
        public TerraformValue<string> WorkspaceId
        {
            get => GetArgument<TerraformValue<string>>("workspace_id") ?? CreateReference("workspace_id");
            set => SetArgument("workspace_id", value);
        }
    }

    /// <summary>
    /// A test resource with nested block for testing lineage through nested structures.
    /// </summary>
    private class TestContainerApp(string name) : TerraformResource("test_container_app", name)
    {
        public required TerraformValue<string> Name
        {
            get => GetRequiredArgument<TerraformValue<string>>("name");
            set => SetArgument("name", value);
        }

        // Nested block list (like azurerm_container_app.ingress)
        public TerraformList<TestIngressBlock>? Ingress
        {
            get => GetArgument<TerraformList<TestIngressBlock>>("ingress");
            set => SetArgument("ingress", value);
        }
    }

    /// <summary>
    /// A nested block type for testing lineage through nested structures.
    /// </summary>
    private class TestIngressBlock : TerraformBlock
    {
        public override string BlockType => "ingress";

        public TerraformValue<int>? TargetPort
        {
            get => GetArgument<TerraformValue<int>>("target_port");
            set => SetArgument("target_port", value);
        }

        public TerraformValue<bool>? ExternalEnabled
        {
            get => GetArgument<TerraformValue<bool>>("external_enabled");
            set => SetArgument("external_enabled", value);
        }

        // Computed attribute on nested block
        public TerraformValue<string> Fqdn
            => CreateReference("fqdn");
    }

    #endregion

    #region Source Block Rendering (Should Use Literals)

    [Fact]
    public Task GeneratedResource_PropertyWithLiteralValue_RendersLiteral()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        var hcl = TerraformTestHelpers.RenderBlock(resourceGroup, context);

        return Verify(hcl);
    }

    [Fact]
    public Task GeneratedResource_OptionalProperty_Set_RendersValue()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2",
            Tags = new TerraformMap<string>
            {
                ["Environment"] = "Development",
                ["ManagedBy"] = "Terraform"
            }
        };
        stack.Add(resourceGroup);

        var hcl = TerraformTestHelpers.RenderBlock(resourceGroup, context);

        return Verify(hcl);
    }

    #endregion

    #region Cross-Resource References (Should Use References)

    [Fact]
    public Task GeneratedResource_PropertyWithReference_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        // Use the typed property (resourceGroup.Name) to set another resource's property
        // THIS IS THE KEY TEST: resourceGroup.Name should render as a reference, not literal
        var logAnalytics = new TestLogAnalytics("law")
        {
            Name = "my-log-analytics",
            Location = resourceGroup.Location,
            ResourceGroupName = resourceGroup.Name
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    [Fact]
    public Task GeneratedResource_IndexerWithReference_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        // Use the indexer (resourceGroup["name"]) to set another resource's property
        var logAnalytics = new TestLogAnalytics("law")
        {
            Name = "my-log-analytics",
            Location = resourceGroup["location"].AsLazy<string>(),
            ResourceGroupName = resourceGroup["name"].AsLazy<string>()
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    [Fact]
    public Task GeneratedResource_ToReferenceMethod_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        // Use ToReference().Member() to create an explicit reference
        var logAnalytics = new TerraformResource("test_log_analytics", "law")
        {
            ["name"] = "my-log-analytics",
            ["location"] = resourceGroup.ToReference().Member("location"),
            ["resource_group_name"] = resourceGroup.ToReference().Member("name")
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    #endregion

    #region Computed Attributes (Always References)

    [Fact]
    public Task GeneratedResource_ComputedAttribute_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        // Use the computed attribute (resourceGroup.Arn) - always a reference
        var logAnalytics = new TerraformResource("test_policy", "policy")
        {
            ["name"] = "my-policy",
            ["target_arn"] = resourceGroup.Arn
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    [Fact]
    public Task GeneratedResource_OptionalAndComputedNotSet_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
            // Id is NOT set, so getter should return CreateReference("id")
        };
        stack.Add(resourceGroup);

        // Use the optional+computed attribute when not set - should be a reference
        var logAnalytics = new TerraformResource("test_policy", "policy")
        {
            ["name"] = "my-policy",
            ["resource_group_id"] = resourceGroup.Id
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    [Fact]
    public Task GeneratedResource_OptionalAndComputedSet_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2",
            Id = "explicit-id-value" // Explicitly set
        };
        stack.Add(resourceGroup);

        // When a value is set on a resource and retrieved, it should still have lineage
        // because accessing resourceGroup.Id should give us a value that knows it came from resourceGroup
        var logAnalytics = new TerraformResource("test_policy", "policy")
        {
            ["name"] = "my-policy",
            ["resource_group_id"] = resourceGroup.Id
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    #endregion

    #region Chained References

    [Fact]
    public Task GeneratedResource_ChainedComputedReferences_RendersCorrectly()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        var logAnalytics = new TestLogAnalytics("law")
        {
            Name = "my-log-analytics",
            Location = resourceGroup.Location,
            ResourceGroupName = resourceGroup.Name
        };
        stack.Add(logAnalytics);

        // Use computed attribute from logAnalytics (WorkspaceId not set = reference)
        var sentinel = new TerraformResource("test_sentinel", "sentinel")
        {
            ["name"] = "my-sentinel",
            ["workspace_id"] = logAnalytics.WorkspaceId
        };
        stack.Add(sentinel);

        var hcl = TerraformTestHelpers.RenderBlock(sentinel, context);

        return Verify(hcl);
    }

    #endregion

    #region Nested Block Access

    [Fact]
    public Task GeneratedResource_NestedBlockListIndex_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var containerApp = new TestContainerApp("app")
        {
            Name = "my-app",
            Ingress =
            [
                new TestIngressBlock
                {
                    TargetPort = 80,
                    ExternalEnabled = true
                }
            ]
        };
        stack.Add(containerApp);

        // Access nested block computed attribute: containerApp.Ingress[0].Fqdn
        var output = new TerraformOutput("app_fqdn")
        {
            Value = containerApp.Ingress![0].Fqdn
        };
        stack.Add(output);

        var hcl = TerraformTestHelpers.RenderBlock(output, context);

        return Verify(hcl);
    }

    [Fact]
    public Task GeneratedResource_NestedBlockProperty_RendersReference()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var containerApp = new TestContainerApp("app")
        {
            Name = "my-app",
            Ingress =
            [
                new TestIngressBlock
                {
                    TargetPort = 80,
                    ExternalEnabled = true
                }
            ]
        };
        stack.Add(containerApp);

        // Access nested block set property: containerApp.Ingress[0].TargetPort
        // Even though it's set to 80, when used elsewhere it should be a reference
        var otherResource = new TerraformResource("test_other", "other")
        {
            ["port"] = containerApp.Ingress![0].TargetPort!
        };
        stack.Add(otherResource);

        var hcl = TerraformTestHelpers.RenderBlock(otherResource, context);

        return Verify(hcl);
    }

    #endregion

    #region Block Not Added to Stack (No Lineage)

    [Fact]
    public Task GeneratedResource_NotAddedToStack_PropertyRendersLiteral()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        // Resource NOT added to stack - should have no lineage
        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        // Note: NOT calling stack.Add(resourceGroup)

        // When used in another resource, should render as literal since no lineage
        var logAnalytics = new TestLogAnalytics("law")
        {
            Name = "my-log-analytics",
            Location = resourceGroup.Location,
            ResourceGroupName = resourceGroup.Name
        };
        stack.Add(logAnalytics);

        var hcl = TerraformTestHelpers.RenderBlock(logAnalytics, context);

        return Verify(hcl);
    }

    #endregion

    #region Data Sources

    [Fact]
    public Task GeneratedResource_DataSourceReference_RendersCorrectly()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        // Data source using untyped block
        var acrDataSource = new TerraformDataSource("test_container_registry", "acr")
        {
            ["name"] = "my-registry",
            ["resource_group_name"] = "my-rg"
        };
        stack.Add(acrDataSource);

        // Use data source attribute via indexer
        var roleAssignment = new TerraformResource("test_role_assignment", "pull")
        {
            ["scope"] = acrDataSource["id"],
            ["role_definition_name"] = "Reader"
        };
        stack.Add(roleAssignment);

        var hcl = TerraformTestHelpers.RenderBlock(roleAssignment, context);

        return Verify(hcl);
    }

    #endregion

    #region Variables

    [Fact]
    public Task GeneratedResource_VariableReference_RendersCorrectly()
    {
        var stack = new TerraformStack { Name = "test" };
        var context = new TerraformContext(stack);

        var locationVar = new TerraformVariable("location")
        {
            Type = "string",
            Default = "westus2"
        };
        stack.Add(locationVar);

        var resourceGroup = new TerraformResource("test_resource_group", "rg")
        {
            ["name"] = "my-rg",
            ["location"] = locationVar.ToReference()
        };
        stack.Add(resourceGroup);

        var hcl = TerraformTestHelpers.RenderBlock(resourceGroup, context);

        return Verify(hcl);
    }

    #endregion

    #region Both Blocks Rendered (Full Stack)

    [Fact]
    public Task GeneratedResource_FullStack_SourceAndReferencer()
    {
        var stack = new TerraformStack { Name = "test" };

        var resourceGroup = new TestResourceGroup("rg")
        {
            Name = "my-resource-group",
            Location = "westus2"
        };
        stack.Add(resourceGroup);

        var logAnalytics = new TestLogAnalytics("law")
        {
            Name = "my-log-analytics",
            Location = resourceGroup.Location,
            ResourceGroupName = resourceGroup.Name
        };
        stack.Add(logAnalytics);

        // Render the full stack to see both resources
        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    #endregion
}
