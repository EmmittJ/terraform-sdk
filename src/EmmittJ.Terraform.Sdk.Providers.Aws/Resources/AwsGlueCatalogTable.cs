using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for open_table_format_input in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOpenTableFormatInputBlock : TerraformBlock
{
}

/// <summary>
/// Block type for partition_index in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTablePartitionIndexBlock : TerraformBlock
{
    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformProperty<string> IndexName
    {
        get => GetProperty<TerraformProperty<string>>("index_name");
        set => WithProperty("index_name", value);
    }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    public TerraformProperty<string>? IndexStatus
    {
        get => GetProperty<TerraformProperty<string>>("index_status");
        set => WithProperty("index_status", value);
    }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    public List<TerraformProperty<string>>? Keys
    {
        get => GetProperty<List<TerraformProperty<string>>>("keys");
        set => WithProperty("keys", value);
    }

}

/// <summary>
/// Block type for partition_keys in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTablePartitionKeysBlock : TerraformBlock
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => WithProperty("comment", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for storage_descriptor in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// The additional_locations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdditionalLocations
    {
        get => GetProperty<List<TerraformProperty<string>>>("additional_locations");
        set => WithProperty("additional_locations", value);
    }

    /// <summary>
    /// The bucket_columns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? BucketColumns
    {
        get => GetProperty<List<TerraformProperty<string>>>("bucket_columns");
        set => WithProperty("bucket_columns", value);
    }

    /// <summary>
    /// The compressed attribute.
    /// </summary>
    public TerraformProperty<bool>? Compressed
    {
        get => GetProperty<TerraformProperty<bool>>("compressed");
        set => WithProperty("compressed", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    public TerraformProperty<string>? InputFormat
    {
        get => GetProperty<TerraformProperty<string>>("input_format");
        set => WithProperty("input_format", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The number_of_buckets attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfBuckets
    {
        get => GetProperty<TerraformProperty<double>>("number_of_buckets");
        set => WithProperty("number_of_buckets", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformProperty<string>? OutputFormat
    {
        get => GetProperty<TerraformProperty<string>>("output_format");
        set => WithProperty("output_format", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

    /// <summary>
    /// The stored_as_sub_directories attribute.
    /// </summary>
    public TerraformProperty<bool>? StoredAsSubDirectories
    {
        get => GetProperty<TerraformProperty<bool>>("stored_as_sub_directories");
        set => WithProperty("stored_as_sub_directories", value);
    }

}

/// <summary>
/// Block type for target_table in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableTargetTableBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformProperty<string> CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

}

/// <summary>
/// Manages a aws_glue_catalog_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueCatalogTable : TerraformResource
{
    public AwsGlueCatalogTable(string name) : base("aws_glue_catalog_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string>? Owner
    {
        get => GetProperty<TerraformProperty<string>>("owner");
        set => this.WithProperty("owner", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retention attribute.
    /// </summary>
    public TerraformProperty<double>? Retention
    {
        get => GetProperty<TerraformProperty<double>>("retention");
        set => this.WithProperty("retention", value);
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformProperty<string>? TableType
    {
        get => GetProperty<TerraformProperty<string>>("table_type");
        set => this.WithProperty("table_type", value);
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformProperty<string>? ViewExpandedText
    {
        get => GetProperty<TerraformProperty<string>>("view_expanded_text");
        set => this.WithProperty("view_expanded_text", value);
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformProperty<string>? ViewOriginalText
    {
        get => GetProperty<TerraformProperty<string>>("view_original_text");
        set => this.WithProperty("view_original_text", value);
    }

    /// <summary>
    /// Block for open_table_format_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenTableFormatInput block(s) allowed")]
    public List<AwsGlueCatalogTableOpenTableFormatInputBlock>? OpenTableFormatInput
    {
        get => GetProperty<List<AwsGlueCatalogTableOpenTableFormatInputBlock>>("open_table_format_input");
        set => this.WithProperty("open_table_format_input", value);
    }

    /// <summary>
    /// Block for partition_index.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PartitionIndex block(s) allowed")]
    public List<AwsGlueCatalogTablePartitionIndexBlock>? PartitionIndex
    {
        get => GetProperty<List<AwsGlueCatalogTablePartitionIndexBlock>>("partition_index");
        set => this.WithProperty("partition_index", value);
    }

    /// <summary>
    /// Block for partition_keys.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCatalogTablePartitionKeysBlock>? PartitionKeys
    {
        get => GetProperty<List<AwsGlueCatalogTablePartitionKeysBlock>>("partition_keys");
        set => this.WithProperty("partition_keys", value);
    }

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public List<AwsGlueCatalogTableStorageDescriptorBlock>? StorageDescriptor
    {
        get => GetProperty<List<AwsGlueCatalogTableStorageDescriptorBlock>>("storage_descriptor");
        set => this.WithProperty("storage_descriptor", value);
    }

    /// <summary>
    /// Block for target_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTable block(s) allowed")]
    public List<AwsGlueCatalogTableTargetTableBlock>? TargetTable
    {
        get => GetProperty<List<AwsGlueCatalogTableTargetTableBlock>>("target_table");
        set => this.WithProperty("target_table", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
