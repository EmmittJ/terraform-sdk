using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regular_expression in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafv2RegexPatternSetRegularExpressionBlock : TerraformBlockBase
{
    /// <summary>
    /// The regex_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexString is required")]
    [TerraformProperty("regex_string")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RegexString { get; set; }

}

/// <summary>
/// Manages a aws_wafv2_regex_pattern_set resource.
/// </summary>
public partial class AwsWafv2RegexPatternSet : TerraformResource
{
    public AwsWafv2RegexPatternSet(string name) : base("aws_wafv2_regex_pattern_set", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for regular_expression.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("regular_expression")]
    public TerraformSet<TerraformBlock<AwsWafv2RegexPatternSetRegularExpressionBlock>>? RegularExpression { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The lock_token attribute.
    /// </summary>
    [TerraformProperty("lock_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LockToken { get; }

}
