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
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
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
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "hidden_toolbar_items").ResolveNodes(ctx));
        set => SetArgument("hidden_toolbar_items", value);
    }

    /// <summary>
    /// The max_display_resolution attribute.
    /// </summary>
    public TerraformValue<string>? MaxDisplayResolution
    {
        get => new TerraformReference<string>(this, "max_display_resolution");
        set => SetArgument("max_display_resolution", value);
    }

    /// <summary>
    /// The toolbar_type attribute.
    /// </summary>
    public TerraformValue<string>? ToolbarType
    {
        get => new TerraformReference<string>(this, "toolbar_type");
        set => SetArgument("toolbar_type", value);
    }

    /// <summary>
    /// The visual_mode attribute.
    /// </summary>
    public TerraformValue<string>? VisualMode
    {
        get => new TerraformReference<string>(this, "visual_mode");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_encryption_context").ResolveNodes(ctx));
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyAllowed is required")]
    public required TerraformValue<string> CopyAllowed
    {
        get => new TerraformReference<string>(this, "copy_allowed");
        set => SetArgument("copy_allowed", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => new TerraformReference<string>(this, "customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    public TerraformValue<string> DeepLinkAllowed
    {
        get => new TerraformReference<string>(this, "deep_link_allowed");
        set => SetArgument("deep_link_allowed", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? DisconnectTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "disconnect_timeout_in_minutes");
        set => SetArgument("disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DownloadAllowed is required")]
    public required TerraformValue<string> DownloadAllowed
    {
        get => new TerraformReference<string>(this, "download_allowed");
        set => SetArgument("download_allowed", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleDisconnectTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_disconnect_timeout_in_minutes");
        set => SetArgument("idle_disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasteAllowed is required")]
    public required TerraformValue<string> PasteAllowed
    {
        get => new TerraformReference<string>(this, "paste_allowed");
        set => SetArgument("paste_allowed", value);
    }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrintAllowed is required")]
    public required TerraformValue<string> PrintAllowed
    {
        get => new TerraformReference<string>(this, "print_allowed");
        set => SetArgument("print_allowed", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadAllowed is required")]
    public required TerraformValue<string> UploadAllowed
    {
        get => new TerraformReference<string>(this, "upload_allowed");
        set => SetArgument("upload_allowed", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "associated_portal_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserSettingsArn
    {
        get => new TerraformReference<string>(this, "user_settings_arn");
    }

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
