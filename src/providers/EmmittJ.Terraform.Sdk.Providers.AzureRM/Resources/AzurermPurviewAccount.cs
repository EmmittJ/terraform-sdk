using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermPurviewAccountIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPurviewAccountTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_purview_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPurviewAccount : TerraformResource
{
    public AzurermPurviewAccount(string name) : base("azurerm_purview_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_event_hub_enabled attribute.
    /// </summary>
    [TerraformPropertyName("managed_event_hub_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManagedEventHubEnabled { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedResourceGroupName { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermPurviewAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPurviewAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The atlas_kafka_endpoint_primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("atlas_kafka_endpoint_primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AtlasKafkaEndpointPrimaryConnectionString => new TerraformReference(this, "atlas_kafka_endpoint_primary_connection_string");

    /// <summary>
    /// The atlas_kafka_endpoint_secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("atlas_kafka_endpoint_secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AtlasKafkaEndpointSecondaryConnectionString => new TerraformReference(this, "atlas_kafka_endpoint_secondary_connection_string");

    /// <summary>
    /// The aws_external_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_external_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsExternalId => new TerraformReference(this, "aws_external_id");

    /// <summary>
    /// The catalog_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("catalog_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CatalogEndpoint => new TerraformReference(this, "catalog_endpoint");

    /// <summary>
    /// The guardian_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("guardian_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GuardianEndpoint => new TerraformReference(this, "guardian_endpoint");

    /// <summary>
    /// The managed_resources attribute.
    /// </summary>
    [TerraformPropertyName("managed_resources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedResources => new TerraformReference(this, "managed_resources");

    /// <summary>
    /// The scan_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("scan_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScanEndpoint => new TerraformReference(this, "scan_endpoint");

}
