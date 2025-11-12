using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareServiceAuthenticationConfigurationBlock() : TerraformBlock("authentication_configuration")
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [TerraformProperty("audience")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Audience { get; set; }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [TerraformProperty("authority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Authority { get; set; }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    [TerraformProperty("smart_proxy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmartProxyEnabled { get; set; }

}

/// <summary>
/// Block type for cors_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareServiceCorsConfigurationBlock() : TerraformBlock("cors_configuration")
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    [TerraformProperty("allow_credentials")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowCredentials { get; set; }

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformProperty("allowed_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [TerraformProperty("allowed_methods")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [TerraformProperty("allowed_origins")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [TerraformProperty("max_age_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAgeInSeconds { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareServiceIdentityBlock() : TerraformBlock("identity")
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareServiceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_healthcare_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHealthcareService : TerraformResource
{
    public AzurermHealthcareService(string name) : base("azurerm_healthcare_service", name)
    {
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformProperty("access_policy_object_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AccessPolicyObjectIds { get; set; }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    [TerraformProperty("configuration_export_storage_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationExportStorageAccountName { get; set; }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_key_vault_key_versionless_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CosmosdbKeyVaultKeyVersionlessId { get; set; }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    [TerraformProperty("cosmosdb_throughput")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CosmosdbThroughput { get; set; }

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

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
    /// Block for authentication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    [TerraformProperty("authentication_configuration")]
    public TerraformList<AzurermHealthcareServiceAuthenticationConfigurationBlock> AuthenticationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    [TerraformProperty("cors_configuration")]
    public TerraformList<AzurermHealthcareServiceCorsConfigurationBlock> CorsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermHealthcareServiceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermHealthcareServiceTimeoutsBlock Timeouts { get; set; } = new();

}
