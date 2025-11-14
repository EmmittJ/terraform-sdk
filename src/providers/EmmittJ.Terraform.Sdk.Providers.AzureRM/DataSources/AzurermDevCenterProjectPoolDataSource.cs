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
public class AzurermDevCenterProjectPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dev_center_project_pool.
/// </summary>
public class AzurermDevCenterProjectPoolDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectPoolDataSource(string name) : base("azurerm_dev_center_project_pool", name)
    {
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    [TerraformArgument("dev_center_project_id")]
    public required TerraformValue<string> DevCenterProjectId
    {
        get => new TerraformReference<string>(this, "dev_center_project_id");
        set => SetArgument("dev_center_project_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevCenterProjectPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [TerraformArgument("dev_box_definition_name")]
    public TerraformValue<string> DevBoxDefinitionName
    {
        get => new TerraformReference<string>(this, "dev_box_definition_name");
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [TerraformArgument("dev_center_attached_network_name")]
    public TerraformValue<string> DevCenterAttachedNetworkName
    {
        get => new TerraformReference<string>(this, "dev_center_attached_network_name");
    }

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    [TerraformArgument("local_administrator_enabled")]
    public TerraformValue<bool> LocalAdministratorEnabled
    {
        get => new TerraformReference<bool>(this, "local_administrator_enabled");
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
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [TerraformArgument("single_sign_on_enabled")]
    public TerraformValue<bool> SingleSignOnEnabled
    {
        get => new TerraformReference<bool>(this, "single_sign_on_enabled");
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    [TerraformArgument("stop_on_disconnect_grace_period_minutes")]
    public TerraformValue<double> StopOnDisconnectGracePeriodMinutes
    {
        get => new TerraformReference<double>(this, "stop_on_disconnect_grace_period_minutes");
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
