using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookie_synchronization_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for toolbar_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspaceswebUserSettingsToolbarConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The hidden_toolbar_items attribute.
    /// </summary>
    [TerraformProperty("hidden_toolbar_items")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? HiddenToolbarItems { get; set; }

    /// <summary>
    /// The max_display_resolution attribute.
    /// </summary>
    [TerraformProperty("max_display_resolution")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxDisplayResolution { get; set; }

    /// <summary>
    /// The toolbar_type attribute.
    /// </summary>
    [TerraformProperty("toolbar_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ToolbarType { get; set; }

    /// <summary>
    /// The visual_mode attribute.
    /// </summary>
    [TerraformProperty("visual_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VisualMode { get; set; }

}

/// <summary>
/// Manages a aws_workspacesweb_user_settings resource.
/// </summary>
public partial class AwsWorkspaceswebUserSettings : TerraformResource
{
    public AwsWorkspaceswebUserSettings(string name) : base("aws_workspacesweb_user_settings", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformProperty("additional_encryption_context")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyAllowed is required")]
    [TerraformProperty("copy_allowed")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CopyAllowed { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    [TerraformProperty("deep_link_allowed")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DeepLinkAllowed { get; set; }

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("disconnect_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DisconnectTimeoutInMinutes { get; set; }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DownloadAllowed is required")]
    [TerraformProperty("download_allowed")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DownloadAllowed { get; set; }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_disconnect_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? IdleDisconnectTimeoutInMinutes { get; set; }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasteAllowed is required")]
    [TerraformProperty("paste_allowed")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PasteAllowed { get; set; }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrintAllowed is required")]
    [TerraformProperty("print_allowed")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrintAllowed { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadAllowed is required")]
    [TerraformProperty("upload_allowed")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UploadAllowed { get; set; }

    /// <summary>
    /// Block for cookie_synchronization_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cookie_synchronization_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>>? CookieSynchronizationConfiguration { get; set; }

    /// <summary>
    /// Block for toolbar_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("toolbar_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>>? ToolbarConfiguration { get; set; }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformProperty("associated_portal_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AssociatedPortalArns { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    [TerraformProperty("user_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserSettingsArn { get; }

}
