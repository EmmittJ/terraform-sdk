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
        set => SetProperty("text_transformation", value);
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for sql_injection_match_tuple.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafregionalSqlInjectionMatchSetSqlInjectionMatchTupleBlock>? SqlInjectionMatchTuple
    {
        set => SetProperty("sql_injection_match_tuple", value);
    }

}
