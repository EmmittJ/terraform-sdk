using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_glue_catalog_table Terraform data source.
/// Retrieves information about a aws_glue_catalog_table.
/// </summary>
public partial class AwsGlueCatalogTableDataSource(string name) : TerraformDataSource("aws_glue_catalog_table", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    public TerraformValue<string>? QueryAsOfTime
    {
        get => GetArgument<TerraformValue<string>>("query_as_of_time");
        set => SetArgument("query_as_of_time", value);
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
    /// The transaction_id attribute.
    /// </summary>
    public TerraformValue<double>? TransactionId
    {
        get => GetArgument<TerraformValue<double>>("transaction_id");
        set => SetArgument("transaction_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The partition_index attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartitionIndex
        => AsReference("partition_index");

    /// <summary>
    /// The partition_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartitionKeys
        => AsReference("partition_keys");

    /// <summary>
    /// The retention attribute.
    /// </summary>
    public TerraformValue<double> Retention
        => AsReference("retention");

    /// <summary>
    /// The storage_descriptor attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageDescriptor
        => AsReference("storage_descriptor");

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformValue<string> TableType
        => AsReference("table_type");

    /// <summary>
    /// The target_table attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetTable
        => AsReference("target_table");

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformValue<string> ViewExpandedText
        => AsReference("view_expanded_text");

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformValue<string> ViewOriginalText
        => AsReference("view_original_text");

}
