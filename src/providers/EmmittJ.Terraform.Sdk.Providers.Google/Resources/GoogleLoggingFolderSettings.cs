using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLoggingFolderSettingsTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_logging_folder_settings resource.
/// </summary>
public class GoogleLoggingFolderSettings : TerraformResource
{
    public GoogleLoggingFolderSettings(string name) : base("google_logging_folder_settings", name)
    {
    }

    /// <summary>
    /// If set to true, the _Default sink in newly created projects and folders will created in a disabled state. This can be used to automatically disable log storage if there is already an aggregated sink configured in the hierarchy. The _Default sink can be re-enabled manually if needed.
    /// </summary>
    [TerraformPropertyName("disable_default_sink")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableDefaultSink { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_default_sink");

    /// <summary>
    /// The folder for which to retrieve settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformPropertyName("folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource name for the configured Cloud KMS key.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_name");

    /// <summary>
    /// The storage location that Cloud Logging will use to create new resources when a location is needed but not explicitly provided.
    /// </summary>
    [TerraformPropertyName("storage_location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageLocation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_location");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleLoggingFolderSettingsTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The service account that will be used by the Log Router to access your Cloud KMS key.
    /// </summary>
    [TerraformPropertyName("kms_service_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsServiceAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_service_account_id");

    /// <summary>
    /// The service account for the given container. Sinks use this service account as their writerIdentity if no custom service account is provided.
    /// </summary>
    [TerraformPropertyName("logging_service_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoggingServiceAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logging_service_account_id");

    /// <summary>
    /// The resource name of the settings.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
