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
    public TerraformLiteralProperty<string>? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryAsOfTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_as_of_time");
        set => this.WithProperty("query_as_of_time", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The transaction_id attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TransactionId
    {
        get => GetProperty<TerraformLiteralProperty<double>>("transaction_id");
        set => this.WithProperty("transaction_id", value);
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
