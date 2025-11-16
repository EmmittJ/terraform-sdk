using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for data_flow in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataFlowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_flow";

    /// <summary>
    /// The built_in_transform attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInTransform
    {
        get => new TerraformReference<string>(this, "built_in_transform");
        set => SetArgument("built_in_transform", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public TerraformList<string>? Destinations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destinations").ResolveNodes(ctx));
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    public TerraformValue<string>? OutputStream
    {
        get => new TerraformReference<string>(this, "output_stream");
        set => SetArgument("output_stream", value);
    }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public TerraformList<string>? Streams
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "streams").ResolveNodes(ctx));
        set => SetArgument("streams", value);
    }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    public TerraformValue<string>? TransformKql
    {
        get => new TerraformReference<string>(this, "transform_kql");
        set => SetArgument("transform_kql", value);
    }

}

/// <summary>
/// Block type for data_sources in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_sources";

}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for stream_declaration in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDataCollectionRuleStreamDeclarationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stream_declaration";

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => new TerraformReference<string>(this, "stream_name");
        set => SetArgument("stream_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_monitor_data_collection_rule Terraform resource.
/// Manages a azurerm_monitor_data_collection_rule resource.
/// </summary>
public partial class AzurermMonitorDataCollectionRule(string name) : TerraformResource("azurerm_monitor_data_collection_rule", name)
{
    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? DataCollectionEndpointId
    {
        get => new TerraformReference<string>(this, "data_collection_endpoint_id");
        set => SetArgument("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// DataFlow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFlow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDataFlowBlock> DataFlow
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleDataFlowBlock>>("data_flow");
        set => SetArgument("data_flow", value);
    }

    /// <summary>
    /// DataSources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlock>? DataSources
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlock>>("data_sources");
        set => SetArgument("data_sources", value);
    }

    /// <summary>
    /// Destinations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlock> Destinations
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMonitorDataCollectionRuleIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMonitorDataCollectionRuleIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// StreamDeclaration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>? StreamDeclaration
    {
        get => GetArgument<TerraformSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>>("stream_declaration");
        set => SetArgument("stream_declaration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDataCollectionRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDataCollectionRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
