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
public class AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_extended_location_custom_location.
/// </summary>
public class AzurermExtendedLocationCustomLocationDataSource : TerraformDataSource
{
    public AzurermExtendedLocationCustomLocationDataSource(string name) : base("azurerm_extended_location_custom_location", name)
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
    public AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformArgument("authentication")]
    public TerraformList<object> Authentication
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    [TerraformArgument("cluster_extension_ids")]
    public TerraformList<string> ClusterExtensionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cluster_extension_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The host_resource_id attribute.
    /// </summary>
    [TerraformArgument("host_resource_id")]
    public TerraformValue<string> HostResourceId
    {
        get => new TerraformReference<string>(this, "host_resource_id");
    }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    [TerraformArgument("host_type")]
    public TerraformValue<string> HostType
    {
        get => new TerraformReference<string>(this, "host_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformArgument("namespace")]
    public TerraformValue<string> Namespace
    {
        get => new TerraformReference<string>(this, "namespace");
    }

}
