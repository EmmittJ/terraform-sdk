using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_pool_ui_customization resource.
/// </summary>
public partial class AwsCognitoUserPoolUiCustomization : TerraformResource
{
    public AwsCognitoUserPoolUiCustomization(string name) : base("aws_cognito_user_pool_ui_customization", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The css attribute.
    /// </summary>
    [TerraformProperty("css")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Css { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_file attribute.
    /// </summary>
    [TerraformProperty("image_file")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageFile { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The css_version attribute.
    /// </summary>
    [TerraformProperty("css_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CssVersion { get; }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    [TerraformProperty("image_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageUrl { get; }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedDate { get; }

}
