using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regex_match_tuple in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalRegexMatchSetRegexMatchTupleBlock : ITerraformBlock
{
    /// <summary>
    /// The regex_pattern_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexPatternSetId is required")]
    [TerraformPropertyName("regex_pattern_set_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RegexPatternSetId { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformPropertyName("text_transformation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_wafregional_regex_match_set resource.
/// </summary>
public class AwsWafregionalRegexMatchSet : TerraformResource
{
    public AwsWafregionalRegexMatchSet(string name) : base("aws_wafregional_regex_match_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for regex_match_tuple.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("regex_match_tuple")]
    public TerraformSet<TerraformBlock<AwsWafregionalRegexMatchSetRegexMatchTupleBlock>>? RegexMatchTuple { get; set; } = new();

}
