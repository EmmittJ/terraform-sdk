using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in .
/// Nesting mode: set
/// </summary>
public class AwsWafregionalByteMatchSetByteMatchTuplesBlock : TerraformBlock
{
    /// <summary>
    /// The positional_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PositionalConstraint is required")]
    public required TerraformProperty<string> PositionalConstraint
    {
        get => GetProperty<TerraformProperty<string>>("positional_constraint");
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
        get => GetProperty<TerraformProperty<string>>("text_transformation");
        set => WithProperty("text_transformation", value);
    }

}

/// <summary>
/// Manages a aws_wafregional_byte_match_set resource.
/// </summary>
public class AwsWafregionalByteMatchSet : TerraformResource
{
    public AwsWafregionalByteMatchSet(string name) : base("aws_wafregional_byte_match_set", name)
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
    /// Block for byte_match_tuples.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsWafregionalByteMatchSetByteMatchTuplesBlock>? ByteMatchTuples
    {
        get => GetProperty<HashSet<AwsWafregionalByteMatchSetByteMatchTuplesBlock>>("byte_match_tuples");
        set => this.WithProperty("byte_match_tuples", value);
    }

}
