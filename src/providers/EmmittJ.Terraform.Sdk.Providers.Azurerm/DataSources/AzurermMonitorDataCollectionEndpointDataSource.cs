using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorDataCollectionEndpointDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_data_collection_endpoint Terraform data source.
/// Retrieves information about a azurerm_monitor_data_collection_endpoint.
/// </summary>
public partial class AzurermMonitorDataCollectionEndpointDataSource(string name) : TerraformDataSource("azurerm_monitor_data_collection_endpoint", name)
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
    /// The configuration_access_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationAccessEndpoint
        => AsReference("configuration_access_endpoint");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    public TerraformValue<string> ImmutableId
        => AsReference("immutable_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The logs_ingestion_endpoint attribute.
    /// </summary>
    public TerraformValue<string> LogsIngestionEndpoint
        => AsReference("logs_ingestion_endpoint");

    /// <summary>
    /// The metrics_ingestion_endpoint attribute.
    /// </summary>
    public TerraformValue<string> MetricsIngestionEndpoint
        => AsReference("metrics_ingestion_endpoint");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDataCollectionEndpointDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
