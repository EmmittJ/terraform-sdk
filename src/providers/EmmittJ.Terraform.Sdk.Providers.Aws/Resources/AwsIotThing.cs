using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing resource.
/// </summary>
public class AwsIotThing : TerraformResource
{
    public AwsIotThing(string name) : base("aws_iot_thing", name)
    {
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformPropertyName("attributes")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Attributes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The thing_type_name attribute.
    /// </summary>
    [TerraformPropertyName("thing_type_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ThingTypeName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_client_id attribute.
    /// </summary>
    [TerraformPropertyName("default_client_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultClientId => new TerraformReference(this, "default_client_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Version => new TerraformReference(this, "version");

}
