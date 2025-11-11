using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for runtime in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionRuntimeBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformPropertyName("runtime_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuntimeVersion { get; set; }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncFunctionSyncConfigBlock
{
    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    [TerraformPropertyName("conflict_detection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConflictDetection { get; set; }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    [TerraformPropertyName("conflict_handler")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConflictHandler { get; set; }

}

/// <summary>
/// Manages a aws_appsync_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncFunction : TerraformResource
{
    public AwsAppsyncFunction(string name) : base("aws_appsync_function", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformPropertyName("code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Code { get; set; }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSource is required")]
    [TerraformPropertyName("data_source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataSource { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    [TerraformPropertyName("function_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FunctionVersion { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    [TerraformPropertyName("max_batch_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxBatchSize { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The request_mapping_template attribute.
    /// </summary>
    [TerraformPropertyName("request_mapping_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RequestMappingTemplate { get; set; }

    /// <summary>
    /// The response_mapping_template attribute.
    /// </summary>
    [TerraformPropertyName("response_mapping_template")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResponseMappingTemplate { get; set; }

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    [TerraformPropertyName("runtime")]
    public TerraformList<TerraformBlock<AwsAppsyncFunctionRuntimeBlock>>? Runtime { get; set; }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    [TerraformPropertyName("sync_config")]
    public TerraformList<TerraformBlock<AwsAppsyncFunctionSyncConfigBlock>>? SyncConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The function_id attribute.
    /// </summary>
    [TerraformPropertyName("function_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionId => new TerraformReference(this, "function_id");

}
