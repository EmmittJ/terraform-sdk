using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regex_match_tuple in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalRegexMatchSetRegexMatchTupleBlock : TerraformBlock
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
/// Manages a aws_wafregional_regex_match_set resource.
/// </summary>
public class AwsWafregionalRegexMatchSet : TerraformResource
{
    public AwsWafregionalRegexMatchSet(string name) : base("aws_wafregional_regex_match_set", name)
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
    /// Block for regex_match_tuple.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafregionalRegexMatchSetRegexMatchTupleBlock>? RegexMatchTuple
    {
        set => SetProperty("regex_match_tuple", value);
    }

}
