using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareDicomServiceCorsBlock() : TerraformBlock("cors")
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
    public partial TerraformList<string>? AllowedHeaders { get; set; }

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
    public partial TerraformList<string>? AllowedOrigins { get; set; }

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
public partial class AzurermHealthcareDicomServiceIdentityBlock() : TerraformBlock("identity")
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
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHealthcareDicomServiceStorageBlock() : TerraformBlock("storage")
{
    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemName is required")]
    [TerraformProperty("file_system_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileSystemName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareDicomServiceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_healthcare_dicom_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHealthcareDicomService : TerraformResource
{
    public AzurermHealthcareDicomService(string name) : base("azurerm_healthcare_dicom_service", name)
    {
    }

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    [TerraformProperty("data_partitions_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DataPartitionsEnabled { get; set; }

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    [TerraformProperty("encryption_key_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionKeyUrl { get; set; }

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

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
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformProperty("cors")]
    public TerraformList<AzurermHealthcareDicomServiceCorsBlock> Cors { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermHealthcareDicomServiceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Storage block(s) allowed")]
    [TerraformProperty("storage")]
    public TerraformList<AzurermHealthcareDicomServiceStorageBlock> Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermHealthcareDicomServiceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformProperty("authentication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Authentication { get; }

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    [TerraformProperty("private_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> PrivateEndpoint { get; }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformProperty("service_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceUrl { get; }

}
