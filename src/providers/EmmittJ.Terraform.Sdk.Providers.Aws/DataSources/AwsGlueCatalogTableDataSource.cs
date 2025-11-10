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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("owner");
        SetOutput("parameters");
        SetOutput("partition_index");
        SetOutput("partition_keys");
        SetOutput("retention");
        SetOutput("storage_descriptor");
        SetOutput("table_type");
        SetOutput("target_table");
        SetOutput("view_expanded_text");
        SetOutput("view_original_text");
        SetOutput("catalog_id");
        SetOutput("database_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("query_as_of_time");
        SetOutput("region");
        SetOutput("transaction_id");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    public TerraformProperty<string> QueryAsOfTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_as_of_time");
        set => SetProperty("query_as_of_time", value);
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
    /// The transaction_id attribute.
    /// </summary>
    public TerraformProperty<double> TransactionId
    {
        get => GetRequiredOutput<TerraformProperty<double>>("transaction_id");
        set => SetProperty("transaction_id", value);
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
