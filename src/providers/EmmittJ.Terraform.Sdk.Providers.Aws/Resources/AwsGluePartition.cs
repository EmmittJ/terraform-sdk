using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_descriptor in AwsGluePartition.
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_descriptor";

    /// <summary>
    /// The additional_locations attribute.
    /// </summary>
    public TerraformList<string>? AdditionalLocations
    {
        get => GetArgument<TerraformList<string>>("additional_locations");
        set => SetArgument("additional_locations", value);
    }

    /// <summary>
    /// The bucket_columns attribute.
    /// </summary>
    public TerraformList<string>? BucketColumns
    {
        get => GetArgument<TerraformList<string>>("bucket_columns");
        set => SetArgument("bucket_columns", value);
    }

    /// <summary>
    /// The compressed attribute.
    /// </summary>
    public TerraformValue<bool>? Compressed
    {
        get => GetArgument<TerraformValue<bool>>("compressed");
        set => SetArgument("compressed", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    public TerraformValue<string>? InputFormat
    {
        get => GetArgument<TerraformValue<string>>("input_format");
        set => SetArgument("input_format", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The number_of_buckets attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfBuckets
    {
        get => GetArgument<TerraformValue<double>>("number_of_buckets");
        set => SetArgument("number_of_buckets", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => GetArgument<TerraformValue<string>>("output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The stored_as_sub_directories attribute.
    /// </summary>
    public TerraformValue<bool>? StoredAsSubDirectories
    {
        get => GetArgument<TerraformValue<bool>>("stored_as_sub_directories");
        set => SetArgument("stored_as_sub_directories", value);
    }

    /// <summary>
    /// Columns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGluePartitionStorageDescriptorBlockColumnsBlock>? Columns
    {
        get => GetArgument<TerraformList<AwsGluePartitionStorageDescriptorBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

    /// <summary>
    /// SerDeInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SerDeInfo block(s) allowed")]
    public TerraformList<AwsGluePartitionStorageDescriptorBlockSerDeInfoBlock>? SerDeInfo
    {
        get => GetArgument<TerraformList<AwsGluePartitionStorageDescriptorBlockSerDeInfoBlock>>("ser_de_info");
        set => SetArgument("ser_de_info", value);
    }

    /// <summary>
    /// SkewedInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkewedInfo block(s) allowed")]
    public TerraformList<AwsGluePartitionStorageDescriptorBlockSkewedInfoBlock>? SkewedInfo
    {
        get => GetArgument<TerraformList<AwsGluePartitionStorageDescriptorBlockSkewedInfoBlock>>("skewed_info");
        set => SetArgument("skewed_info", value);
    }

    /// <summary>
    /// SortColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGluePartitionStorageDescriptorBlockSortColumnsBlock>? SortColumns
    {
        get => GetArgument<TerraformList<AwsGluePartitionStorageDescriptorBlockSortColumnsBlock>>("sort_columns");
        set => SetArgument("sort_columns", value);
    }

}

/// <summary>
/// Block type for columns in AwsGluePartitionStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlockColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "columns";

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for ser_de_info in AwsGluePartitionStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlockSerDeInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ser_de_info";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The serialization_library attribute.
    /// </summary>
    public TerraformValue<string>? SerializationLibrary
    {
        get => GetArgument<TerraformValue<string>>("serialization_library");
        set => SetArgument("serialization_library", value);
    }

}

/// <summary>
/// Block type for skewed_info in AwsGluePartitionStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlockSkewedInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "skewed_info";

    /// <summary>
    /// The skewed_column_names attribute.
    /// </summary>
    public TerraformList<string>? SkewedColumnNames
    {
        get => GetArgument<TerraformList<string>>("skewed_column_names");
        set => SetArgument("skewed_column_names", value);
    }

    /// <summary>
    /// The skewed_column_value_location_maps attribute.
    /// </summary>
    public TerraformMap<string>? SkewedColumnValueLocationMaps
    {
        get => GetArgument<TerraformMap<string>>("skewed_column_value_location_maps");
        set => SetArgument("skewed_column_value_location_maps", value);
    }

    /// <summary>
    /// The skewed_column_values attribute.
    /// </summary>
    public TerraformList<string>? SkewedColumnValues
    {
        get => GetArgument<TerraformList<string>>("skewed_column_values");
        set => SetArgument("skewed_column_values", value);
    }

}

/// <summary>
/// Block type for sort_columns in AwsGluePartitionStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlockSortColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sort_columns";

    /// <summary>
    /// The column attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Column is required")]
    public required TerraformValue<string> Column
    {
        get => GetRequiredArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SortOrder is required")]
    public required TerraformValue<double> SortOrder
    {
        get => GetRequiredArgument<TerraformValue<double>>("sort_order");
        set => SetArgument("sort_order", value);
    }

}


/// <summary>
/// Represents a aws_glue_partition Terraform resource.
/// Manages a aws_glue_partition resource.
/// </summary>
public partial class AwsGluePartition(string name) : TerraformResource("aws_glue_partition", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The partition_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionValues is required")]
    public TerraformList<string>? PartitionValues
    {
        get => GetArgument<TerraformList<string>>("partition_values");
        set => SetArgument("partition_values", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The last_accessed_time attribute.
    /// </summary>
    public TerraformValue<string> LastAccessedTime
        => AsReference("last_accessed_time");

    /// <summary>
    /// The last_analyzed_time attribute.
    /// </summary>
    public TerraformValue<string> LastAnalyzedTime
        => AsReference("last_analyzed_time");

    /// <summary>
    /// StorageDescriptor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public TerraformList<AwsGluePartitionStorageDescriptorBlock>? StorageDescriptor
    {
        get => GetArgument<TerraformList<AwsGluePartitionStorageDescriptorBlock>>("storage_descriptor");
        set => SetArgument("storage_descriptor", value);
    }

}
