using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regex_match_tuple in .
/// Nesting mode: set
/// </summary>
public class AwsWafRegexMatchSetRegexMatchTupleBlock : TerraformBlock
{
    /// <summary>
    /// The regex_pattern_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexPatternSetId is required")]
    public required TerraformProperty<string> RegexPatternSetId
    {
        set => SetProperty("regex_pattern_set_id", value);
    }

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
/// Manages a aws_waf_regex_match_set resource.
/// </summary>
public class AwsWafRegexMatchSet : TerraformResource
{
    public AwsWafRegexMatchSet(string name) : base("aws_waf_regex_match_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
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
    /// Block for regex_match_tuple.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafRegexMatchSetRegexMatchTupleBlock>? RegexMatchTuple
    {
        set => SetProperty("regex_match_tuple", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
