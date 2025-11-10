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
        get => GetRequiredProperty<TerraformProperty<string>>("positional_constraint");
        set => WithProperty("positional_constraint", value);
    }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    public TerraformProperty<string>? TargetString
    {
        get => GetProperty<TerraformProperty<string>>("target_string");
        set => WithProperty("target_string", value);
    }

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
        this.DeclareOutput("arn");
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
    /// Block for byte_match_tuples.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafByteMatchSetByteMatchTuplesBlock>? ByteMatchTuples
    {
        get => GetProperty<HashSet<AwsWafByteMatchSetByteMatchTuplesBlock>>("byte_match_tuples");
        set => this.WithProperty("byte_match_tuples", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
