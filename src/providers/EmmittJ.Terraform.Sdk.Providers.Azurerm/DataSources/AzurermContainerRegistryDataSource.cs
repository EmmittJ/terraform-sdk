using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerRegistryDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_container_registry Terraform data source.
/// Retrieves information about a azurerm_container_registry.
/// </summary>
public partial class AzurermContainerRegistryDataSource(string name) : TerraformDataSource("azurerm_container_registry", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "data_endpoint_enabled");
    }

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    public TerraformSet<string> DataEndpointHostNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_endpoint_host_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
