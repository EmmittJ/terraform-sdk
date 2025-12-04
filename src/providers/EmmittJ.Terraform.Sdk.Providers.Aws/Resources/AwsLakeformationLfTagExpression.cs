using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for expression in AwsLakeformationLfTagExpression.
/// Nesting mode: set
/// </summary>
public class AwsLakeformationLfTagExpressionExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expression";

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    public required TerraformValue<string> TagKey
    {
        get => GetArgument<TerraformValue<string>>("tag_key");
        set => SetArgument("tag_key", value);
    }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    public required TerraformSet<string> TagValues
    {
        get => GetArgument<TerraformSet<string>>("tag_values");
        set => SetArgument("tag_values", value);
    }

}


/// <summary>
/// Represents a aws_lakeformation_lf_tag_expression Terraform resource.
/// Manages an AWS Lake Formation Tag Expression.
/// </summary>
public partial class AwsLakeformationLfTagExpression(string name) : TerraformResource("aws_lakeformation_lf_tag_expression", name)
{
    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// A description of the LF-Tag Expression.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name of the LF-Tag Expression.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Expression block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLakeformationLfTagExpressionExpressionBlock>? Expression
    {
        get => GetArgument<TerraformSet<AwsLakeformationLfTagExpressionExpressionBlock>>("expression");
        set => SetArgument("expression", value);
    }

}
