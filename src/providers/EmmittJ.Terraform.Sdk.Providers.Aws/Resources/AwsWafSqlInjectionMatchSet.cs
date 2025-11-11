using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuples in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock : TerraformBlockBase
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
/// Manages a aws_waf_sql_injection_match_set resource.
/// </summary>
public partial class AwsWafSqlInjectionMatchSet : TerraformResource
{
    public AwsWafSqlInjectionMatchSet(string name) : base("aws_waf_sql_injection_match_set", name)
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
    /// Block for sql_injection_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sql_injection_match_tuples")]
    public TerraformSet<TerraformBlock<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock>>? SqlInjectionMatchTuples { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
