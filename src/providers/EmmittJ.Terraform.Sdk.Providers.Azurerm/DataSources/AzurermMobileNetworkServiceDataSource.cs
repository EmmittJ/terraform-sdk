using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkServiceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkServiceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network_service Terraform data source.
/// Retrieves information about a azurerm_mobile_network_service.
/// </summary>
public partial class AzurermMobileNetworkServiceDataSource(string name) : TerraformDataSource("azurerm_mobile_network_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => GetArgument<TerraformValue<string>>("mobile_network_id");
        set => SetArgument("mobile_network_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The pcc_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PccRule
        => AsReference("pcc_rule");

    /// <summary>
    /// The service_precedence attribute.
    /// </summary>
    public TerraformValue<double> ServicePrecedence
        => AsReference("service_precedence");

    /// <summary>
    /// The service_qos_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceQosPolicy
        => AsReference("service_qos_policy");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
