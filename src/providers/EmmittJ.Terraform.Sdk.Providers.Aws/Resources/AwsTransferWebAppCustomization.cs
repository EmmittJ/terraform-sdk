using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_web_app_customization resource.
/// </summary>
public class AwsTransferWebAppCustomization : TerraformResource
{
    public AwsTransferWebAppCustomization(string name) : base("aws_transfer_web_app_customization", name)
    {
    }

    /// <summary>
    /// The favicon_file attribute.
    /// </summary>
    [TerraformPropertyName("favicon_file")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FaviconFile { get; set; } = default!;

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    [TerraformPropertyName("logo_file")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LogoFile { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    [TerraformPropertyName("web_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WebAppId { get; set; }

}
