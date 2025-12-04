using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dynamodb_table_item Terraform data source.
/// Retrieves information about a aws_dynamodb_table_item.
/// </summary>
public partial class AwsDynamodbTableItemDataSource(string name) : TerraformDataSource("aws_dynamodb_table_item", name)
{
    /// <summary>
    /// The expression_attribute_names attribute.
    /// </summary>
    public TerraformMap<string>? ExpressionAttributeNames
    {
        get => GetArgument<TerraformMap<string>>("expression_attribute_names");
        set => SetArgument("expression_attribute_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The projection_expression attribute.
    /// </summary>
    public TerraformValue<string>? ProjectionExpression
    {
        get => GetArgument<TerraformValue<string>>("projection_expression");
        set => SetArgument("projection_expression", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    public TerraformValue<string> Item
        => AsReference("item");

}
