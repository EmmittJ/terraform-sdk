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
        SetOutput("item");
        SetOutput("expression_attribute_names");
        SetOutput("id");
        SetOutput("key");
        SetOutput("projection_expression");
        SetOutput("region");
        SetOutput("table_name");
    }

    /// <summary>
    /// The expression_attribute_names attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ExpressionAttributeNames
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("expression_attribute_names");
        set => SetProperty("expression_attribute_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key");
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The projection_expression attribute.
    /// </summary>
    public TerraformProperty<string> ProjectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("projection_expression");
        set => SetProperty("projection_expression", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// The item attribute.
    /// </summary>
    public TerraformExpression Item => this["item"];

}
