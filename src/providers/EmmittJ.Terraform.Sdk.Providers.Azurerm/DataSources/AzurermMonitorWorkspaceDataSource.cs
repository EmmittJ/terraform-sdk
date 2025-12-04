using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorWorkspaceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorWorkspaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_workspace Terraform data source.
/// Retrieves information about a azurerm_monitor_workspace.
/// </summary>
public partial class AzurermMonitorWorkspaceDataSource(string name) : TerraformDataSource("azurerm_monitor_workspace", name)
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
    /// The default_data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultDataCollectionEndpointId
        => AsReference("default_data_collection_endpoint_id");

    /// <summary>
    /// The default_data_collection_rule_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultDataCollectionRuleId
        => AsReference("default_data_collection_rule_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The query_endpoint attribute.
    /// </summary>
    public TerraformValue<string> QueryEndpoint
        => AsReference("query_endpoint");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorWorkspaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorWorkspaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
