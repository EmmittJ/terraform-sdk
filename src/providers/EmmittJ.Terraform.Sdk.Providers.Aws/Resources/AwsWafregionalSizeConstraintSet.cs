using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for size_constraints in AwsWafregionalSizeConstraintSet.
/// Nesting mode: set
/// </summary>
public class AwsWafregionalSizeConstraintSetSizeConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "size_constraints";

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformValue<string> ComparisonOperator
    {
        get => new TerraformReference<string>(this, "comparison_operator");
        set => SetArgument("comparison_operator", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
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
    public required TerraformList<AwsWafregionalSizeConstraintSetSizeConstraintsBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformList<AwsWafregionalSizeConstraintSetSizeConstraintsBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafregionalSizeConstraintSetSizeConstraintsBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafregionalSizeConstraintSetSizeConstraintsBlockFieldToMatchBlock : TerraformBlock
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
/// Represents a aws_wafregional_size_constraint_set Terraform resource.
/// Manages a aws_wafregional_size_constraint_set resource.
/// </summary>
public partial class AwsWafregionalSizeConstraintSet(string name) : TerraformResource("aws_wafregional_size_constraint_set", name)
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// SizeConstraints block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafregionalSizeConstraintSetSizeConstraintsBlock>? SizeConstraints
    {
        get => GetArgument<TerraformSet<AwsWafregionalSizeConstraintSetSizeConstraintsBlock>>("size_constraints");
        set => SetArgument("size_constraints", value);
    }

}
