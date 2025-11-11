using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuple in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock : TerraformBlockBase
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
/// Manages a aws_wafregional_sql_injection_match_set resource.
/// </summary>
public partial class AwsWafregionalSqlInjectionMatchSet : TerraformResource
{
    public AwsWafregionalSqlInjectionMatchSet(string name) : base("aws_wafregional_sql_injection_match_set", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for sql_injection_match_tuple.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sql_injection_match_tuple")]
    public TerraformSet<TerraformBlock<AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock>>? SqlInjectionMatchTuple { get; set; }

}
