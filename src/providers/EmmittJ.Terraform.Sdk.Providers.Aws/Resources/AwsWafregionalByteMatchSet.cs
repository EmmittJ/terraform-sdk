using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafregionalByteMatchSetByteMatchTuplesBlock : TerraformBlockBase
{
    /// <summary>
    /// The positional_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PositionalConstraint is required")]
    [TerraformProperty("positional_constraint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PositionalConstraint { get; set; }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    [TerraformProperty("target_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetString { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformProperty("text_transformation")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_wafregional_byte_match_set resource.
/// </summary>
public partial class AwsWafregionalByteMatchSet : TerraformResource
{
    public AwsWafregionalByteMatchSet(string name) : base("aws_wafregional_byte_match_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for byte_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("byte_match_tuples")]
    public TerraformSet<TerraformBlock<AwsWafregionalByteMatchSetByteMatchTuplesBlock>>? ByteMatchTuples { get; set; }

}
