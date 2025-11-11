using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuple in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock
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
/// Manages a aws_wafregional_sql_injection_match_set resource.
/// </summary>
public class AwsWafregionalSqlInjectionMatchSet : TerraformResource
{
    public AwsWafregionalSqlInjectionMatchSet(string name) : base("aws_wafregional_sql_injection_match_set", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for sql_injection_match_tuple.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sql_injection_match_tuple")]
    public TerraformSet<TerraformBlock<AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock>>? SqlInjectionMatchTuple { get; set; }

}
