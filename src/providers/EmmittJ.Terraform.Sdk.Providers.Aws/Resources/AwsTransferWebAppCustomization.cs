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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FaviconFile { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "favicon_file");

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    [TerraformPropertyName("logo_file")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogoFile { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logo_file");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Title { get; set; }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    [TerraformPropertyName("web_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebAppId { get; set; }

}
