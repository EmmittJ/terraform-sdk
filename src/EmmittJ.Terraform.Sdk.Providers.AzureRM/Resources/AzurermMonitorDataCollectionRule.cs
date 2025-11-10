using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_flow in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataFlowBlock : TerraformBlock
{
    /// <summary>
    /// The built_in_transform attribute.
    /// </summary>
    public TerraformProperty<string>? BuiltInTransform
    {
        get => GetProperty<TerraformProperty<string>>("built_in_transform");
        set => WithProperty("built_in_transform", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public List<TerraformProperty<string>>? Destinations
    {
        get => GetProperty<List<TerraformProperty<string>>>("destinations");
        set => WithProperty("destinations", value);
    }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    public TerraformProperty<string>? OutputStream
    {
        get => GetProperty<TerraformProperty<string>>("output_stream");
        set => WithProperty("output_stream", value);
    }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public List<TerraformProperty<string>>? Streams
    {
        get => GetProperty<List<TerraformProperty<string>>>("streams");
        set => WithProperty("streams", value);
    }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    public TerraformProperty<string>? TransformKql
    {
        get => GetProperty<TerraformProperty<string>>("transform_kql");
        set => WithProperty("transform_kql", value);
    }

}

/// <summary>
/// Block type for data_sources in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for stream_declaration in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDataCollectionRuleStreamDeclarationBlock : TerraformBlock
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformProperty<string> StreamName
    {
        get => GetProperty<TerraformProperty<string>>("stream_name");
        set => WithProperty("stream_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("immutable_id");
    }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataCollectionEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("data_collection_endpoint_id");
        set => this.WithProperty("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for data_flow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    public List<AzurermMonitorDataCollectionRuleDataFlowBlock>? DataFlow
    {
        get => GetProperty<List<AzurermMonitorDataCollectionRuleDataFlowBlock>>("data_flow");
        set => this.WithProperty("data_flow", value);
    }

    /// <summary>
    /// Block for data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    public List<AzurermMonitorDataCollectionRuleDataSourcesBlock>? DataSources
    {
        get => GetProperty<List<AzurermMonitorDataCollectionRuleDataSourcesBlock>>("data_sources");
        set => this.WithProperty("data_sources", value);
    }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    public List<AzurermMonitorDataCollectionRuleDestinationsBlock>? Destinations
    {
        get => GetProperty<List<AzurermMonitorDataCollectionRuleDestinationsBlock>>("destinations");
        set => this.WithProperty("destinations", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMonitorDataCollectionRuleIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMonitorDataCollectionRuleIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for stream_declaration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>? StreamDeclaration
    {
        get => GetProperty<HashSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>>("stream_declaration");
        set => this.WithProperty("stream_declaration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorDataCollectionRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorDataCollectionRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    public TerraformExpression ImmutableId => this["immutable_id"];

}
