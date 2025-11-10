using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for partition_index in .
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionIndexPartitionIndexBlock : TerraformBlock
{
    /// <summary>
    /// The index_name attribute.
    /// </summary>
    public TerraformProperty<string>? IndexName
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
    public List<TerraformProperty<string>>? Keys
    {
        set => SetProperty("keys", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGluePartitionIndexTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_glue_partition_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGluePartitionIndex : TerraformResource
{
    public AwsGluePartitionIndex(string name) : base("aws_glue_partition_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("catalog_id");
        SetOutput("database_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("table_name");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

    /// <summary>
    /// Block for partition_index.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionIndex is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartitionIndex block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionIndex block(s) allowed")]
    public List<AwsGluePartitionIndexPartitionIndexBlock>? PartitionIndex
    {
        set => SetProperty("partition_index", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGluePartitionIndexTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
