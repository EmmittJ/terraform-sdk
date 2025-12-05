using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleLoggingOrganizationSettings.
/// Nesting mode: single
/// </summary>
public class GoogleLoggingOrganizationSettingsTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_logging_organization_settings Terraform resource.
/// Manages a google_logging_organization_settings resource.
/// </summary>
public partial class GoogleLoggingOrganizationSettings(string name) : TerraformResource("google_logging_organization_settings", name)
{
    /// <summary>
    /// If set to true, the _Default sink in newly created projects and folders will created in a disabled state. This can be used to automatically disable log storage if there is already an aggregated sink configured in the hierarchy. The _Default sink can be re-enabled manually if needed.
    /// </summary>
    public TerraformValue<bool> DisableDefaultSink
    {
        get => GetArgument<TerraformValue<bool>>("disable_default_sink") ?? CreateReference("disable_default_sink");
        set => SetArgument("disable_default_sink", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name for the configured Cloud KMS key.
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name") ?? CreateReference("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The organization for which to retrieve or configure settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => GetRequiredArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The storage location that Cloud Logging will use to create new resources when a location is needed but not explicitly provided.
    /// </summary>
    public TerraformValue<string> StorageLocation
    {
        get => GetArgument<TerraformValue<string>>("storage_location") ?? CreateReference("storage_location");
        set => SetArgument("storage_location", value);
    }

    /// <summary>
    /// The service account that will be used by the Log Router to access your Cloud KMS key.
    /// </summary>
    public TerraformValue<string> KmsServiceAccountId
        => CreateReference("kms_service_account_id");

    /// <summary>
    /// The service account for the given container. Sinks use this service account as their writerIdentity if no custom service account is provided.
    /// </summary>
    public TerraformValue<string> LoggingServiceAccountId
        => CreateReference("logging_service_account_id");

    /// <summary>
    /// The resource name of the settings.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleLoggingOrganizationSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleLoggingOrganizationSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
