using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevCenterProjectPoolDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_project_pool Terraform data source.
/// Retrieves information about a azurerm_dev_center_project_pool.
/// </summary>
public partial class AzurermDevCenterProjectPoolDataSource(string name) : TerraformDataSource("azurerm_dev_center_project_pool", name)
{
    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformValue<string> DevCenterProjectId
    {
        get => new TerraformReference<string>(this, "dev_center_project_id");
        set => SetArgument("dev_center_project_id", value);
    }

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
    /// The dev_box_definition_name attribute.
    /// </summary>
    public TerraformValue<string> DevBoxDefinitionName
    {
        get => new TerraformReference<string>(this, "dev_box_definition_name");
    }

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    public TerraformValue<string> DevCenterAttachedNetworkName
    {
        get => new TerraformReference<string>(this, "dev_center_attached_network_name");
    }

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAdministratorEnabled
    {
        get => new TerraformReference<bool>(this, "local_administrator_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SingleSignOnEnabled
    {
        get => new TerraformReference<bool>(this, "single_sign_on_enabled");
    }

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformValue<double> StopOnDisconnectGracePeriodMinutes
    {
        get => new TerraformReference<double>(this, "stop_on_disconnect_grace_period_minutes");
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
    public AzurermDevCenterProjectPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterProjectPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
