using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookie_synchronization_configuration in AwsWorkspaceswebUserSettings.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cookie_synchronization_configuration";

    /// <summary>
    /// Allowlist block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlockAllowlistBlock>? Allowlist
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlockAllowlistBlock>>("allowlist");
        set => SetArgument("allowlist", value);
    }

    /// <summary>
    /// Blocklist block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlockBlocklistBlock>? Blocklist
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlockBlocklistBlock>>("blocklist");
        set => SetArgument("blocklist", value);
    }

}

/// <summary>
/// Block type for allowlist in AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlockAllowlistBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowlist";

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for blocklist in AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlockBlocklistBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blocklist";

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for toolbar_configuration in AwsWorkspaceswebUserSettings.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsToolbarConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "toolbar_configuration";

    /// <summary>
    /// The hidden_toolbar_items attribute.
    /// </summary>
    public TerraformList<string>? HiddenToolbarItems
    {
        get => GetArgument<TerraformList<string>>("hidden_toolbar_items");
        set => SetArgument("hidden_toolbar_items", value);
    }

    /// <summary>
    /// The max_display_resolution attribute.
    /// </summary>
    public TerraformValue<string>? MaxDisplayResolution
    {
        get => GetArgument<TerraformValue<string>>("max_display_resolution");
        set => SetArgument("max_display_resolution", value);
    }

    /// <summary>
    /// The toolbar_type attribute.
    /// </summary>
    public TerraformValue<string>? ToolbarType
    {
        get => GetArgument<TerraformValue<string>>("toolbar_type");
        set => SetArgument("toolbar_type", value);
    }

    /// <summary>
    /// The visual_mode attribute.
    /// </summary>
    public TerraformValue<string>? VisualMode
    {
        get => GetArgument<TerraformValue<string>>("visual_mode");
        set => SetArgument("visual_mode", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_user_settings Terraform resource.
/// Manages a aws_workspacesweb_user_settings resource.
/// </summary>
public partial class AwsWorkspaceswebUserSettings(string name) : TerraformResource("aws_workspacesweb_user_settings", name)
{
    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalEncryptionContext
    {
        get => GetArgument<TerraformMap<string>>("additional_encryption_context");
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyAllowed is required")]
    public required TerraformValue<string> CopyAllowed
    {
        get => GetArgument<TerraformValue<string>>("copy_allowed");
        set => SetArgument("copy_allowed", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    public TerraformValue<string>? DeepLinkAllowed
    {
        get => GetArgument<TerraformValue<string>>("deep_link_allowed");
        set => SetArgument("deep_link_allowed", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? DisconnectTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("disconnect_timeout_in_minutes");
        set => SetArgument("disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DownloadAllowed is required")]
    public required TerraformValue<string> DownloadAllowed
    {
        get => GetArgument<TerraformValue<string>>("download_allowed");
        set => SetArgument("download_allowed", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleDisconnectTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_disconnect_timeout_in_minutes");
        set => SetArgument("idle_disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasteAllowed is required")]
    public required TerraformValue<string> PasteAllowed
    {
        get => GetArgument<TerraformValue<string>>("paste_allowed");
        set => SetArgument("paste_allowed", value);
    }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrintAllowed is required")]
    public required TerraformValue<string> PrintAllowed
    {
        get => GetArgument<TerraformValue<string>>("print_allowed");
        set => SetArgument("print_allowed", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadAllowed is required")]
    public required TerraformValue<string> UploadAllowed
    {
        get => GetArgument<TerraformValue<string>>("upload_allowed");
        set => SetArgument("upload_allowed", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
        => AsReference("associated_portal_arns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserSettingsArn
        => AsReference("user_settings_arn");

    /// <summary>
    /// CookieSynchronizationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>? CookieSynchronizationConfiguration
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>>("cookie_synchronization_configuration");
        set => SetArgument("cookie_synchronization_configuration", value);
    }

    /// <summary>
    /// ToolbarConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>? ToolbarConfiguration
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>>("toolbar_configuration");
        set => SetArgument("toolbar_configuration", value);
    }

}
