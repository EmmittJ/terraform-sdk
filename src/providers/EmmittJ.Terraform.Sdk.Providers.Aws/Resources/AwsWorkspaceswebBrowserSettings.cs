using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_browser_settings resource.
/// </summary>
public partial class AwsWorkspaceswebBrowserSettings : TerraformResource
{
    public AwsWorkspaceswebBrowserSettings(string name) : base("aws_workspacesweb_browser_settings", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformProperty("additional_encryption_context")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The browser_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrowserPolicy is required")]
    [TerraformProperty("browser_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BrowserPolicy { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomerManagedKey { get; set; }

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
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformProperty("associated_portal_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AssociatedPortalArns { get; }

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    [TerraformProperty("browser_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BrowserSettingsArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
