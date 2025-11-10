using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLoggingFolderSettingsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_logging_folder_settings resource.
/// </summary>
public class GoogleLoggingFolderSettings : TerraformResource
{
    public GoogleLoggingFolderSettings(string name) : base("google_logging_folder_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("kms_service_account_id");
        this.DeclareOutput("logging_service_account_id");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// If set to true, the _Default sink in newly created projects and folders will created in a disabled state. This can be used to automatically disable log storage if there is already an aggregated sink configured in the hierarchy. The _Default sink can be re-enabled manually if needed.
    /// </summary>
    public TerraformProperty<bool>? DisableDefaultSink
    {
        get => GetProperty<TerraformProperty<bool>>("disable_default_sink");
        set => this.WithProperty("disable_default_sink", value);
    }

    /// <summary>
    /// The folder for which to retrieve settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// The resource name for the configured Cloud KMS key.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// The storage location that Cloud Logging will use to create new resources when a location is needed but not explicitly provided.
    /// </summary>
    public TerraformProperty<string>? StorageLocation
    {
        get => GetProperty<TerraformProperty<string>>("storage_location");
        set => this.WithProperty("storage_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleLoggingFolderSettingsTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleLoggingFolderSettingsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The service account that will be used by the Log Router to access your Cloud KMS key.
    /// </summary>
    public TerraformExpression KmsServiceAccountId => this["kms_service_account_id"];

    /// <summary>
    /// The service account for the given container. Sinks use this service account as their writerIdentity if no custom service account is provided.
    /// </summary>
    public TerraformExpression LoggingServiceAccountId => this["logging_service_account_id"];

    /// <summary>
    /// The resource name of the settings.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
