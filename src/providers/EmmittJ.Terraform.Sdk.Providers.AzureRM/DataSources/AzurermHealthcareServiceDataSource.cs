using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareServiceDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_service.
/// </summary>
public partial class AzurermHealthcareServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareServiceDataSource(string name) : base("azurerm_healthcare_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermHealthcareServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformProperty("access_policy_object_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AccessPolicyObjectIds { get; }

    /// <summary>
    /// The authentication_configuration attribute.
    /// </summary>
    [TerraformProperty("authentication_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AuthenticationConfiguration { get; }

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    [TerraformProperty("cors_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CorsConfiguration { get; }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_key_vault_key_versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CosmosdbKeyVaultKeyVersionlessId { get; }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CosmosdbThroughput { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
