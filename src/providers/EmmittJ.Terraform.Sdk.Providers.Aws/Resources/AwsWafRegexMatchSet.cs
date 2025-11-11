using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regex_match_tuple in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafRegexMatchSetRegexMatchTupleBlock : TerraformBlockBase
{
    /// <summary>
    /// The regex_pattern_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexPatternSetId is required")]
    [TerraformProperty("regex_pattern_set_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RegexPatternSetId { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformProperty("text_transformation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_regex_match_set resource.
/// </summary>
public partial class AwsWafRegexMatchSet : TerraformResource
{
    public AwsWafRegexMatchSet(string name) : base("aws_waf_regex_match_set", name)
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
    /// Block for regex_match_tuple.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("regex_match_tuple")]
    public partial TerraformSet<TerraformBlock<AwsWafRegexMatchSetRegexMatchTupleBlock>>? RegexMatchTuple { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
