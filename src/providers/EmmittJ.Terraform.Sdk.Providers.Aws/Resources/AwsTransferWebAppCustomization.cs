using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_web_app_customization resource.
/// </summary>
public partial class AwsTransferWebAppCustomization : TerraformResource
{
    public AwsTransferWebAppCustomization(string name) : base("aws_transfer_web_app_customization", name)
    {
    }

    /// <summary>
    /// The favicon_file attribute.
    /// </summary>
    [TerraformProperty("favicon_file")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FaviconFile { get; set; }

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    [TerraformProperty("logo_file")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LogoFile { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    [TerraformProperty("web_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WebAppId { get; set; }

}
