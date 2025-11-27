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
        get => new TerraformReference<string>(this, "metadata_operation");
        set => SetArgument("metadata_operation", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
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
        get => new TerraformReference<string>(this, "index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    public TerraformValue<string> IndexStatus
    {
        get => new TerraformReference<string>(this, "index_status");
    }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeysAttribute is required")]
    public TerraformList<string>? KeysAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "keys").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "additional_locations").ResolveNodes(ctx));
        set => SetArgument("additional_locations", value);
    }

    /// <summary>
    /// The bucket_columns attribute.
    /// </summary>
    public TerraformList<string>? BucketColumns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "bucket_columns").ResolveNodes(ctx));
        set => SetArgument("bucket_columns", value);
    }

    /// <summary>
    /// The compressed attribute.
    /// </summary>
    public TerraformValue<bool>? Compressed
    {
        get => new TerraformReference<bool>(this, "compressed");
        set => SetArgument("compressed", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    public TerraformValue<string>? InputFormat
    {
        get => new TerraformReference<string>(this, "input_format");
        set => SetArgument("input_format", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The number_of_buckets attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfBuckets
    {
        get => new TerraformReference<double>(this, "number_of_buckets");
        set => SetArgument("number_of_buckets", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => new TerraformReference<string>(this, "output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The stored_as_sub_directories attribute.
    /// </summary>
    public TerraformValue<bool>? StoredAsSubDirectories
    {
        get => new TerraformReference<bool>(this, "stored_as_sub_directories");
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
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => new TerraformReference<string>(this, "schema_version_id");
        set => SetArgument("schema_version_id", value);
    }

    /// <summary>
    /// The schema_version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaVersionNumber is required")]
    public required TerraformValue<double> SchemaVersionNumber
    {
        get => new TerraformReference<double>(this, "schema_version_number");
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
        get => new TerraformReference<string>(this, "registry_name");
        set => SetArgument("registry_name", value);
    }

    /// <summary>
    /// The schema_arn attribute.
    /// </summary>
    public TerraformValue<string>? SchemaArn
    {
        get => new TerraformReference<string>(this, "schema_arn");
        set => SetArgument("schema_arn", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformValue<string>? SchemaName
    {
        get => new TerraformReference<string>(this, "schema_name");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The serialization_library attribute.
    /// </summary>
    public TerraformValue<string>? SerializationLibrary
    {
        get => new TerraformReference<string>(this, "serialization_library");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "skewed_column_names").ResolveNodes(ctx));
        set => SetArgument("skewed_column_names", value);
    }

    /// <summary>
    /// The skewed_column_value_location_maps attribute.
    /// </summary>
    public TerraformMap<string>? SkewedColumnValueLocationMaps
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "skewed_column_value_location_maps").ResolveNodes(ctx));
        set => SetArgument("skewed_column_value_location_maps", value);
    }

    /// <summary>
    /// The skewed_column_values attribute.
    /// </summary>
    public TerraformList<string>? SkewedColumnValues
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "skewed_column_values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "column");
        set => SetArgument("column", value);
    }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SortOrder is required")]
    public required TerraformValue<double> SortOrder
    {
        get => new TerraformReference<double>(this, "sort_order");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string>? Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
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
    /// The retention attribute.
    /// </summary>
    public TerraformValue<double>? Retention
    {
        get => new TerraformReference<double>(this, "retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformValue<string>? TableType
    {
        get => new TerraformReference<string>(this, "table_type");
        set => SetArgument("table_type", value);
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformValue<string>? ViewExpandedText
    {
        get => new TerraformReference<string>(this, "view_expanded_text");
        set => SetArgument("view_expanded_text", value);
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformValue<string>? ViewOriginalText
    {
        get => new TerraformReference<string>(this, "view_original_text");
        set => SetArgument("view_original_text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
