using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for xss_match_tuples in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafXssMatchSetXssMatchTuplesBlock : TerraformBlockBase
{
    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformProperty("text_transformation")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_xss_match_set resource.
/// </summary>
public partial class AwsWafXssMatchSet : TerraformResource
{
    public AwsWafXssMatchSet(string name) : base("aws_waf_xss_match_set", name)
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
    /// Block for xss_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("xss_match_tuples")]
    public TerraformSet<TerraformBlock<AwsWafXssMatchSetXssMatchTuplesBlock>>? XssMatchTuples { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
