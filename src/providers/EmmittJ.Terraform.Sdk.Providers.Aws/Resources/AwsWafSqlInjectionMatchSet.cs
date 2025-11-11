using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuples in .
/// Nesting mode: set
/// </summary>
public class AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock
{
    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformPropertyName("text_transformation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_sql_injection_match_set resource.
/// </summary>
public class AwsWafSqlInjectionMatchSet : TerraformResource
{
    public AwsWafSqlInjectionMatchSet(string name) : base("aws_waf_sql_injection_match_set", name)
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
    /// Block for sql_injection_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sql_injection_match_tuples")]
    public TerraformSet<TerraformBlock<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock>>? SqlInjectionMatchTuples { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
