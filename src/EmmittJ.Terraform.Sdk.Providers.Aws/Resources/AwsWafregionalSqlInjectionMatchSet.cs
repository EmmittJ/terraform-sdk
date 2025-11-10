using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuple in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock : TerraformBlock
{
    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformProperty<string> TextTransformation
    {
        get => GetProperty<TerraformProperty<string>>("text_transformation");
        set => WithProperty("text_transformation", value);
    }

}

/// <summary>
/// Manages a aws_wafregional_sql_injection_match_set resource.
/// </summary>
public class AwsWafregionalSqlInjectionMatchSet : TerraformResource
{
    public AwsWafregionalSqlInjectionMatchSet(string name) : base("aws_wafregional_sql_injection_match_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for sql_injection_match_tuple.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock>? SqlInjectionMatchTuple
    {
        get => GetProperty<HashSet<AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock>>("sql_injection_match_tuple");
        set => this.WithProperty("sql_injection_match_tuple", value);
    }

}
