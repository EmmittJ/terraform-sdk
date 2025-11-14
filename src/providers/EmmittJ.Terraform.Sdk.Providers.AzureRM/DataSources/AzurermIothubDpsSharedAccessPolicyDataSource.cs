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
public class AzurermIothubDpsSharedAccessPolicyDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_iothub_dps_shared_access_policy.
/// </summary>
public class AzurermIothubDpsSharedAccessPolicyDataSource : TerraformDataSource
{
    public AzurermIothubDpsSharedAccessPolicyDataSource(string name) : base("azurerm_iothub_dps_shared_access_policy", name)
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
    /// The iothub_dps_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubDpsName is required")]
    [TerraformArgument("iothub_dps_name")]
    public required TerraformValue<string> IothubDpsName
    {
        get => new TerraformReference<string>(this, "iothub_dps_name");
        set => SetArgument("iothub_dps_name", value);
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
    public AzurermIothubDpsSharedAccessPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("primary_connection_string")]
    public TerraformValue<string> PrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "primary_connection_string");
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformArgument("primary_key")]
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
    }

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("secondary_connection_string")]
    public TerraformValue<string> SecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "secondary_connection_string");
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformArgument("secondary_key")]
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
    }

}
