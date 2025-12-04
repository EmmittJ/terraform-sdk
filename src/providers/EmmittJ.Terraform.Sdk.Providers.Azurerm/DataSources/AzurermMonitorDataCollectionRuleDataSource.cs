using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorDataCollectionRuleDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_data_collection_rule Terraform data source.
/// Retrieves information about a azurerm_monitor_data_collection_rule.
/// </summary>
public partial class AzurermMonitorDataCollectionRuleDataSource(string name) : TerraformDataSource("azurerm_monitor_data_collection_rule", name)
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
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> DataCollectionEndpointId
        => AsReference("data_collection_endpoint_id");

    /// <summary>
    /// The data_flow attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataFlow
        => AsReference("data_flow");

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSources
        => AsReference("data_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Destinations
        => AsReference("destinations");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

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
    /// The stream_declaration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StreamDeclaration
        => AsReference("stream_declaration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
