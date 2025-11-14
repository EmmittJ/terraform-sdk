using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_dev_test_virtual_network.
/// </summary>
public class AzurermDevTestVirtualNetworkDataSource : TerraformDataSource
{
    public AzurermDevTestVirtualNetworkDataSource(string name) : base("azurerm_dev_test_virtual_network", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    [TerraformArgument("lab_name")]
    public required TerraformValue<string> LabName
    {
        get => new TerraformReference<string>(this, "lab_name");
        set => SetArgument("lab_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allowed_subnets attribute.
    /// </summary>
    [TerraformArgument("allowed_subnets")]
    public TerraformList<object> AllowedSubnets
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "allowed_subnets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_overrides attribute.
    /// </summary>
    [TerraformArgument("subnet_overrides")]
    public TerraformList<object> SubnetOverrides
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "subnet_overrides").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformArgument("unique_identifier")]
    public TerraformValue<string> UniqueIdentifier
    {
        get => new TerraformReference<string>(this, "unique_identifier");
    }

}
