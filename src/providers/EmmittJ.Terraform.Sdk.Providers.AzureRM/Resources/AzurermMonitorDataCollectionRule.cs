using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("built_in_transform")]
    public TerraformValue<string>? BuiltInTransform
    {
        get => new TerraformReference<string>(this, "built_in_transform");
        set => SetArgument("built_in_transform", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [TerraformArgument("destinations")]
    public TerraformList<string>? Destinations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destinations").ResolveNodes(ctx));
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    [TerraformArgument("output_stream")]
    public TerraformValue<string>? OutputStream
    {
        get => new TerraformReference<string>(this, "output_stream");
        set => SetArgument("output_stream", value);
    }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    [TerraformArgument("streams")]
    public TerraformList<string>? Streams
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "streams").ResolveNodes(ctx));
        set => SetArgument("streams", value);
    }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    [TerraformArgument("transform_kql")]
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    [TerraformArgument("stream_name")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_monitor_data_collection_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorDataCollectionRule : TerraformResource
{
    public AzurermMonitorDataCollectionRule(string name) : base("azurerm_monitor_data_collection_rule", name)
    {
    }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    [TerraformArgument("data_collection_endpoint_id")]
    public TerraformValue<string>? DataCollectionEndpointId
    {
        get => new TerraformReference<string>(this, "data_collection_endpoint_id");
        set => SetArgument("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for data_flow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFlow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    [TerraformArgument("data_flow")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDataFlowBlock> DataFlow { get; set; } = new();

    /// <summary>
    /// Block for data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    [TerraformArgument("data_sources")]
    public TerraformList<AzurermMonitorDataCollectionRuleDataSourcesBlock> DataSources { get; set; } = new();

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    [TerraformArgument("destinations")]
    public required TerraformList<AzurermMonitorDataCollectionRuleDestinationsBlock> Destinations { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMonitorDataCollectionRuleIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for stream_declaration.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("stream_declaration")]
    public TerraformSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock> StreamDeclaration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorDataCollectionRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    [TerraformArgument("immutable_id")]
    public TerraformValue<string> ImmutableId
    {
        get => new TerraformReference<string>(this, "immutable_id");
    }

}
