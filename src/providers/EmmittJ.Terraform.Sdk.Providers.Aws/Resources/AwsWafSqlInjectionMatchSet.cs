using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuples in .
/// Nesting mode: set
/// </summary>
public class AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock : ITerraformBlock
{
    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformPropertyName("text_transformation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TextTransformation { get; set; }

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
    /// Block for sql_injection_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sql_injection_match_tuples")]
    public TerraformSet<TerraformBlock<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock>>? SqlInjectionMatchTuples { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
