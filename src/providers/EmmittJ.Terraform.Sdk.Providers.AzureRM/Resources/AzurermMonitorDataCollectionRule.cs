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
        set => SetProperty("built_in_transform", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public List<TerraformProperty<string>>? Destinations
    {
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    public TerraformProperty<string>? OutputStream
    {
        set => SetProperty("output_stream", value);
    }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    public List<TerraformProperty<string>>? Streams
    {
        set => SetProperty("streams", value);
    }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    public TerraformProperty<string>? TransformKql
    {
        set => SetProperty("transform_kql", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("stream_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("immutable_id");
        SetOutput("data_collection_endpoint_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kind");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> DataCollectionEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_collection_endpoint_id");
        set => SetProperty("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for data_flow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFlow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    public List<AzurermMonitorDataCollectionRuleDataFlowBlock>? DataFlow
    {
        set => SetProperty("data_flow", value);
    }

    /// <summary>
    /// Block for data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    public List<AzurermMonitorDataCollectionRuleDataSourcesBlock>? DataSources
    {
        set => SetProperty("data_sources", value);
    }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    public List<AzurermMonitorDataCollectionRuleDestinationsBlock>? Destinations
    {
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMonitorDataCollectionRuleIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for stream_declaration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>? StreamDeclaration
    {
        set => SetProperty("stream_declaration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorDataCollectionRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    public TerraformExpression ImmutableId => this["immutable_id"];

}
