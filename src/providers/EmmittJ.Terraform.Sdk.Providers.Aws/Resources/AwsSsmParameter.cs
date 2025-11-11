using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_parameter resource.
/// </summary>
public partial class AwsSsmParameter : TerraformResource
{
    public AwsSsmParameter(string name) : base("aws_ssm_parameter", name)
    {
    }

    /// <summary>
    /// The allowed_pattern attribute.
    /// </summary>
    [TerraformProperty("allowed_pattern")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllowedPattern { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The data_type attribute.
    /// </summary>
    [TerraformProperty("data_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DataType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The insecure_value attribute.
    /// </summary>
    [TerraformProperty("insecure_value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InsecureValue { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [TerraformProperty("key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The overwrite attribute.
    /// </summary>
    [TerraformProperty("overwrite")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Overwrite { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Value { get; set; }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    [TerraformProperty("value_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValueWo { get; set; }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    [TerraformProperty("value_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ValueWoVersion { get; set; }

    /// <summary>
    /// The has_value_wo attribute.
    /// </summary>
    [TerraformProperty("has_value_wo")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HasValueWo { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Version { get; }

}
