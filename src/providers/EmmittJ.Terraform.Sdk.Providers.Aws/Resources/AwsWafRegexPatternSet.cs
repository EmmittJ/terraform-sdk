using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_waf_regex_pattern_set resource.
/// </summary>
public partial class AwsWafRegexPatternSet : TerraformResource
{
    public AwsWafRegexPatternSet(string name) : base("aws_waf_regex_pattern_set", name)
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
    /// The regex_pattern_strings attribute.
    /// </summary>
    [TerraformProperty("regex_pattern_strings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RegexPatternStrings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
