using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_record_tables in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueMlTransformInputRecordTablesBlock() : TerraformBlock("input_record_tables")
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueMlTransformParametersBlock() : TerraformBlock("parameters")
{
    /// <summary>
    /// The transform_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformType is required")]
    [TerraformProperty("transform_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TransformType { get; set; }

}

/// <summary>
/// Manages a aws_glue_ml_transform resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueMlTransform : TerraformResource
{
    public AwsGlueMlTransform(string name) : base("aws_glue_ml_transform", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformProperty("glue_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GlueVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformProperty("max_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The max_retries attribute.
    /// </summary>
    [TerraformProperty("max_retries")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxRetries { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformProperty("number_of_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfWorkers { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformProperty("worker_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkerType { get; set; }

    /// <summary>
    /// Block for input_record_tables.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputRecordTables is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputRecordTables block(s) required")]
    [TerraformProperty("input_record_tables")]
    public required TerraformList<AwsGlueMlTransformInputRecordTablesBlock> InputRecordTables { get; set; } = new();

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    [TerraformProperty("parameters")]
    public required TerraformList<AwsGlueMlTransformParametersBlock> Parameters { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The label_count attribute.
    /// </summary>
    [TerraformProperty("label_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LabelCount { get; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformProperty("schema")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Schema { get; }

}
