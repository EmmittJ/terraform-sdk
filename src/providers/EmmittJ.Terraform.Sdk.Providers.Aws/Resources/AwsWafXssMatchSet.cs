using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for xss_match_tuples in .
/// Nesting mode: set
/// </summary>
public class AwsWafXssMatchSetXssMatchTuplesBlock : TerraformBlock
{
    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformProperty<string> TextTransformation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("text_transformation");
        set => WithProperty("text_transformation", value);
    }

}

/// <summary>
/// Manages a aws_waf_xss_match_set resource.
/// </summary>
public class AwsWafXssMatchSet : TerraformResource
{
    public AwsWafXssMatchSet(string name) : base("aws_waf_xss_match_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for xss_match_tuples.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafXssMatchSetXssMatchTuplesBlock>? XssMatchTuples
    {
        get => GetProperty<HashSet<AwsWafXssMatchSetXssMatchTuplesBlock>>("xss_match_tuples");
        set => this.WithProperty("xss_match_tuples", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
