using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for buffer_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOsisPipelineBufferOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The persistent_buffer_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentBufferEnabled is required")]
    [TerraformProperty("persistent_buffer_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> PersistentBufferEnabled { get; set; }

}

/// <summary>
/// Block type for encryption_at_rest_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOsisPipelineEncryptionAtRestOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    [TerraformProperty("kms_key_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOsisPipelineLogPublishingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The is_logging_enabled attribute.
    /// </summary>
    [TerraformProperty("is_logging_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsLoggingEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOsisPipelineTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOsisPipelineVpcOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The vpc_endpoint_management attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_management")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VpcEndpointManagement { get; set; }

}

/// <summary>
/// Manages a aws_osis_pipeline resource.
/// </summary>
public partial class AwsOsisPipeline : TerraformResource
{
    public AwsOsisPipeline(string name) : base("aws_osis_pipeline", name)
    {
    }

    /// <summary>
    /// The max_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnits is required")]
    [TerraformProperty("max_units")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxUnits { get; set; }

    /// <summary>
    /// The min_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinUnits is required")]
    [TerraformProperty("min_units")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinUnits { get; set; }

    /// <summary>
    /// The pipeline_configuration_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineConfigurationBody is required")]
    [TerraformProperty("pipeline_configuration_body")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PipelineConfigurationBody { get; set; }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PipelineName is required")]
    [TerraformProperty("pipeline_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PipelineName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for buffer_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("buffer_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineBufferOptionsBlock>>? BufferOptions { get; set; }

    /// <summary>
    /// Block for encryption_at_rest_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("encryption_at_rest_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineEncryptionAtRestOptionsBlock>>? EncryptionAtRestOptions { get; set; }

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("log_publishing_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineLogPublishingOptionsBlock>>? LogPublishingOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsOsisPipelineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("vpc_options")]
    public TerraformList<TerraformBlock<AwsOsisPipelineVpcOptionsBlock>>? VpcOptions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The ingest_endpoint_urls attribute.
    /// </summary>
    [TerraformProperty("ingest_endpoint_urls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> IngestEndpointUrls { get; }

    /// <summary>
    /// The pipeline_arn attribute.
    /// </summary>
    [TerraformProperty("pipeline_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PipelineArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
