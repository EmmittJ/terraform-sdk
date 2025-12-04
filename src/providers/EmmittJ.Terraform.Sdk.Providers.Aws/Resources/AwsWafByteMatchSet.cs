using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in AwsWafByteMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafByteMatchSetByteMatchTuplesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("positional_constraint");
        set => SetArgument("positional_constraint", value);
    }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    public TerraformValue<string>? TargetString
    {
        get => GetArgument<TerraformValue<string>>("target_string");
        set => SetArgument("target_string", value);
    }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformValue<string> TextTransformation
    {
        get => GetArgument<TerraformValue<string>>("text_transformation");
        set => SetArgument("text_transformation", value);
    }

    /// <summary>
    /// FieldToMatch block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldToMatch is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldToMatch block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FieldToMatch block(s) allowed")]
    public required TerraformList<AwsWafByteMatchSetByteMatchTuplesBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformList<AwsWafByteMatchSetByteMatchTuplesBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafByteMatchSetByteMatchTuplesBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafByteMatchSetByteMatchTuplesBlockFieldToMatchBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_waf_byte_match_set Terraform resource.
/// Manages a aws_waf_byte_match_set resource.
/// </summary>
public partial class AwsWafByteMatchSet(string name) : TerraformResource("aws_waf_byte_match_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// ByteMatchTuples block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafByteMatchSetByteMatchTuplesBlock>? ByteMatchTuples
    {
        get => GetArgument<TerraformSet<AwsWafByteMatchSetByteMatchTuplesBlock>>("byte_match_tuples");
        set => SetArgument("byte_match_tuples", value);
    }

}
