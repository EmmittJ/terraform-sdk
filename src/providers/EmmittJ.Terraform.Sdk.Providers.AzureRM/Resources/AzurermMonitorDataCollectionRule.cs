using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_flow in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataFlowBlock : ITerraformBlock
{
    /// <summary>
    /// The built_in_transform attribute.
    /// </summary>
    [TerraformPropertyName("built_in_transform")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BuiltInTransform { get; set; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [TerraformPropertyName("destinations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Destinations { get; set; }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    [TerraformPropertyName("output_stream")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutputStream { get; set; }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    [TerraformPropertyName("streams")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Streams { get; set; }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    [TerraformPropertyName("transform_kql")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransformKql { get; set; }

}

/// <summary>
/// Block type for data_sources in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourcesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleDestinationsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorDataCollectionRuleIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for stream_declaration in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDataCollectionRuleStreamDeclarationBlock : ITerraformBlock
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformPropertyName("stream_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StreamName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("data_collection_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataCollectionEndpointId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Kind { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for data_flow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFlow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    [TerraformPropertyName("data_flow")]
    public TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleDataFlowBlock>>? DataFlow { get; set; } = new();

    /// <summary>
    /// Block for data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    [TerraformPropertyName("data_sources")]
    public TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleDataSourcesBlock>>? DataSources { get; set; } = new();

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    [TerraformPropertyName("destinations")]
    public TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleDestinationsBlock>>? Destinations { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for stream_declaration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("stream_declaration")]
    public TerraformSet<TerraformBlock<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>>? StreamDeclaration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorDataCollectionRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    [TerraformPropertyName("immutable_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImmutableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "immutable_id");

}
