using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleLoggingOrganizationSettingsTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_logging_organization_settings resource.
/// </summary>
public partial class GoogleLoggingOrganizationSettings : TerraformResource
{
    public GoogleLoggingOrganizationSettings(string name) : base("google_logging_organization_settings", name)
    {
    }

    /// <summary>
    /// If set to true, the _Default sink in newly created projects and folders will created in a disabled state. This can be used to automatically disable log storage if there is already an aggregated sink configured in the hierarchy. The _Default sink can be re-enabled manually if needed.
    /// </summary>
    [TerraformProperty("disable_default_sink")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisableDefaultSink { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource name for the configured Cloud KMS key.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyName { get; set; }

    /// <summary>
    /// The organization for which to retrieve or configure settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// The storage location that Cloud Logging will use to create new resources when a location is needed but not explicitly provided.
    /// </summary>
    [TerraformProperty("storage_location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageLocation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleLoggingOrganizationSettingsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The service account that will be used by the Log Router to access your Cloud KMS key.
    /// </summary>
    [TerraformProperty("kms_service_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsServiceAccountId { get; }

    /// <summary>
    /// The service account for the given container. Sinks use this service account as their writerIdentity if no custom service account is provided.
    /// </summary>
    [TerraformProperty("logging_service_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoggingServiceAccountId { get; }

    /// <summary>
    /// The resource name of the settings.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
