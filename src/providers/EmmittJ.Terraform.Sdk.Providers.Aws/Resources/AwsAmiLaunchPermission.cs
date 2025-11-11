using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ami_launch_permission resource.
/// </summary>
public class AwsAmiLaunchPermission : TerraformResource
{
    public AwsAmiLaunchPermission(string name) : base("aws_ami_launch_permission", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    [TerraformPropertyName("image_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImageId { get; set; }

    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    [TerraformPropertyName("organization_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrganizationArn { get; set; }

    /// <summary>
    /// The organizational_unit_arn attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrganizationalUnitArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

}
