using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for xss_match_tuples in AwsWafXssMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafXssMatchSetXssMatchTuplesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "xss_match_tuples";

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
    public required TerraformList<AwsWafXssMatchSetXssMatchTuplesBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformList<AwsWafXssMatchSetXssMatchTuplesBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafXssMatchSetXssMatchTuplesBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafXssMatchSetXssMatchTuplesBlockFieldToMatchBlock : TerraformBlock
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
/// Represents a aws_waf_xss_match_set Terraform resource.
/// Manages a aws_waf_xss_match_set resource.
/// </summary>
public partial class AwsWafXssMatchSet(string name) : TerraformResource("aws_waf_xss_match_set", name)
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// XssMatchTuples block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafXssMatchSetXssMatchTuplesBlock>? XssMatchTuples
    {
        get => GetArgument<TerraformSet<AwsWafXssMatchSetXssMatchTuplesBlock>>("xss_match_tuples");
        set => SetArgument("xss_match_tuples", value);
    }

}
