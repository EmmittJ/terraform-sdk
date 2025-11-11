using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_pool_ui_customization resource.
/// </summary>
public class AwsCognitoUserPoolUiCustomization : TerraformResource
{
    public AwsCognitoUserPoolUiCustomization(string name) : base("aws_cognito_user_pool_ui_customization", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The css attribute.
    /// </summary>
    [TerraformPropertyName("css")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Css { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_file attribute.
    /// </summary>
    [TerraformPropertyName("image_file")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageFile { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The css_version attribute.
    /// </summary>
    [TerraformPropertyName("css_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CssVersion => new TerraformReference(this, "css_version");

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    [TerraformPropertyName("image_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageUrl => new TerraformReference(this, "image_url");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedDate => new TerraformReference(this, "last_modified_date");

}
