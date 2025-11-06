using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_logging_project_settings.
/// </summary>
public class GoogleLoggingProjectSettingsDataSource : TerraformDataSource
{
    public GoogleLoggingProjectSettingsDataSource(string name) : base("google_logging_project_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("disable_default_sink");
        this.DeclareOutput("kms_key_name");
        this.DeclareOutput("kms_service_account_id");
        this.DeclareOutput("logging_service_account_id");
        this.DeclareOutput("name");
        this.DeclareOutput("storage_location");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project for which to retrieve settings.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to true, the _Default sink in newly created projects and folders will created in a disabled state. This can be used to automatically disable log storage if there is already an aggregated sink configured in the hierarchy. The _Default sink can be re-enabled manually if needed.
    /// </summary>
    public TerraformExpression DisableDefaultSink => this["disable_default_sink"];

    /// <summary>
    /// The resource name for the configured Cloud KMS key.
    /// 				KMS key name format:
    /// 				&amp;quot;projects/[PROJECT_ID]/locations/[LOCATION]/keyRings/[KEYRING]/cryptoKeys/[KEY]&amp;quot;
    /// 				To enable CMEK for the bucket, set this field to a valid kmsKeyName for which the associated service account has the required cloudkms.cryptoKeyEncrypterDecrypter roles assigned for the key.
    /// 				The Cloud KMS key used by the bucket can be updated by changing the kmsKeyName to a new valid key name. Encryption operations that are in progress will be completed with the key that was in use when they started. Decryption operations will be completed using the key that was used at the time of encryption unless access to that key has been revoked.
    /// 				See [Enabling CMEK for Logging Buckets](https://cloud.google.com/logging/docs/routing/managed-encryption-storage) for more information.
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

    /// <summary>
    /// The service account associated with a project for which CMEK will apply.
    /// 				Before enabling CMEK for a logging bucket, you must first assign the cloudkms.cryptoKeyEncrypterDecrypter role to the service account associated with the project for which CMEK will apply. Use [v2.getCmekSettings](https://cloud.google.com/logging/docs/reference/v2/rest/v2/TopLevel/getCmekSettings#google.logging.v2.ConfigServiceV2.GetCmekSettings) to obtain the service account ID.
    /// 				See [Enabling CMEK for Logging Buckets](https://cloud.google.com/logging/docs/routing/managed-encryption-storage) for more information.
    /// </summary>
    public TerraformExpression KmsServiceAccountId => this["kms_service_account_id"];

    /// <summary>
    /// The service account for the given container. Sinks use this service account as their writerIdentity if no custom service account is provided.
    /// </summary>
    public TerraformExpression LoggingServiceAccountId => this["logging_service_account_id"];

    /// <summary>
    /// The resource name of the CMEK settings.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The storage location that Cloud Logging will use to create new resources when a location is needed but not explicitly provided.
    /// </summary>
    public TerraformExpression StorageLocation => this["storage_location"];

}
