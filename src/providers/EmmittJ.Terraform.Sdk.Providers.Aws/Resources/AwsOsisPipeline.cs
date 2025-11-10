using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for buffer_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineBufferOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The persistent_buffer_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentBufferEnabled is required")]
    [TerraformPropertyName("persistent_buffer_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> PersistentBufferEnabled { get; set; }

}

/// <summary>
/// Block type for encryption_at_rest_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineEncryptionAtRestOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    [TerraformPropertyName("kms_key_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineLogPublishingOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The is_logging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("is_logging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsLoggingEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOsisPipelineTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public class AwsOsisPipelineVpcOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_endpoint_management attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_management")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcEndpointManagement { get; set; }

}

/// <summary>
/// Manages a aws_osis_pipeline resource.
/// </summary>
public class AwsOsisPipeline : TerraformResource
{
    public AwsOsisPipeline(string name) : base("aws_osis_pipeline", name)
    {
    }

    /// <summary>
    /// The max_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnits is required")]
    [TerraformPropertyName("max_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxUnits { get; set; }

    /// <summary>
    /// The min_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinUnits is required")]
    [TerraformPropertyName("min_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinUnits { get; set; }

    /// <summary>
    /// The pipeline_configuration_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineConfigurationBody is required")]
    [TerraformPropertyName("pipeline_configuration_body")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PipelineConfigurationBody { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    [TerraformPropertyName("pipeline_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PipelineName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for buffer_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("buffer_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineBufferOptionsBlock>>? BufferOptions { get; set; } = new();

    /// <summary>
    /// Block for encryption_at_rest_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("encryption_at_rest_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineEncryptionAtRestOptionsBlock>>? EncryptionAtRestOptions { get; set; } = new();

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("log_publishing_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineLogPublishingOptionsBlock>>? LogPublishingOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOsisPipelineTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vpc_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineVpcOptionsBlock>>? VpcOptions { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ingest_endpoint_urls attribute.
    /// </summary>
    [TerraformPropertyName("ingest_endpoint_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> IngestEndpointUrls => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ingest_endpoint_urls");

    /// <summary>
    /// The pipeline_arn attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PipelineArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pipeline_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
