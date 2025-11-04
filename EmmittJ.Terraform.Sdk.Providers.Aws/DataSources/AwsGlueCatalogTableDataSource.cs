using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_catalog_table.
/// </summary>
public class AwsGlueCatalogTableDataSource : TerraformDataSource
{
    public AwsGlueCatalogTableDataSource(string name) : base("aws_glue_catalog_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("owner");
        this.DeclareOutput("parameters");
        this.DeclareOutput("partition_index");
        this.DeclareOutput("partition_keys");
        this.DeclareOutput("retention");
        this.DeclareOutput("storage_descriptor");
        this.DeclareOutput("table_type");
        this.DeclareOutput("target_table");
        this.DeclareOutput("view_expanded_text");
        this.DeclareOutput("view_original_text");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    public string? QueryAsOfTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_as_of_time")?.Value;
        set => this.WithProperty("query_as_of_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transaction_id attribute.
    /// </summary>
    public double? TransactionId
    {
        get => GetProperty<TerraformLiteralProperty<double>>("transaction_id")?.Value;
        set => this.WithProperty("transaction_id", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The partition_index attribute.
    /// </summary>
    public TerraformExpression PartitionIndex => this["partition_index"];

    /// <summary>
    /// The partition_keys attribute.
    /// </summary>
    public TerraformExpression PartitionKeys => this["partition_keys"];

    /// <summary>
    /// The retention attribute.
    /// </summary>
    public TerraformExpression Retention => this["retention"];

    /// <summary>
    /// The storage_descriptor attribute.
    /// </summary>
    public TerraformExpression StorageDescriptor => this["storage_descriptor"];

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformExpression TableType => this["table_type"];

    /// <summary>
    /// The target_table attribute.
    /// </summary>
    public TerraformExpression TargetTable => this["target_table"];

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformExpression ViewExpandedText => this["view_expanded_text"];

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformExpression ViewOriginalText => this["view_original_text"];

}
