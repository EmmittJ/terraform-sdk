using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudServiceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudServiceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_service Terraform data source.
/// Retrieves information about a azurerm_spring_cloud_service.
/// </summary>
public partial class AzurermSpringCloudServiceDataSource(string name) : TerraformDataSource("azurerm_spring_cloud_service", name)
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
    /// The config_server_git_setting attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConfigServerGitSetting
        => AsReference("config_server_git_setting");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> OutboundPublicIpAddresses
        => AsReference("outbound_public_ip_addresses");

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequiredNetworkTrafficRules
        => AsReference("required_network_traffic_rules");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
