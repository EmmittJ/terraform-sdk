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
        get => new TerraformReference<string>(this, "read");
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
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> DataCollectionEndpointId
    {
        get => new TerraformReference<string>(this, "data_collection_endpoint_id");
    }

    /// <summary>
    /// The data_flow attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataFlow
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_flow").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_sources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Destinations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "destinations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    public TerraformValue<string> ImmutableId
    {
        get => new TerraformReference<string>(this, "immutable_id");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The stream_declaration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StreamDeclaration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "stream_declaration").ResolveNodes(ctx));
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
    public AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
