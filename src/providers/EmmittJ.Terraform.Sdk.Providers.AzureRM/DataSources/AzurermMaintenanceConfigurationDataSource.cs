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
public class AzurermMaintenanceConfigurationDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_maintenance_configuration.
/// </summary>
public class AzurermMaintenanceConfigurationDataSource : TerraformDataSource
{
    public AzurermMaintenanceConfigurationDataSource(string name) : base("azurerm_maintenance_configuration", name)
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
    public AzurermMaintenanceConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    [TerraformArgument("in_guest_user_patch_mode")]
    public TerraformValue<string> InGuestUserPatchMode
    {
        get => new TerraformReference<string>(this, "in_guest_user_patch_mode");
    }

    /// <summary>
    /// The install_patches attribute.
    /// </summary>
    [TerraformArgument("install_patches")]
    public TerraformList<object> InstallPatches
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "install_patches").ResolveNodes(ctx));
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
    /// The properties attribute.
    /// </summary>
    [TerraformArgument("properties")]
    public TerraformMap<string> Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformArgument("scope")]
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformArgument("visibility")]
    public TerraformValue<string> Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
    }

    /// <summary>
    /// The window attribute.
    /// </summary>
    [TerraformArgument("window")]
    public TerraformList<object> Window
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "window").ResolveNodes(ctx));
    }

}
