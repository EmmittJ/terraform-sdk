using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in .
/// Nesting mode: set
/// </summary>
public class AwsWafByteMatchSetByteMatchTuplesBlock : TerraformBlock
{
    /// <summary>
    /// The positional_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PositionalConstraint is required")]
    public required TerraformProperty<string> PositionalConstraint
    {
        set => SetProperty("positional_constraint", value);
    }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    public TerraformProperty<string>? TargetString
    {
        set => SetProperty("target_string", value);
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
/// Manages a aws_waf_byte_match_set resource.
/// </summary>
public class AwsWafByteMatchSet : TerraformResource
{
    public AwsWafByteMatchSet(string name) : base("aws_waf_byte_match_set", name)
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
    /// Block for byte_match_tuples.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafByteMatchSetByteMatchTuplesBlock>? ByteMatchTuples
    {
        set => SetProperty("byte_match_tuples", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
