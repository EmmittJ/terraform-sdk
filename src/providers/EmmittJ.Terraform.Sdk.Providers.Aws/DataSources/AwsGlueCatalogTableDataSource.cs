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
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    public TerraformValue<string>? QueryAsOfTime
    {
        get => new TerraformReference<string>(this, "query_as_of_time");
        set => SetArgument("query_as_of_time", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The transaction_id attribute.
    /// </summary>
    public TerraformValue<double>? TransactionId
    {
        get => new TerraformReference<double>(this, "transaction_id");
        set => SetArgument("transaction_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The partition_index attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartitionIndex
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "partition_index").ResolveNodes(ctx));
    }

    /// <summary>
    /// The partition_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PartitionKeys
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "partition_keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The retention attribute.
    /// </summary>
    public TerraformValue<double> Retention
    {
        get => new TerraformReference<double>(this, "retention");
    }

    /// <summary>
    /// The storage_descriptor attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageDescriptor
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "storage_descriptor").ResolveNodes(ctx));
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformValue<string> TableType
    {
        get => new TerraformReference<string>(this, "table_type");
    }

    /// <summary>
    /// The target_table attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetTable
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "target_table").ResolveNodes(ctx));
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformValue<string> ViewExpandedText
    {
        get => new TerraformReference<string>(this, "view_expanded_text");
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformValue<string> ViewOriginalText
    {
        get => new TerraformReference<string>(this, "view_original_text");
    }

}
