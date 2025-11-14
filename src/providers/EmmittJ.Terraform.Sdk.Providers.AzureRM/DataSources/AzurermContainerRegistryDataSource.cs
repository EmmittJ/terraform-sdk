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
public class AzurermContainerRegistryDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_container_registry.
/// </summary>
public class AzurermContainerRegistryDataSource : TerraformDataSource
{
    public AzurermContainerRegistryDataSource(string name) : base("azurerm_container_registry", name)
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
    public AzurermContainerRegistryDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformArgument("admin_enabled")]
    public TerraformValue<bool> AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformArgument("admin_password")]
    public TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformArgument("admin_username")]
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("data_endpoint_enabled")]
    public TerraformValue<bool> DataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "data_endpoint_enabled");
    }

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    [TerraformArgument("data_endpoint_host_names")]
    public TerraformSet<string> DataEndpointHostNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_endpoint_host_names").ResolveNodes(ctx));
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
    /// The login_server attribute.
    /// </summary>
    [TerraformArgument("login_server")]
    public TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
