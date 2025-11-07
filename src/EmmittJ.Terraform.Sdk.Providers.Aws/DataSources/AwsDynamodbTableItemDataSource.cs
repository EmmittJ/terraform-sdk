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
    public TerraformProperty<Dictionary<string, string>>? ExpressionAttributeNames
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("expression_attribute_names");
        set => this.WithProperty("expression_attribute_names", value);
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
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The projection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ProjectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("projection_expression");
        set => this.WithProperty("projection_expression", value);
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
    /// The table_name attribute.
    /// </summary>
    public TerraformProperty<string>? TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    public TerraformExpression Item => this["item"];

}
