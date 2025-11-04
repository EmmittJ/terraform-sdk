using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_table_item resource.
/// </summary>
public class AwsDynamodbTableItem : TerraformResource
{
    public AwsDynamodbTableItem(string name) : base("aws_dynamodb_table_item", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public string? HashKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_key")?.Value;
        set => this.WithProperty("hash_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The item attribute.
    /// </summary>
    public string? Item
    {
        get => GetProperty<TerraformLiteralProperty<string>>("item")?.Value;
        set => this.WithProperty("item", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public string? RangeKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("range_key")?.Value;
        set => this.WithProperty("range_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
