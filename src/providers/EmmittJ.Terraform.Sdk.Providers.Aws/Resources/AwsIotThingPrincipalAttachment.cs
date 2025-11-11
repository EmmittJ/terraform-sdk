using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing_principal_attachment resource.
/// </summary>
public class AwsIotThingPrincipalAttachment : TerraformResource
{
    public AwsIotThingPrincipalAttachment(string name) : base("aws_iot_thing_principal_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The thing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thing is required")]
    [TerraformPropertyName("thing")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Thing { get; set; }

    /// <summary>
    /// The thing_principal_type attribute.
    /// </summary>
    [TerraformPropertyName("thing_principal_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ThingPrincipalType { get; set; } = default!;

}
