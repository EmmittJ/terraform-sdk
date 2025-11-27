using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in AwsWafregionalByteMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafregionalByteMatchSetByteMatchTuplesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "byte_match_tuples";

    /// <summary>
    /// The positional_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PositionalConstraint is required")]
    public required TerraformValue<string> PositionalConstraint
    {
        get => new TerraformReference<string>(this, "positional_constraint");
        set => SetArgument("positional_constraint", value);
    }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    public TerraformValue<string>? TargetString
    {
        get => new TerraformReference<string>(this, "target_string");
        set => SetArgument("target_string", value);
    }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformValue<string> TextTransformation
    {
        get => new TerraformReference<string>(this, "text_transformation");
        set => SetArgument("text_transformation", value);
    }

    /// <summary>
    /// FieldToMatch block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldToMatch is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldToMatch block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FieldToMatch block(s) allowed")]
    public required TerraformList<AwsWafregionalByteMatchSetByteMatchTuplesBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformList<AwsWafregionalByteMatchSetByteMatchTuplesBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafregionalByteMatchSetByteMatchTuplesBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafregionalByteMatchSetByteMatchTuplesBlockFieldToMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_to_match";

    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_wafregional_byte_match_set Terraform resource.
/// Manages a aws_wafregional_byte_match_set resource.
/// </summary>
public partial class AwsWafregionalByteMatchSet(string name) : TerraformResource("aws_wafregional_byte_match_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// ByteMatchTuples block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafregionalByteMatchSetByteMatchTuplesBlock>? ByteMatchTuples
    {
        get => GetArgument<TerraformSet<AwsWafregionalByteMatchSetByteMatchTuplesBlock>>("byte_match_tuples");
        set => SetArgument("byte_match_tuples", value);
    }

}
