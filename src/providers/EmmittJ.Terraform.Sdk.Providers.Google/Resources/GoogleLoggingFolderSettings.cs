using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleLoggingFolderSettings.
/// Nesting mode: single
/// </summary>
public class GoogleLoggingFolderSettingsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_logging_folder_settings Terraform resource.
/// Manages a google_logging_folder_settings resource.
/// </summary>
public partial class GoogleLoggingFolderSettings(string name) : TerraformResource("google_logging_folder_settings", name)
{
    /// <summary>
    /// If set to true, the _Default sink in newly created projects and folders will created in a disabled state. This can be used to automatically disable log storage if there is already an aggregated sink configured in the hierarchy. The _Default sink can be re-enabled manually if needed.
    /// </summary>
    public TerraformValue<bool> DisableDefaultSink
    {
        get => new TerraformReference<bool>(this, "disable_default_sink");
        set => SetArgument("disable_default_sink", value);
    }

    /// <summary>
    /// The folder for which to retrieve settings.
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
    /// The resource name for the configured Cloud KMS key.
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The storage location that Cloud Logging will use to create new resources when a location is needed but not explicitly provided.
    /// </summary>
    public TerraformValue<string> StorageLocation
    {
        get => new TerraformReference<string>(this, "storage_location");
        set => SetArgument("storage_location", value);
    }

    /// <summary>
    /// The service account that will be used by the Log Router to access your Cloud KMS key.
    /// </summary>
    public TerraformValue<string> KmsServiceAccountId
    {
        get => new TerraformReference<string>(this, "kms_service_account_id");
    }

    /// <summary>
    /// The service account for the given container. Sinks use this service account as their writerIdentity if no custom service account is provided.
    /// </summary>
    public TerraformValue<string> LoggingServiceAccountId
    {
        get => new TerraformReference<string>(this, "logging_service_account_id");
    }

    /// <summary>
    /// The resource name of the settings.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleLoggingFolderSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleLoggingFolderSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
