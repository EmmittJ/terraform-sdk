using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network Terraform data source.
/// Retrieves information about a azurerm_mobile_network.
/// </summary>
public partial class AzurermMobileNetworkDataSource(string name) : TerraformDataSource("azurerm_mobile_network", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The mobile_country_code attribute.
    /// </summary>
    public TerraformValue<string> MobileCountryCode
        => AsReference("mobile_country_code");

    /// <summary>
    /// The mobile_network_code attribute.
    /// </summary>
    public TerraformValue<string> MobileNetworkCode
        => AsReference("mobile_network_code");

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformValue<string> ServiceKey
        => AsReference("service_key");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
