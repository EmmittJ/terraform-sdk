using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dynamodb_table_item.
/// </summary>
public class AwsDynamodbTableItemDataSource : TerraformDataSource
{
    public AwsDynamodbTableItemDataSource(string name) : base("aws_dynamodb_table_item", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("item");
    }

    /// <summary>
    /// The expression_attribute_names attribute.
    /// </summary>
    public Dictionary<string, string>? ExpressionAttributeNames
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("expression_attribute_names")?.Value;
        set => this.WithProperty("expression_attribute_names", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The projection_expression attribute.
    /// </summary>
    public string? ProjectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("projection_expression")?.Value;
        set => this.WithProperty("projection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    public TerraformExpression Item => this["item"];

}
