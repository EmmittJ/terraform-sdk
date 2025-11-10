using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_record_tables in .
/// Nesting mode: list
/// </summary>
public class AwsGlueMlTransformInputRecordTablesBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        set => SetProperty("connection_name", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        set => SetProperty("table_name", value);
    }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class AwsGlueMlTransformParametersBlock : TerraformBlock
{
    /// <summary>
    /// The transform_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformType is required")]
    public required TerraformProperty<string> TransformType
    {
        set => SetProperty("transform_type", value);
    }

}

/// <summary>
/// Manages a aws_glue_ml_transform resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueMlTransform : TerraformResource
{
    public AwsGlueMlTransform(string name) : base("aws_glue_ml_transform", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("label_count");
        SetOutput("schema");
        SetOutput("description");
        SetOutput("glue_version");
        SetOutput("id");
        SetOutput("max_capacity");
        SetOutput("max_retries");
        SetOutput("name");
        SetOutput("number_of_workers");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("timeout");
        SetOutput("worker_type");
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
    /// The glue_version attribute.
    /// </summary>
    public TerraformProperty<string> GlueVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("glue_version");
        set => SetProperty("glue_version", value);
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
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double> MaxCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_capacity");
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    public TerraformProperty<double> MaxRetries
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_retries");
        set => SetProperty("max_retries", value);
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
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfWorkers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_workers");
        set => SetProperty("number_of_workers", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformProperty<string> WorkerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("worker_type");
        set => SetProperty("worker_type", value);
    }

    /// <summary>
    /// Block for input_record_tables.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputRecordTables is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputRecordTables block(s) required")]
    public List<AwsGlueMlTransformInputRecordTablesBlock>? InputRecordTables
    {
        set => SetProperty("input_record_tables", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public List<AwsGlueMlTransformParametersBlock>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The label_count attribute.
    /// </summary>
    public TerraformExpression LabelCount => this["label_count"];

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformExpression Schema => this["schema"];

}
