using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cmek_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingBillingAccountBucketConfigCmekSettingsBlock : TerraformBlock
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
    public required TerraformProperty<string> KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// The CryptoKeyVersion resource name for the configured Cloud KMS key.
    /// KMS key name format:
    /// &amp;quot;projects/[PROJECT_ID]/locations/[LOCATION]/keyRings/[KEYRING]/cryptoKeys/[KEY]/cryptoKeyVersions/[VERSION]&amp;quot;
    /// For example:
    /// &amp;quot;projects/my-project/locations/us-central1/keyRings/my-ring/cryptoKeys/my-key/cryptoKeyVersions/1&amp;quot;
    /// This is a read-only field used to convey the specific configured CryptoKeyVersion of kms_key that has been configured. It will be populated in cases where the CMEK settings are bound to a single key version.
    /// </summary>
    public TerraformProperty<string>? KmsKeyVersionName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_version_name");
        set => WithProperty("kms_key_version_name", value);
    }

    /// <summary>
    /// The resource name of the CMEK settings.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The service account associated with a project for which CMEK will apply.
    /// Before enabling CMEK for a logging bucket, you must first assign the cloudkms.cryptoKeyEncrypterDecrypter role to the service account associated with the project for which CMEK will apply. Use [v2.getCmekSettings](https://cloud.google.com/logging/docs/reference/v2/rest/v2/TopLevel/getCmekSettings#google.logging.v2.ConfigServiceV2.GetCmekSettings) to obtain the service account ID.
    /// See [Enabling CMEK for Logging Buckets](https://cloud.google.com/logging/docs/routing/managed-encryption-storage) for more information.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        get => GetProperty<TerraformProperty<string>>("service_account_id");
        set => WithProperty("service_account_id", value);
    }

}

/// <summary>
/// Block type for index_configs in .
/// Nesting mode: set
/// </summary>
public class GoogleLoggingBillingAccountBucketConfigIndexConfigsBlock : TerraformBlock
{
    /// <summary>
    /// The LogEntry field path to index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldPath is required")]
    public required TerraformProperty<string> FieldPath
    {
        get => GetProperty<TerraformProperty<string>>("field_path");
        set => WithProperty("field_path", value);
    }

    /// <summary>
    /// The type of data in this index
    /// Note that some paths are automatically indexed, and other paths are not eligible for indexing. See [indexing documentation]( https://cloud.google.com/logging/docs/view/advanced-queries#indexed-fields) for details.
    /// For example: jsonPayload.request.status
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a google_logging_billing_account_bucket_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLoggingBillingAccountBucketConfig : TerraformResource
{
    public GoogleLoggingBillingAccountBucketConfig(string name) : base("google_logging_billing_account_bucket_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The parent resource that contains the logging bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingAccount is required")]
    public required TerraformProperty<string> BillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// The name of the logging bucket. Logging automatically creates two log buckets: _Required and _Default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketId is required")]
    public required TerraformProperty<string> BucketId
    {
        get => GetProperty<TerraformProperty<string>>("bucket_id");
        set => this.WithProperty("bucket_id", value);
    }

    /// <summary>
    /// An optional description for this bucket.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Logs will be retained by default for this amount of time, after which they will automatically be deleted. The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default time of 30 days will be used.
    /// </summary>
    public TerraformProperty<double>? RetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_days");
        set => this.WithProperty("retention_days", value);
    }

    /// <summary>
    /// Block for cmek_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CmekSettings block(s) allowed")]
    public List<GoogleLoggingBillingAccountBucketConfigCmekSettingsBlock>? CmekSettings
    {
        get => GetProperty<List<GoogleLoggingBillingAccountBucketConfigCmekSettingsBlock>>("cmek_settings");
        set => this.WithProperty("cmek_settings", value);
    }

    /// <summary>
    /// Block for index_configs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 IndexConfigs block(s) allowed")]
    public HashSet<GoogleLoggingBillingAccountBucketConfigIndexConfigsBlock>? IndexConfigs
    {
        get => GetProperty<HashSet<GoogleLoggingBillingAccountBucketConfigIndexConfigsBlock>>("index_configs");
        set => this.WithProperty("index_configs", value);
    }

    /// <summary>
    /// The bucket&#39;s lifecycle such as active or deleted.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The resource name of the bucket
    /// </summary>
    public TerraformExpression Name => this["name"];

}
