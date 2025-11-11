using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPurviewAccountIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPurviewAccountTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_purview_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPurviewAccount : TerraformResource
{
    public AzurermPurviewAccount(string name) : base("azurerm_purview_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    [TerraformProperty("managed_event_hub_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ManagedEventHubEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermPurviewAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPurviewAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The atlas_kafka_endpoint_primary_connection_string attribute.
    /// </summary>
    [TerraformProperty("atlas_kafka_endpoint_primary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AtlasKafkaEndpointPrimaryConnectionString { get; }

    /// <summary>
    /// The atlas_kafka_endpoint_secondary_connection_string attribute.
    /// </summary>
    [TerraformProperty("atlas_kafka_endpoint_secondary_connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AtlasKafkaEndpointSecondaryConnectionString { get; }

    /// <summary>
    /// The aws_external_id attribute.
    /// </summary>
    [TerraformProperty("aws_external_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsExternalId { get; }

    /// <summary>
    /// The catalog_endpoint attribute.
    /// </summary>
    [TerraformProperty("catalog_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CatalogEndpoint { get; }

    /// <summary>
    /// The guardian_endpoint attribute.
    /// </summary>
    [TerraformProperty("guardian_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GuardianEndpoint { get; }

    /// <summary>
    /// The managed_resources attribute.
    /// </summary>
    [TerraformProperty("managed_resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedResources { get; }

    /// <summary>
    /// The scan_endpoint attribute.
    /// </summary>
    [TerraformProperty("scan_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScanEndpoint { get; }

}
