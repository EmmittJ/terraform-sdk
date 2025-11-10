using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for caching_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverCachingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The caching_keys attribute.
    /// </summary>
    [TerraformPropertyName("caching_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CachingKeys { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Ttl { get; set; }

}

/// <summary>
/// Block type for pipeline_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverPipelineConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The functions attribute.
    /// </summary>
    [TerraformPropertyName("functions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Functions { get; set; }

}

/// <summary>
/// Block type for runtime in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverRuntimeBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformPropertyName("runtime_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuntimeVersion { get; set; }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverSyncConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    [TerraformPropertyName("conflict_detection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConflictDetection { get; set; }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    [TerraformPropertyName("conflict_handler")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConflictHandler { get; set; }

}

/// <summary>
/// Manages a aws_appsync_resolver resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncResolver : TerraformResource
{
    public AwsAppsyncResolver(string name) : base("aws_appsync_resolver", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformPropertyName("code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Code { get; set; }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    [TerraformPropertyName("data_source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataSource { get; set; }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformPropertyName("field")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Field { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Kind { get; set; }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    [TerraformPropertyName("max_batch_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxBatchSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_template attribute.
    /// </summary>
    [TerraformPropertyName("request_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestTemplate { get; set; }

    /// <summary>
    /// The response_template attribute.
    /// </summary>
    [TerraformPropertyName("response_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseTemplate { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for caching_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CachingConfig block(s) allowed")]
    [TerraformPropertyName("caching_config")]
    public TerraformList<TerraformBlock<AwsAppsyncResolverCachingConfigBlock>>? CachingConfig { get; set; } = new();

    /// <summary>
    /// Block for pipeline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineConfig block(s) allowed")]
    [TerraformPropertyName("pipeline_config")]
    public TerraformList<TerraformBlock<AwsAppsyncResolverPipelineConfigBlock>>? PipelineConfig { get; set; } = new();

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    [TerraformPropertyName("runtime")]
    public TerraformList<TerraformBlock<AwsAppsyncResolverRuntimeBlock>>? Runtime { get; set; } = new();

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    [TerraformPropertyName("sync_config")]
    public TerraformList<TerraformBlock<AwsAppsyncResolverSyncConfigBlock>>? SyncConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
