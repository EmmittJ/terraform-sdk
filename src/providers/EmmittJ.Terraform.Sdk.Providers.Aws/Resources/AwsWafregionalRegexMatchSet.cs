using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for regex_match_tuple in AwsWafregionalRegexMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafregionalRegexMatchSetRegexMatchTupleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex_match_tuple";

    /// <summary>
    /// The regex_pattern_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegexPatternSetId is required")]
    public required TerraformValue<string> RegexPatternSetId
    {
        get => new TerraformReference<string>(this, "regex_pattern_set_id");
        set => SetArgument("regex_pattern_set_id", value);
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
    public required TerraformList<AwsWafregionalRegexMatchSetRegexMatchTupleBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformList<AwsWafregionalRegexMatchSetRegexMatchTupleBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafregionalRegexMatchSetRegexMatchTupleBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafregionalRegexMatchSetRegexMatchTupleBlockFieldToMatchBlock : TerraformBlock
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
/// Represents a aws_wafregional_regex_match_set Terraform resource.
/// Manages a aws_wafregional_regex_match_set resource.
/// </summary>
public partial class AwsWafregionalRegexMatchSet(string name) : TerraformResource("aws_wafregional_regex_match_set", name)
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
    /// RegexMatchTuple block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafregionalRegexMatchSetRegexMatchTupleBlock>? RegexMatchTuple
    {
        get => GetArgument<TerraformSet<AwsWafregionalRegexMatchSetRegexMatchTupleBlock>>("regex_match_tuple");
        set => SetArgument("regex_match_tuple", value);
    }

}
