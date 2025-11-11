using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareFhirServiceAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Audience is required")]
    [TerraformProperty("audience")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Audience { get; set; }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    [TerraformProperty("authority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Authority { get; set; }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    [TerraformProperty("smart_proxy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmartProxyEnabled { get; set; }

}

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareFhirServiceCorsBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformProperty("allowed_headers")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformProperty("allowed_origins")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedOrigins { get; set; }

    /// <summary>
    /// The credentials_allowed attribute.
    /// </summary>
    [TerraformProperty("credentials_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CredentialsAllowed { get; set; }

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
public partial class AzurermHealthcareFhirServiceIdentityBlock : TerraformBlockBase
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
/// Block type for oci_artifact in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareFhirServiceOciArtifactBlock : TerraformBlockBase
{
    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformProperty("digest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Digest { get; set; }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [TerraformProperty("image_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImageName { get; set; }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginServer is required")]
    [TerraformProperty("login_server")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoginServer { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareFhirServiceTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_healthcare_fhir_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHealthcareFhirService : TerraformResource
{
    public AzurermHealthcareFhirService(string name) : base("azurerm_healthcare_fhir_service", name)
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
    /// The container_registry_login_server_url attribute.
    /// </summary>
    [TerraformProperty("container_registry_login_server_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ContainerRegistryLoginServerUrl { get; set; }

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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformProperty("authentication")]
    public partial TerraformList<TerraformBlock<AzurermHealthcareFhirServiceAuthenticationBlock>>? Authentication { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformProperty("cors")]
    public partial TerraformList<TerraformBlock<AzurermHealthcareFhirServiceCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermHealthcareFhirServiceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for oci_artifact.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("oci_artifact")]
    public partial TerraformList<TerraformBlock<AzurermHealthcareFhirServiceOciArtifactBlock>>? OciArtifact { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermHealthcareFhirServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PublicNetworkAccessEnabled { get; }

}
