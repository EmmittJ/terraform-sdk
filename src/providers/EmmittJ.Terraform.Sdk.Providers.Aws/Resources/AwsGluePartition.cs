using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_descriptor in .
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlock : TerraformBlock
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
/// Manages a aws_glue_partition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGluePartition : TerraformResource
{
    public AwsGluePartition(string name) : base("aws_glue_partition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_time");
        this.WithOutput("last_accessed_time");
        this.WithOutput("last_analyzed_time");
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
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The partition_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionValues is required")]
    public List<TerraformProperty<string>>? PartitionValues
    {
        get => GetProperty<List<TerraformProperty<string>>>("partition_values");
        set => this.WithProperty("partition_values", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public List<AwsGluePartitionStorageDescriptorBlock>? StorageDescriptor
    {
        get => GetProperty<List<AwsGluePartitionStorageDescriptorBlock>>("storage_descriptor");
        set => this.WithProperty("storage_descriptor", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The last_accessed_time attribute.
    /// </summary>
    public TerraformExpression LastAccessedTime => this["last_accessed_time"];

    /// <summary>
    /// The last_analyzed_time attribute.
    /// </summary>
    public TerraformExpression LastAnalyzedTime => this["last_analyzed_time"];

}
