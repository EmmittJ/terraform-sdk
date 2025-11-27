using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cmek_settings in GoogleLoggingFolderBucketConfig.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingFolderBucketConfigCmekSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cmek_settings";

    /// <summary>
    /// The resource name for the configured Cloud KMS key.
    /// KMS key name format:
    /// &amp;quot;projects/[PROJECT_ID]/locations/[LOCATION]/keyRings/[KEYRING]/cryptoKeys/[KEY]&amp;quot;
    /// To enable CMEK for the bucket, set this field to a valid kmsKeyName for which the associated service account has the required cloudkms.cryptoKeyEncrypterDecrypter roles assigned for the key.
    /// The Cloud KMS key used by the bucket can be updated by changing the kmsKeyName to a new valid key name. Encryption operations that are in progress will be completed with the key that was in use when they started. Decryption operations will be completed using the key that was used at the time of encryption unless access to that key has been revoked.
    /// See [Enabling CMEK for Logging Buckets](https://cloud.google.com/logging/docs/routing/managed-encryption-storage) for more information.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The CryptoKeyVersion resource name for the configured Cloud KMS key.
    /// KMS key name format:
    /// &amp;quot;projects/[PROJECT_ID]/locations/[LOCATION]/keyRings/[KEYRING]/cryptoKeys/[KEY]/cryptoKeyVersions/[VERSION]&amp;quot;
    /// For example:
    /// &amp;quot;projects/my-project/locations/us-central1/keyRings/my-ring/cryptoKeys/my-key/cryptoKeyVersions/1&amp;quot;
    /// This is a read-only field used to convey the specific configured CryptoKeyVersion of kms_key that has been configured. It will be populated in cases where the CMEK settings are bound to a single key version.
    /// </summary>
    public TerraformValue<string> KmsKeyVersionName
    {
        get => new TerraformReference<string>(this, "kms_key_version_name");
    }

    /// <summary>
    /// The resource name of the CMEK settings.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The service account associated with a project for which CMEK will apply.
    /// Before enabling CMEK for a logging bucket, you must first assign the cloudkms.cryptoKeyEncrypterDecrypter role to the service account associated with the project for which CMEK will apply. Use [v2.getCmekSettings](https://cloud.google.com/logging/docs/reference/v2/rest/v2/TopLevel/getCmekSettings#google.logging.v2.ConfigServiceV2.GetCmekSettings) to obtain the service account ID.
    /// See [Enabling CMEK for Logging Buckets](https://cloud.google.com/logging/docs/routing/managed-encryption-storage) for more information.
    /// </summary>
    public TerraformValue<string> ServiceAccountId
    {
        get => new TerraformReference<string>(this, "service_account_id");
    }

}


/// <summary>
/// Block type for index_configs in GoogleLoggingFolderBucketConfig.
/// Nesting mode: set
/// </summary>
public class GoogleLoggingFolderBucketConfigIndexConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "index_configs";

    /// <summary>
    /// The LogEntry field path to index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldPath is required")]
    public required TerraformValue<string> FieldPath
    {
        get => new TerraformReference<string>(this, "field_path");
        set => SetArgument("field_path", value);
    }

    /// <summary>
    /// The type of data in this index
    /// Note that some paths are automatically indexed, and other paths are not eligible for indexing. See [indexing documentation]( https://cloud.google.com/logging/docs/view/advanced-queries#indexed-fields) for details.
    /// For example: jsonPayload.request.status
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a google_logging_folder_bucket_config Terraform resource.
/// Manages a google_logging_folder_bucket_config resource.
/// </summary>
public partial class GoogleLoggingFolderBucketConfig(string name) : TerraformResource("google_logging_folder_bucket_config", name)
{
    /// <summary>
    /// The name of the logging bucket. Logging automatically creates two log buckets: _Required and _Default.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketId is required")]
    public required TerraformValue<string> BucketId
    {
        get => new TerraformReference<string>(this, "bucket_id");
        set => SetArgument("bucket_id", value);
    }

    /// <summary>
    /// An optional description for this bucket.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The parent resource that contains the logging bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformValue<string> Folder
    {
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Logs will be retained by default for this amount of time, after which they will automatically be deleted. The minimum retention period is 1 day. If this value is set to zero at bucket creation time, the default time of 30 days will be used.
    /// </summary>
    public TerraformValue<double>? RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The bucket&#39;s lifecycle such as active or deleted.
    /// </summary>
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The resource name of the bucket
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// CmekSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CmekSettings block(s) allowed")]
    public TerraformList<GoogleLoggingFolderBucketConfigCmekSettingsBlock>? CmekSettings
    {
        get => GetArgument<TerraformList<GoogleLoggingFolderBucketConfigCmekSettingsBlock>>("cmek_settings");
        set => SetArgument("cmek_settings", value);
    }

    /// <summary>
    /// IndexConfigs block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 IndexConfigs block(s) allowed")]
    public TerraformSet<GoogleLoggingFolderBucketConfigIndexConfigsBlock>? IndexConfigs
    {
        get => GetArgument<TerraformSet<GoogleLoggingFolderBucketConfigIndexConfigsBlock>>("index_configs");
        set => SetArgument("index_configs", value);
    }

}
