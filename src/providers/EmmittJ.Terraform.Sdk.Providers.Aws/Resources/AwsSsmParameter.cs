using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_parameter resource.
/// </summary>
public class AwsSsmParameter : TerraformResource
{
    public AwsSsmParameter(string name) : base("aws_ssm_parameter", name)
    {
    }

    /// <summary>
    /// The allowed_pattern attribute.
    /// </summary>
    [TerraformPropertyName("allowed_pattern")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AllowedPattern { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    [TerraformPropertyName("data_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DataType { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The insecure_value attribute.
    /// </summary>
    [TerraformPropertyName("insecure_value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InsecureValue { get; set; } = default!;

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyId { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The overwrite attribute.
    /// </summary>
    [TerraformPropertyName("overwrite")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Overwrite { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

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
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Tier { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Value { get; set; } = default!;

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    [TerraformPropertyName("value_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ValueWo { get; set; }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("value_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ValueWoVersion { get; set; }

    /// <summary>
    /// The has_value_wo attribute.
    /// </summary>
    [TerraformPropertyName("has_value_wo")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasValueWo => new TerraformReference(this, "has_value_wo");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Version => new TerraformReference(this, "version");

}
