using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_redaction_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The global_confidence_level attribute.
    /// </summary>
    [TerraformPropertyName("global_confidence_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? GlobalConfidenceLevel { get; set; }

    /// <summary>
    /// The global_enforced_urls attribute.
    /// </summary>
    [TerraformPropertyName("global_enforced_urls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? GlobalEnforcedUrls { get; set; }

    /// <summary>
    /// The global_exempt_urls attribute.
    /// </summary>
    [TerraformPropertyName("global_exempt_urls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? GlobalExemptUrls { get; set; }

}

/// <summary>
/// Manages a aws_workspacesweb_data_protection_settings resource.
/// </summary>
public class AwsWorkspaceswebDataProtectionSettings : TerraformResource
{
    public AwsWorkspaceswebDataProtectionSettings(string name) : base("aws_workspacesweb_data_protection_settings", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformPropertyName("additional_encryption_context")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

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
    /// Block for inline_redaction_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("inline_redaction_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock>>? InlineRedactionConfiguration { get; set; } = new();

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformPropertyName("associated_portal_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssociatedPortalArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "associated_portal_arns");

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("data_protection_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataProtectionSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_protection_settings_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
