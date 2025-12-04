using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevCenterAttachedNetworkDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterAttachedNetworkDataSourceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_attached_network Terraform data source.
/// Retrieves information about a azurerm_dev_center_attached_network.
/// </summary>
public partial class AzurermDevCenterAttachedNetworkDataSource(string name) : TerraformDataSource("azurerm_dev_center_attached_network", name)
{
    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformValue<string> DevCenterId
    {
        get => GetArgument<TerraformValue<string>>("dev_center_id");
        set => SetArgument("dev_center_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_connection_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkConnectionId
        => AsReference("network_connection_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterAttachedNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterAttachedNetworkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
