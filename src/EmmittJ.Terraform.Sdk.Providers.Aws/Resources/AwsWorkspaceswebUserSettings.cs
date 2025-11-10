using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookie_synchronization_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for toolbar_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsToolbarConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The hidden_toolbar_items attribute.
    /// </summary>
    public List<TerraformProperty<string>>? HiddenToolbarItems
    {
        get => GetProperty<List<TerraformProperty<string>>>("hidden_toolbar_items");
        set => WithProperty("hidden_toolbar_items", value);
    }

    /// <summary>
    /// The max_display_resolution attribute.
    /// </summary>
    public TerraformProperty<string>? MaxDisplayResolution
    {
        get => GetProperty<TerraformProperty<string>>("max_display_resolution");
        set => WithProperty("max_display_resolution", value);
    }

    /// <summary>
    /// The toolbar_type attribute.
    /// </summary>
    public TerraformProperty<string>? ToolbarType
    {
        get => GetProperty<TerraformProperty<string>>("toolbar_type");
        set => WithProperty("toolbar_type", value);
    }

    /// <summary>
    /// The visual_mode attribute.
    /// </summary>
    public TerraformProperty<string>? VisualMode
    {
        get => GetProperty<TerraformProperty<string>>("visual_mode");
        set => WithProperty("visual_mode", value);
    }

}

/// <summary>
/// Manages a aws_workspacesweb_user_settings resource.
/// </summary>
public class AwsWorkspaceswebUserSettings : TerraformResource
{
    public AwsWorkspaceswebUserSettings(string name) : base("aws_workspacesweb_user_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_portal_arns");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("user_settings_arn");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalEncryptionContext
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_encryption_context");
        set => this.WithProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyAllowed is required")]
    public required TerraformProperty<string> CopyAllowed
    {
        get => GetRequiredProperty<TerraformProperty<string>>("copy_allowed");
        set => this.WithProperty("copy_allowed", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKey
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    public TerraformProperty<string>? DeepLinkAllowed
    {
        get => GetProperty<TerraformProperty<string>>("deep_link_allowed");
        set => this.WithProperty("deep_link_allowed", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? DisconnectTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("disconnect_timeout_in_minutes");
        set => this.WithProperty("disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DownloadAllowed is required")]
    public required TerraformProperty<string> DownloadAllowed
    {
        get => GetRequiredProperty<TerraformProperty<string>>("download_allowed");
        set => this.WithProperty("download_allowed", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? IdleDisconnectTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("idle_disconnect_timeout_in_minutes");
        set => this.WithProperty("idle_disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasteAllowed is required")]
    public required TerraformProperty<string> PasteAllowed
    {
        get => GetRequiredProperty<TerraformProperty<string>>("paste_allowed");
        set => this.WithProperty("paste_allowed", value);
    }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrintAllowed is required")]
    public required TerraformProperty<string> PrintAllowed
    {
        get => GetRequiredProperty<TerraformProperty<string>>("print_allowed");
        set => this.WithProperty("print_allowed", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadAllowed is required")]
    public required TerraformProperty<string> UploadAllowed
    {
        get => GetRequiredProperty<TerraformProperty<string>>("upload_allowed");
        set => this.WithProperty("upload_allowed", value);
    }

    /// <summary>
    /// Block for cookie_synchronization_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>? CookieSynchronizationConfiguration
    {
        get => GetProperty<List<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>>("cookie_synchronization_configuration");
        set => this.WithProperty("cookie_synchronization_configuration", value);
    }

    /// <summary>
    /// Block for toolbar_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>? ToolbarConfiguration
    {
        get => GetProperty<List<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>>("toolbar_configuration");
        set => this.WithProperty("toolbar_configuration", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformExpression UserSettingsArn => this["user_settings_arn"];

}
