using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for caching_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncResolverCachingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The caching_keys attribute.
    /// </summary>
    [TerraformProperty("caching_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? CachingKeys { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Ttl { get; set; }

}

/// <summary>
/// Block type for pipeline_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncResolverPipelineConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The functions attribute.
    /// </summary>
    [TerraformProperty("functions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Functions { get; set; }

}

/// <summary>
/// Block type for runtime in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncResolverRuntimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformProperty("runtime_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuntimeVersion { get; set; }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncResolverSyncConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    [TerraformProperty("conflict_detection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConflictDetection { get; set; }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    [TerraformProperty("conflict_handler")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConflictHandler { get; set; }

}

/// <summary>
/// Manages a aws_appsync_resolver resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppsyncResolver : TerraformResource
{
    public AwsAppsyncResolver(string name) : base("aws_appsync_resolver", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformProperty("code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Code { get; set; }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [TerraformProperty("data_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataSource { get; set; }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformProperty("field")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Field { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    [TerraformProperty("max_batch_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxBatchSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_template attribute.
    /// </summary>
    [TerraformProperty("request_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestTemplate { get; set; }

    /// <summary>
    /// The response_template attribute.
    /// </summary>
    [TerraformProperty("response_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseTemplate { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for caching_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CachingConfig block(s) allowed")]
    [TerraformProperty("caching_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncResolverCachingConfigBlock>>? CachingConfig { get; set; }

    /// <summary>
    /// Block for pipeline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineConfig block(s) allowed")]
    [TerraformProperty("pipeline_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncResolverPipelineConfigBlock>>? PipelineConfig { get; set; }

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    [TerraformProperty("runtime")]
    public partial TerraformList<TerraformBlock<AwsAppsyncResolverRuntimeBlock>>? Runtime { get; set; }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    [TerraformProperty("sync_config")]
    public partial TerraformList<TerraformBlock<AwsAppsyncResolverSyncConfigBlock>>? SyncConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
