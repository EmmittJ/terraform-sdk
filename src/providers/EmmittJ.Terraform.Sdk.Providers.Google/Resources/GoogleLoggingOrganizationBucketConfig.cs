using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cmek_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLoggingOrganizationBucketConfigCmekSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource name for the configured Cloud KMS key.
    /// KMS key name format:
    /// &amp;quot;projects/[PROJECT_ID]/locations/[LOCATION]/keyRings/[KEYRING]/cryptoKeys/[KEY]&amp;quot;
    /// To enable CMEK for the bucket, set this field to a valid kmsKeyName for which the associated service account has the required cloudkms.cryptoKeyEncrypterDecrypter roles assigned for the key.
    /// The Cloud KMS key used by the bucket can be updated by changing the kmsKeyName to a new valid key name. Encryption operations that are in progress will be completed with the key that was in use when they started. Decryption operations will be completed using the key that was used at the time of encryption unless access to that key has been revoked.
    /// See [Enabling CMEK for Logging Buckets](https://cloud.google.com/logging/docs/routing/managed-encryption-storage) for more information.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyName { get; set; }




}

/// <summary>
/// Block type for index_configs in .
/// Nesting mode: set
/// </summary>
public partial class GoogleLoggingOrganizationBucketConfigIndexConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// The LogEntry field path to index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldPath is required")]
    [TerraformProperty("field_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FieldPath { get; set; }

    /// <summary>
    /// The type of data in this index
    /// Note that some paths are automatically indexed, and other paths are not eligible for indexing. See [indexing documentation]( https://cloud.google.com/logging/docs/view/advanced-queries#indexed-fields) for details.
    /// For example: jsonPayload.request.status
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a google_logging_organization_bucket_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleLoggingOrganizationBucketConfig : TerraformResource
{
    public GoogleLoggingOrganizationBucketConfig(string name) : base("google_logging_organization_bucket_config", name)
    {
    }

    /// <summary>
    /// The name of the logging bucket. Logging automatically creates two log buckets: _Required and _Default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketId is required")]
    [TerraformProperty("bucket_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketId { get; set; }

    /// <summary>
    /// An optional description for this bucket.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The parent resource that contains the logging bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// Logs will be retained by default for this amount of time, after which they will automatically be deleted. The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default time of 30 days will be used.
    /// </summary>
    [TerraformProperty("retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionDays { get; set; }

    /// <summary>
    /// Block for cmek_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CmekSettings block(s) allowed")]
    [TerraformProperty("cmek_settings")]
    public partial TerraformList<TerraformBlock<GoogleLoggingOrganizationBucketConfigCmekSettingsBlock>>? CmekSettings { get; set; }

    /// <summary>
    /// Block for index_configs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 IndexConfigs block(s) allowed")]
    [TerraformProperty("index_configs")]
    public partial TerraformSet<TerraformBlock<GoogleLoggingOrganizationBucketConfigIndexConfigsBlock>>? IndexConfigs { get; set; }

    /// <summary>
    /// The bucket&#39;s lifecycle such as active or deleted.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The resource name of the bucket
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
