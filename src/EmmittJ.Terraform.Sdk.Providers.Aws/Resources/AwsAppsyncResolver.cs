using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for caching_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverCachingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The caching_keys attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CachingKeys
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("caching_keys");
        set => WithProperty("caching_keys", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => WithProperty("ttl", value);
    }

}

/// <summary>
/// Block type for pipeline_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverPipelineConfigBlock : TerraformBlock
{
    /// <summary>
    /// The functions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Functions
    {
        get => GetProperty<List<TerraformProperty<string>>>("functions");
        set => WithProperty("functions", value);
    }

}

/// <summary>
/// Block type for runtime in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverRuntimeBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformProperty<string> RuntimeVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("runtime_version");
        set => WithProperty("runtime_version", value);
    }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncResolverSyncConfigBlock : TerraformBlock
{
    /// <summary>
    /// The conflict_detection attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictDetection
    {
        get => GetProperty<TerraformProperty<string>>("conflict_detection");
        set => WithProperty("conflict_detection", value);
    }

    /// <summary>
    /// The conflict_handler attribute.
    /// </summary>
    public TerraformProperty<string>? ConflictHandler
    {
        get => GetProperty<TerraformProperty<string>>("conflict_handler");
        set => WithProperty("conflict_handler", value);
    }

}

/// <summary>
/// Manages a aws_appsync_resolver resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppsyncResolver : TerraformResource
{
    public AwsAppsyncResolver(string name) : base("aws_appsync_resolver", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformProperty<string>? Code
    {
        get => GetProperty<TerraformProperty<string>>("code");
        set => this.WithProperty("code", value);
    }

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformProperty<string>? DataSource
    {
        get => GetProperty<TerraformProperty<string>>("data_source");
        set => this.WithProperty("data_source", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformProperty<string> Field
    {
        get => GetRequiredProperty<TerraformProperty<string>>("field");
        set => this.WithProperty("field", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The max_batch_size attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBatchSize
    {
        get => GetProperty<TerraformProperty<double>>("max_batch_size");
        set => this.WithProperty("max_batch_size", value);
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
    /// The request_template attribute.
    /// </summary>
    public TerraformProperty<string>? RequestTemplate
    {
        get => GetProperty<TerraformProperty<string>>("request_template");
        set => this.WithProperty("request_template", value);
    }

    /// <summary>
    /// The response_template attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseTemplate
    {
        get => GetProperty<TerraformProperty<string>>("response_template");
        set => this.WithProperty("response_template", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for caching_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CachingConfig block(s) allowed")]
    public List<AwsAppsyncResolverCachingConfigBlock>? CachingConfig
    {
        get => GetProperty<List<AwsAppsyncResolverCachingConfigBlock>>("caching_config");
        set => this.WithProperty("caching_config", value);
    }

    /// <summary>
    /// Block for pipeline_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PipelineConfig block(s) allowed")]
    public List<AwsAppsyncResolverPipelineConfigBlock>? PipelineConfig
    {
        get => GetProperty<List<AwsAppsyncResolverPipelineConfigBlock>>("pipeline_config");
        set => this.WithProperty("pipeline_config", value);
    }

    /// <summary>
    /// Block for runtime.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Runtime block(s) allowed")]
    public List<AwsAppsyncResolverRuntimeBlock>? Runtime
    {
        get => GetProperty<List<AwsAppsyncResolverRuntimeBlock>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public List<AwsAppsyncResolverSyncConfigBlock>? SyncConfig
    {
        get => GetProperty<List<AwsAppsyncResolverSyncConfigBlock>>("sync_config");
        set => this.WithProperty("sync_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
