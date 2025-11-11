using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_flow in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorDataCollectionRuleDataFlowBlock : TerraformBlockBase
{
    /// <summary>
    /// The built_in_transform attribute.
    /// </summary>
    [TerraformProperty("built_in_transform")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BuiltInTransform { get; set; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [TerraformProperty("destinations")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Destinations { get; set; }

    /// <summary>
    /// The output_stream attribute.
    /// </summary>
    [TerraformProperty("output_stream")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutputStream { get; set; }

    /// <summary>
    /// The streams attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Streams is required")]
    [TerraformProperty("streams")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Streams { get; set; }

    /// <summary>
    /// The transform_kql attribute.
    /// </summary>
    [TerraformProperty("transform_kql")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransformKql { get; set; }

}

/// <summary>
/// Block type for data_sources in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorDataCollectionRuleDataSourcesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorDataCollectionRuleDestinationsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorDataCollectionRuleIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for stream_declaration in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMonitorDataCollectionRuleStreamDeclarationBlock : TerraformBlockBase
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformProperty("stream_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorDataCollectionRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_data_collection_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMonitorDataCollectionRule : TerraformResource
{
    public AzurermMonitorDataCollectionRule(string name) : base("azurerm_monitor_data_collection_rule", name)
    {
    }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("data_collection_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataCollectionEndpointId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for data_flow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFlow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataFlow block(s) required")]
    [TerraformProperty("data_flow")]
    public partial TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleDataFlowBlock>>? DataFlow { get; set; }

    /// <summary>
    /// Block for data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSources block(s) allowed")]
    [TerraformProperty("data_sources")]
    public partial TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleDataSourcesBlock>>? DataSources { get; set; }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destinations block(s) allowed")]
    [TerraformProperty("destinations")]
    public partial TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleDestinationsBlock>>? Destinations { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermMonitorDataCollectionRuleIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for stream_declaration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("stream_declaration")]
    public partial TerraformSet<TerraformBlock<AzurermMonitorDataCollectionRuleStreamDeclarationBlock>>? StreamDeclaration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMonitorDataCollectionRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    [TerraformProperty("immutable_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImmutableId { get; }

}
