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
        set => SetProperty("hidden_toolbar_items", value);
    }

    /// <summary>
    /// The max_display_resolution attribute.
    /// </summary>
    public TerraformProperty<string>? MaxDisplayResolution
    {
        set => SetProperty("max_display_resolution", value);
    }

    /// <summary>
    /// The toolbar_type attribute.
    /// </summary>
    public TerraformProperty<string>? ToolbarType
    {
        set => SetProperty("toolbar_type", value);
    }

    /// <summary>
    /// The visual_mode attribute.
    /// </summary>
    public TerraformProperty<string>? VisualMode
    {
        set => SetProperty("visual_mode", value);
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
        SetOutput("associated_portal_arns");
        SetOutput("tags_all");
        SetOutput("user_settings_arn");
        SetOutput("additional_encryption_context");
        SetOutput("copy_allowed");
        SetOutput("customer_managed_key");
        SetOutput("deep_link_allowed");
        SetOutput("disconnect_timeout_in_minutes");
        SetOutput("download_allowed");
        SetOutput("idle_disconnect_timeout_in_minutes");
        SetOutput("paste_allowed");
        SetOutput("print_allowed");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("upload_allowed");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalEncryptionContext
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_encryption_context");
        set => SetProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyAllowed is required")]
    public required TerraformProperty<string> CopyAllowed
    {
        get => GetRequiredOutput<TerraformProperty<string>>("copy_allowed");
        set => SetProperty("copy_allowed", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key");
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    public TerraformProperty<string> DeepLinkAllowed
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deep_link_allowed");
        set => SetProperty("deep_link_allowed", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> DisconnectTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disconnect_timeout_in_minutes");
        set => SetProperty("disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DownloadAllowed is required")]
    public required TerraformProperty<string> DownloadAllowed
    {
        get => GetRequiredOutput<TerraformProperty<string>>("download_allowed");
        set => SetProperty("download_allowed", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> IdleDisconnectTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_disconnect_timeout_in_minutes");
        set => SetProperty("idle_disconnect_timeout_in_minutes", value);
    }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasteAllowed is required")]
    public required TerraformProperty<string> PasteAllowed
    {
        get => GetRequiredOutput<TerraformProperty<string>>("paste_allowed");
        set => SetProperty("paste_allowed", value);
    }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrintAllowed is required")]
    public required TerraformProperty<string> PrintAllowed
    {
        get => GetRequiredOutput<TerraformProperty<string>>("print_allowed");
        set => SetProperty("print_allowed", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadAllowed is required")]
    public required TerraformProperty<string> UploadAllowed
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upload_allowed");
        set => SetProperty("upload_allowed", value);
    }

    /// <summary>
    /// Block for cookie_synchronization_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>? CookieSynchronizationConfiguration
    {
        set => SetProperty("cookie_synchronization_configuration", value);
    }

    /// <summary>
    /// Block for toolbar_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>? ToolbarConfiguration
    {
        set => SetProperty("toolbar_configuration", value);
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
