using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_activation resource.
/// </summary>
public class AwsSsmActivation : TerraformResource
{
    public AwsSsmActivation(string name) : base("aws_ssm_activation", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExpirationDate { get; set; } = default!;

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    [TerraformPropertyName("iam_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IamRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The registration_limit attribute.
    /// </summary>
    [TerraformPropertyName("registration_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RegistrationLimit { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The activation_code attribute.
    /// </summary>
    [TerraformPropertyName("activation_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ActivationCode => new TerraformReference(this, "activation_code");

    /// <summary>
    /// The expired attribute.
    /// </summary>
    [TerraformPropertyName("expired")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Expired => new TerraformReference(this, "expired");

    /// <summary>
    /// The registration_count attribute.
    /// </summary>
    [TerraformPropertyName("registration_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RegistrationCount => new TerraformReference(this, "registration_count");

}
