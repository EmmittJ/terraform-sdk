using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sql_injection_match_tuples in AwsWafSqlInjectionMatchSet.
/// Nesting mode: set
/// </summary>
public class AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_injection_match_tuples";

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    public required TerraformValue<string> TextTransformation
    {
        get => GetRequiredArgument<TerraformValue<string>>("text_transformation");
        set => SetArgument("text_transformation", value);
    }

    /// <summary>
    /// FieldToMatch block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldToMatch is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldToMatch block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FieldToMatch block(s) allowed")]
    public required TerraformList<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformList<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlockFieldToMatchBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_waf_sql_injection_match_set Terraform resource.
/// Manages a aws_waf_sql_injection_match_set resource.
/// </summary>
public partial class AwsWafSqlInjectionMatchSet(string name) : TerraformResource("aws_waf_sql_injection_match_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// SqlInjectionMatchTuples block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock>? SqlInjectionMatchTuples
    {
        get => GetArgument<TerraformSet<AwsWafSqlInjectionMatchSetSqlInjectionMatchTuplesBlock>>("sql_injection_match_tuples");
        set => SetArgument("sql_injection_match_tuples", value);
    }

}
