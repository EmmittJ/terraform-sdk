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
        set => SetProperty("index_name", value);
    }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    public TerraformProperty<string>? IndexStatus
    {
        set => SetProperty("index_status", value);
    }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    public List<TerraformProperty<string>>? Keys
    {
        set => SetProperty("keys", value);
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
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("additional_locations", value);
    }

    /// <summary>
    /// The bucket_columns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? BucketColumns
    {
        set => SetProperty("bucket_columns", value);
    }

    /// <summary>
    /// The compressed attribute.
    /// </summary>
    public TerraformProperty<bool>? Compressed
    {
        set => SetProperty("compressed", value);
    }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    public TerraformProperty<string>? InputFormat
    {
        set => SetProperty("input_format", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The number_of_buckets attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfBuckets
    {
        set => SetProperty("number_of_buckets", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformProperty<string>? OutputFormat
    {
        set => SetProperty("output_format", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The stored_as_sub_directories attribute.
    /// </summary>
    public TerraformProperty<bool>? StoredAsSubDirectories
    {
        set => SetProperty("stored_as_sub_directories", value);
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
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
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
        SetOutput("arn");
        SetOutput("catalog_id");
        SetOutput("database_name");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("owner");
        SetOutput("parameters");
        SetOutput("region");
        SetOutput("retention");
        SetOutput("table_type");
        SetOutput("view_expanded_text");
        SetOutput("view_original_text");
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string> Owner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner");
        set => SetProperty("owner", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
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
    /// The retention attribute.
    /// </summary>
    public TerraformProperty<double> Retention
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention");
        set => SetProperty("retention", value);
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformProperty<string> TableType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_type");
        set => SetProperty("table_type", value);
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformProperty<string> ViewExpandedText
    {
        get => GetRequiredOutput<TerraformProperty<string>>("view_expanded_text");
        set => SetProperty("view_expanded_text", value);
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformProperty<string> ViewOriginalText
    {
        get => GetRequiredOutput<TerraformProperty<string>>("view_original_text");
        set => SetProperty("view_original_text", value);
    }

    /// <summary>
    /// Block for open_table_format_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenTableFormatInput block(s) allowed")]
    public List<AwsGlueCatalogTableOpenTableFormatInputBlock>? OpenTableFormatInput
    {
        set => SetProperty("open_table_format_input", value);
    }

    /// <summary>
    /// Block for partition_index.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PartitionIndex block(s) allowed")]
    public List<AwsGlueCatalogTablePartitionIndexBlock>? PartitionIndex
    {
        set => SetProperty("partition_index", value);
    }

    /// <summary>
    /// Block for partition_keys.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCatalogTablePartitionKeysBlock>? PartitionKeys
    {
        set => SetProperty("partition_keys", value);
    }

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public List<AwsGlueCatalogTableStorageDescriptorBlock>? StorageDescriptor
    {
        set => SetProperty("storage_descriptor", value);
    }

    /// <summary>
    /// Block for target_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTable block(s) allowed")]
    public List<AwsGlueCatalogTableTargetTableBlock>? TargetTable
    {
        set => SetProperty("target_table", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
