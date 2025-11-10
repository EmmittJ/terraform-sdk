using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookie_synchronization_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for toolbar_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebUserSettingsToolbarConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The hidden_toolbar_items attribute.
    /// </summary>
    [TerraformPropertyName("hidden_toolbar_items")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? HiddenToolbarItems { get; set; }

    /// <summary>
    /// The max_display_resolution attribute.
    /// </summary>
    [TerraformPropertyName("max_display_resolution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxDisplayResolution { get; set; }

    /// <summary>
    /// The toolbar_type attribute.
    /// </summary>
    [TerraformPropertyName("toolbar_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ToolbarType { get; set; }

    /// <summary>
    /// The visual_mode attribute.
    /// </summary>
    [TerraformPropertyName("visual_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VisualMode { get; set; }

}

/// <summary>
/// Manages a aws_workspacesweb_user_settings resource.
/// </summary>
public class AwsWorkspaceswebUserSettings : TerraformResource
{
    public AwsWorkspaceswebUserSettings(string name) : base("aws_workspacesweb_user_settings", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformPropertyName("additional_encryption_context")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The copy_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyAllowed is required")]
    [TerraformPropertyName("copy_allowed")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CopyAllowed { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The deep_link_allowed attribute.
    /// </summary>
    [TerraformPropertyName("deep_link_allowed")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeepLinkAllowed { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deep_link_allowed");

    /// <summary>
    /// The disconnect_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("disconnect_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DisconnectTimeoutInMinutes { get; set; }

    /// <summary>
    /// The download_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DownloadAllowed is required")]
    [TerraformPropertyName("download_allowed")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DownloadAllowed { get; set; }

    /// <summary>
    /// The idle_disconnect_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_disconnect_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IdleDisconnectTimeoutInMinutes { get; set; }

    /// <summary>
    /// The paste_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasteAllowed is required")]
    [TerraformPropertyName("paste_allowed")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PasteAllowed { get; set; }

    /// <summary>
    /// The print_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrintAllowed is required")]
    [TerraformPropertyName("print_allowed")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrintAllowed { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The upload_allowed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadAllowed is required")]
    [TerraformPropertyName("upload_allowed")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UploadAllowed { get; set; }

    /// <summary>
    /// Block for cookie_synchronization_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cookie_synchronization_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebUserSettingsCookieSynchronizationConfigurationBlock>>? CookieSynchronizationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for toolbar_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("toolbar_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebUserSettingsToolbarConfigurationBlock>>? ToolbarConfiguration { get; set; } = new();

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformPropertyName("associated_portal_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssociatedPortalArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "associated_portal_arns");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("user_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_settings_arn");

}
