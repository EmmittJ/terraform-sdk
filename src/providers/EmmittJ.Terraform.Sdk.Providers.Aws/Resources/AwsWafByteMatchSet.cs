using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafByteMatchSetByteMatchTuplesBlock : TerraformBlockBase
{
    /// <summary>
    /// The positional_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PositionalConstraint is required")]
    [TerraformProperty("positional_constraint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PositionalConstraint { get; set; }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    [TerraformProperty("target_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetString { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformProperty("text_transformation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_byte_match_set resource.
/// </summary>
public partial class AwsWafByteMatchSet : TerraformResource
{
    public AwsWafByteMatchSet(string name) : base("aws_waf_byte_match_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for byte_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("byte_match_tuples")]
    public partial TerraformSet<TerraformBlock<AwsWafByteMatchSetByteMatchTuplesBlock>>? ByteMatchTuples { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
