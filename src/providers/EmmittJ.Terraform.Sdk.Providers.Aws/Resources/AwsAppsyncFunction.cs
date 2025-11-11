using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for runtime in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncFunctionRuntimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformProperty("runtime_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuntimeVersion { get; set; }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncFunctionSyncConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    [TerraformProperty("conflict_detection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConflictDetection { get; set; }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    [TerraformProperty("conflict_handler")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConflictHandler { get; set; }

}

/// <summary>
/// Manages a aws_appsync_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppsyncFunction : TerraformResource
{
    public AwsAppsyncFunction(string name) : base("aws_appsync_function", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformProperty("code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Code { get; set; }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    [TerraformProperty("data_source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataSource { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    [TerraformProperty("function_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FunctionVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    [TerraformProperty("max_batch_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxBatchSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_mapping_template attribute.
    /// </summary>
    [TerraformProperty("request_mapping_template")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestMappingTemplate { get; set; }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    [TerraformProperty("response_mapping_template")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResponseMappingTemplate { get; set; }

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    [TerraformProperty("runtime")]
    public TerraformList<TerraformBlock<AwsAppsyncFunctionRuntimeBlock>>? Runtime { get; set; }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    [TerraformProperty("sync_config")]
    public TerraformList<TerraformBlock<AwsAppsyncFunctionSyncConfigBlock>>? SyncConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [TerraformProperty("function_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FunctionId { get; }

}
