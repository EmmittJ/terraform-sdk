using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_redaction_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock() : TerraformBlock("inline_redaction_configuration")
{
    /// <summary>
    /// The global_confidence_level attribute.
    /// </summary>
    [TerraformProperty("global_confidence_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? GlobalConfidenceLevel { get; set; }

    /// <summary>
    /// The global_enforced_urls attribute.
    /// </summary>
    [TerraformProperty("global_enforced_urls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GlobalEnforcedUrls { get; set; }

    /// <summary>
    /// The global_exempt_urls attribute.
    /// </summary>
    [TerraformProperty("global_exempt_urls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GlobalExemptUrls { get; set; }

}

/// <summary>
/// Manages a aws_workspacesweb_data_protection_settings resource.
/// </summary>
public partial class AwsWorkspaceswebDataProtectionSettings : TerraformResource
{
    public AwsWorkspaceswebDataProtectionSettings(string name) : base("aws_workspacesweb_data_protection_settings", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformProperty("additional_encryption_context")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for inline_redaction_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("inline_redaction_configuration")]
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock> InlineRedactionConfiguration { get; set; } = new();

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformProperty("associated_portal_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AssociatedPortalArns { get; }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [TerraformProperty("data_protection_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataProtectionSettingsArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
