using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_service.
/// </summary>
public class AzurermHealthcareServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareServiceDataSource(string name) : base("azurerm_healthcare_service", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHealthcareServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformPropertyName("access_policy_object_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AccessPolicyObjectIds => new TerraformReference(this, "access_policy_object_ids");

    /// <summary>
    /// The authentication_configuration attribute.
    /// </summary>
    [TerraformPropertyName("authentication_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthenticationConfiguration => new TerraformReference(this, "authentication_configuration");

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    [TerraformPropertyName("cors_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CorsConfiguration => new TerraformReference(this, "cors_configuration");

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_key_vault_key_versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CosmosdbKeyVaultKeyVersionlessId => new TerraformReference(this, "cosmosdb_key_vault_key_versionless_id");

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    [TerraformPropertyName("cosmosdb_throughput")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CosmosdbThroughput => new TerraformReference(this, "cosmosdb_throughput");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
