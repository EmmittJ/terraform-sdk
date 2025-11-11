using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regex_match_tuple in .
/// Nesting mode: set
/// </summary>
public class AwsWafRegexMatchSetRegexMatchTupleBlock
{
    /// <summary>
    /// The regex_pattern_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexPatternSetId is required")]
    [TerraformPropertyName("regex_pattern_set_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegexPatternSetId { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformPropertyName("text_transformation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_regex_match_set resource.
/// </summary>
public class AwsWafRegexMatchSet : TerraformResource
{
    public AwsWafRegexMatchSet(string name) : base("aws_waf_regex_match_set", name)
    {
    }

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
    /// Block for regex_match_tuple.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("regex_match_tuple")]
    public TerraformSet<TerraformBlock<AwsWafRegexMatchSetRegexMatchTupleBlock>>? RegexMatchTuple { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
