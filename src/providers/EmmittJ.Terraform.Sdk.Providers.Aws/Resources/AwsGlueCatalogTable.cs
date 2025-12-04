using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for open_table_format_input in AwsGlueCatalogTable.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOpenTableFormatInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_table_format_input";

    /// <summary>
    /// IcebergInput block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IcebergInput is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IcebergInput block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergInput block(s) allowed")]
    public required TerraformList<AwsGlueCatalogTableOpenTableFormatInputBlockIcebergInputBlock> IcebergInput
    {
        get => GetRequiredArgument<TerraformList<AwsGlueCatalogTableOpenTableFormatInputBlockIcebergInputBlock>>("iceberg_input");
        set => SetArgument("iceberg_input", value);
    }

}

/// <summary>
/// Block type for iceberg_input in AwsGlueCatalogTableOpenTableFormatInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOpenTableFormatInputBlockIcebergInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iceberg_input";

    /// <summary>
    /// The metadata_operation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataOperation is required")]
    public required TerraformValue<string> MetadataOperation
    {
        get => GetArgument<TerraformValue<string>>("metadata_operation");
        set => SetArgument("metadata_operation", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for partition_index in AwsGlueCatalogTable.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTablePartitionIndexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partition_index";

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformValue<string> IndexName
    {
        get => GetArgument<TerraformValue<string>>("index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    public TerraformValue<string> IndexStatus
        => AsReference("index_status");

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeysAttribute is required")]
    public TerraformList<string>? KeysAttribute
    {
        get => GetArgument<TerraformList<string>>("keys");
        set => SetArgument("keys", value);
    }

}


/// <summary>
/// Block type for partition_keys in AwsGlueCatalogTable.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTablePartitionKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partition_keys";

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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for storage_descriptor in AwsGlueCatalogTable.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlock : TerraformBlock
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
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlockColumnsBlock>? Columns
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

    /// <summary>
    /// SchemaReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaReference block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlock>? SchemaReference
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlock>>("schema_reference");
        set => SetArgument("schema_reference", value);
    }

    /// <summary>
    /// SerDeInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SerDeInfo block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSerDeInfoBlock>? SerDeInfo
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSerDeInfoBlock>>("ser_de_info");
        set => SetArgument("ser_de_info", value);
    }

    /// <summary>
    /// SkewedInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkewedInfo block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSkewedInfoBlock>? SkewedInfo
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSkewedInfoBlock>>("skewed_info");
        set => SetArgument("skewed_info", value);
    }

    /// <summary>
    /// SortColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSortColumnsBlock>? SortColumns
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSortColumnsBlock>>("sort_columns");
        set => SetArgument("sort_columns", value);
    }

}

/// <summary>
/// Block type for columns in AwsGlueCatalogTableStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlockColumnsBlock : TerraformBlock
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for schema_reference in AwsGlueCatalogTableStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_reference";

    /// <summary>
    /// The schema_version_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaVersionId
    {
        get => GetArgument<TerraformValue<string>>("schema_version_id");
        set => SetArgument("schema_version_id", value);
    }

    /// <summary>
    /// The schema_version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaVersionNumber is required")]
    public required TerraformValue<double> SchemaVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("schema_version_number");
        set => SetArgument("schema_version_number", value);
    }

    /// <summary>
    /// SchemaId block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaId block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlockSchemaIdBlock>? SchemaId
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlockSchemaIdBlock>>("schema_id");
        set => SetArgument("schema_id", value);
    }

}

/// <summary>
/// Block type for schema_id in AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlockSchemaReferenceBlockSchemaIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_id";

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public TerraformValue<string>? RegistryName
    {
        get => GetArgument<TerraformValue<string>>("registry_name");
        set => SetArgument("registry_name", value);
    }

    /// <summary>
    /// The schema_arn attribute.
    /// </summary>
    public TerraformValue<string>? SchemaArn
    {
        get => GetArgument<TerraformValue<string>>("schema_arn");
        set => SetArgument("schema_arn", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformValue<string>? SchemaName
    {
        get => GetArgument<TerraformValue<string>>("schema_name");
        set => SetArgument("schema_name", value);
    }

}

/// <summary>
/// Block type for ser_de_info in AwsGlueCatalogTableStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlockSerDeInfoBlock : TerraformBlock
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
/// Block type for skewed_info in AwsGlueCatalogTableStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlockSkewedInfoBlock : TerraformBlock
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
/// Block type for sort_columns in AwsGlueCatalogTableStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlockSortColumnsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SortOrder is required")]
    public required TerraformValue<double> SortOrder
    {
        get => GetArgument<TerraformValue<double>>("sort_order");
        set => SetArgument("sort_order", value);
    }

}


/// <summary>
/// Block type for target_table in AwsGlueCatalogTable.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableTargetTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_table";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformValue<string> CatalogId
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Represents a aws_glue_catalog_table Terraform resource.
/// Manages a aws_glue_catalog_table resource.
/// </summary>
public partial class AwsGlueCatalogTable(string name) : TerraformResource("aws_glue_catalog_table", name)
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => GetArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention attribute.
    /// </summary>
    public TerraformValue<double>? Retention
    {
        get => GetArgument<TerraformValue<double>>("retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformValue<string>? TableType
    {
        get => GetArgument<TerraformValue<string>>("table_type");
        set => SetArgument("table_type", value);
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformValue<string>? ViewExpandedText
    {
        get => GetArgument<TerraformValue<string>>("view_expanded_text");
        set => SetArgument("view_expanded_text", value);
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformValue<string>? ViewOriginalText
    {
        get => GetArgument<TerraformValue<string>>("view_original_text");
        set => SetArgument("view_original_text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// OpenTableFormatInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenTableFormatInput block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableOpenTableFormatInputBlock>? OpenTableFormatInput
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableOpenTableFormatInputBlock>>("open_table_format_input");
        set => SetArgument("open_table_format_input", value);
    }

    /// <summary>
    /// PartitionIndex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PartitionIndex block(s) allowed")]
    public TerraformList<AwsGlueCatalogTablePartitionIndexBlock>? PartitionIndex
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTablePartitionIndexBlock>>("partition_index");
        set => SetArgument("partition_index", value);
    }

    /// <summary>
    /// PartitionKeys block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTablePartitionKeysBlock>? PartitionKeys
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTablePartitionKeysBlock>>("partition_keys");
        set => SetArgument("partition_keys", value);
    }

    /// <summary>
    /// StorageDescriptor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableStorageDescriptorBlock>? StorageDescriptor
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableStorageDescriptorBlock>>("storage_descriptor");
        set => SetArgument("storage_descriptor", value);
    }

    /// <summary>
    /// TargetTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTable block(s) allowed")]
    public TerraformList<AwsGlueCatalogTableTargetTableBlock>? TargetTable
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableTargetTableBlock>>("target_table");
        set => SetArgument("target_table", value);
    }

}
