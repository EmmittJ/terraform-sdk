using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for async_inference_config in AwsSagemakerEndpointConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "async_inference_config";

    /// <summary>
    /// ClientConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockClientConfigBlock>? ClientConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockClientConfigBlock>>("client_config");
        set => SetArgument("client_config", value);
    }

    /// <summary>
    /// OutputConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlock> OutputConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlock>>("output_config");
        set => SetArgument("output_config", value);
    }

}

/// <summary>
/// Block type for client_config in AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockClientConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_config";

    /// <summary>
    /// The max_concurrent_invocations_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentInvocationsPerInstance
    {
        get => new TerraformReference<double>(this, "max_concurrent_invocations_per_instance");
        set => SetArgument("max_concurrent_invocations_per_instance", value);
    }

}

/// <summary>
/// Block type for output_config in AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The s3_failure_path attribute.
    /// </summary>
    public TerraformValue<string>? S3FailurePath
    {
        get => new TerraformReference<string>(this, "s3_failure_path");
        set => SetArgument("s3_failure_path", value);
    }

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputPath is required")]
    public required TerraformValue<string> S3OutputPath
    {
        get => new TerraformReference<string>(this, "s3_output_path");
        set => SetArgument("s3_output_path", value);
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlockNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlockNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

}

/// <summary>
/// Block type for notification_config in AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlockOutputConfigBlockNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// The error_topic attribute.
    /// </summary>
    public TerraformValue<string>? ErrorTopic
    {
        get => new TerraformReference<string>(this, "error_topic");
        set => SetArgument("error_topic", value);
    }

    /// <summary>
    /// The include_inference_response_in attribute.
    /// </summary>
    public TerraformSet<string>? IncludeInferenceResponseIn
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "include_inference_response_in").ResolveNodes(ctx));
        set => SetArgument("include_inference_response_in", value);
    }

    /// <summary>
    /// The success_topic attribute.
    /// </summary>
    public TerraformValue<string>? SuccessTopic
    {
        get => new TerraformReference<string>(this, "success_topic");
        set => SetArgument("success_topic", value);
    }

}


/// <summary>
/// Block type for data_capture_config in AwsSagemakerEndpointConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationDataCaptureConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_capture_config";

    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    public required TerraformValue<string> DestinationS3Uri
    {
        get => new TerraformReference<string>(this, "destination_s3_uri");
        set => SetArgument("destination_s3_uri", value);
    }

    /// <summary>
    /// The enable_capture attribute.
    /// </summary>
    public TerraformValue<bool>? EnableCapture
    {
        get => new TerraformReference<bool>(this, "enable_capture");
        set => SetArgument("enable_capture", value);
    }

    /// <summary>
    /// The initial_sampling_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialSamplingPercentage is required")]
    public required TerraformValue<double> InitialSamplingPercentage
    {
        get => new TerraformReference<double>(this, "initial_sampling_percentage");
        set => SetArgument("initial_sampling_percentage", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// CaptureContentTypeHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaptureContentTypeHeader block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlockCaptureContentTypeHeaderBlock>? CaptureContentTypeHeader
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlockCaptureContentTypeHeaderBlock>>("capture_content_type_header");
        set => SetArgument("capture_content_type_header", value);
    }

    /// <summary>
    /// CaptureOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaptureOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CaptureOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 CaptureOptions block(s) allowed")]
    public required TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlockCaptureOptionsBlock> CaptureOptions
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlockCaptureOptionsBlock>>("capture_options");
        set => SetArgument("capture_options", value);
    }

}

/// <summary>
/// Block type for capture_content_type_header in AwsSagemakerEndpointConfigurationDataCaptureConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationDataCaptureConfigBlockCaptureContentTypeHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capture_content_type_header";

    /// <summary>
    /// The csv_content_types attribute.
    /// </summary>
    public TerraformSet<string>? CsvContentTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "csv_content_types").ResolveNodes(ctx));
        set => SetArgument("csv_content_types", value);
    }

    /// <summary>
    /// The json_content_types attribute.
    /// </summary>
    public TerraformSet<string>? JsonContentTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "json_content_types").ResolveNodes(ctx));
        set => SetArgument("json_content_types", value);
    }

}

/// <summary>
/// Block type for capture_options in AwsSagemakerEndpointConfigurationDataCaptureConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationDataCaptureConfigBlockCaptureOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capture_options";

    /// <summary>
    /// The capture_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaptureMode is required")]
    public required TerraformValue<string> CaptureMode
    {
        get => new TerraformReference<string>(this, "capture_mode");
        set => SetArgument("capture_mode", value);
    }

}


/// <summary>
/// Block type for production_variants in AwsSagemakerEndpointConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "production_variants";

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => new TerraformReference<string>(this, "accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ContainerStartupHealthCheckTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "container_startup_health_check_timeout_in_seconds");
        set => SetArgument("container_startup_health_check_timeout_in_seconds", value);
    }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    public TerraformValue<bool>? EnableSsmAccess
    {
        get => new TerraformReference<bool>(this, "enable_ssm_access");
        set => SetArgument("enable_ssm_access", value);
    }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    public TerraformValue<string>? InferenceAmiVersion
    {
        get => new TerraformReference<string>(this, "inference_ami_version");
        set => SetArgument("inference_ami_version", value);
    }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InitialInstanceCount
    {
        get => new TerraformReference<double>(this, "initial_instance_count");
        set => SetArgument("initial_instance_count", value);
    }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    public TerraformValue<double>? InitialVariantWeight
    {
        get => new TerraformReference<double>(this, "initial_variant_weight");
        set => SetArgument("initial_variant_weight", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ModelDataDownloadTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "model_data_download_timeout_in_seconds");
        set => SetArgument("model_data_download_timeout_in_seconds", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformValue<string> ModelName
    {
        get => new TerraformReference<string>(this, "model_name");
        set => SetArgument("model_name", value);
    }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    public TerraformValue<string> VariantName
    {
        get => new TerraformReference<string>(this, "variant_name");
        set => SetArgument("variant_name", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> VolumeSizeInGb
    {
        get => new TerraformReference<double>(this, "volume_size_in_gb");
        set => SetArgument("volume_size_in_gb", value);
    }

    /// <summary>
    /// CoreDumpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreDumpConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockCoreDumpConfigBlock>? CoreDumpConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockCoreDumpConfigBlock>>("core_dump_config");
        set => SetArgument("core_dump_config", value);
    }

    /// <summary>
    /// ManagedInstanceScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstanceScaling block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockManagedInstanceScalingBlock>? ManagedInstanceScaling
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockManagedInstanceScalingBlock>>("managed_instance_scaling");
        set => SetArgument("managed_instance_scaling", value);
    }

    /// <summary>
    /// RoutingConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockRoutingConfigBlock>? RoutingConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockRoutingConfigBlock>>("routing_config");
        set => SetArgument("routing_config", value);
    }

    /// <summary>
    /// ServerlessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockServerlessConfigBlock>? ServerlessConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlockServerlessConfigBlock>>("serverless_config");
        set => SetArgument("serverless_config", value);
    }

}

/// <summary>
/// Block type for core_dump_config in AwsSagemakerEndpointConfigurationProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlockCoreDumpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "core_dump_config";

    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    public required TerraformValue<string> DestinationS3Uri
    {
        get => new TerraformReference<string>(this, "destination_s3_uri");
        set => SetArgument("destination_s3_uri", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}

/// <summary>
/// Block type for managed_instance_scaling in AwsSagemakerEndpointConfigurationProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlockManagedInstanceScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_instance_scaling";

    /// <summary>
    /// The max_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxInstanceCount
    {
        get => new TerraformReference<double>(this, "max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// The min_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? MinInstanceCount
    {
        get => new TerraformReference<double>(this, "min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for routing_config in AwsSagemakerEndpointConfigurationProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlockRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_config";

    /// <summary>
    /// The routing_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingStrategy is required")]
    public required TerraformValue<string> RoutingStrategy
    {
        get => new TerraformReference<string>(this, "routing_strategy");
        set => SetArgument("routing_strategy", value);
    }

}

/// <summary>
/// Block type for serverless_config in AwsSagemakerEndpointConfigurationProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlockServerlessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serverless_config";

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConcurrency is required")]
    public required TerraformValue<double> MaxConcurrency
    {
        get => new TerraformReference<double>(this, "max_concurrency");
        set => SetArgument("max_concurrency", value);
    }

    /// <summary>
    /// The memory_size_in_mb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemorySizeInMb is required")]
    public required TerraformValue<double> MemorySizeInMb
    {
        get => new TerraformReference<double>(this, "memory_size_in_mb");
        set => SetArgument("memory_size_in_mb", value);
    }

    /// <summary>
    /// The provisioned_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? ProvisionedConcurrency
    {
        get => new TerraformReference<double>(this, "provisioned_concurrency");
        set => SetArgument("provisioned_concurrency", value);
    }

}


/// <summary>
/// Block type for shadow_production_variants in AwsSagemakerEndpointConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shadow_production_variants";

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => new TerraformReference<string>(this, "accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ContainerStartupHealthCheckTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "container_startup_health_check_timeout_in_seconds");
        set => SetArgument("container_startup_health_check_timeout_in_seconds", value);
    }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    public TerraformValue<bool>? EnableSsmAccess
    {
        get => new TerraformReference<bool>(this, "enable_ssm_access");
        set => SetArgument("enable_ssm_access", value);
    }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    public TerraformValue<string>? InferenceAmiVersion
    {
        get => new TerraformReference<string>(this, "inference_ami_version");
        set => SetArgument("inference_ami_version", value);
    }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InitialInstanceCount
    {
        get => new TerraformReference<double>(this, "initial_instance_count");
        set => SetArgument("initial_instance_count", value);
    }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    public TerraformValue<double>? InitialVariantWeight
    {
        get => new TerraformReference<double>(this, "initial_variant_weight");
        set => SetArgument("initial_variant_weight", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ModelDataDownloadTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "model_data_download_timeout_in_seconds");
        set => SetArgument("model_data_download_timeout_in_seconds", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformValue<string> ModelName
    {
        get => new TerraformReference<string>(this, "model_name");
        set => SetArgument("model_name", value);
    }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    public TerraformValue<string> VariantName
    {
        get => new TerraformReference<string>(this, "variant_name");
        set => SetArgument("variant_name", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSizeInGb
    {
        get => new TerraformReference<double>(this, "volume_size_in_gb");
        set => SetArgument("volume_size_in_gb", value);
    }

    /// <summary>
    /// CoreDumpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreDumpConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockCoreDumpConfigBlock>? CoreDumpConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockCoreDumpConfigBlock>>("core_dump_config");
        set => SetArgument("core_dump_config", value);
    }

    /// <summary>
    /// ManagedInstanceScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstanceScaling block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockManagedInstanceScalingBlock>? ManagedInstanceScaling
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockManagedInstanceScalingBlock>>("managed_instance_scaling");
        set => SetArgument("managed_instance_scaling", value);
    }

    /// <summary>
    /// RoutingConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockRoutingConfigBlock>? RoutingConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockRoutingConfigBlock>>("routing_config");
        set => SetArgument("routing_config", value);
    }

    /// <summary>
    /// ServerlessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockServerlessConfigBlock>? ServerlessConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockServerlessConfigBlock>>("serverless_config");
        set => SetArgument("serverless_config", value);
    }

}

/// <summary>
/// Block type for core_dump_config in AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockCoreDumpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "core_dump_config";

    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    public required TerraformValue<string> DestinationS3Uri
    {
        get => new TerraformReference<string>(this, "destination_s3_uri");
        set => SetArgument("destination_s3_uri", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}

/// <summary>
/// Block type for managed_instance_scaling in AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockManagedInstanceScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_instance_scaling";

    /// <summary>
    /// The max_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxInstanceCount
    {
        get => new TerraformReference<double>(this, "max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// The min_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? MinInstanceCount
    {
        get => new TerraformReference<double>(this, "min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for routing_config in AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_config";

    /// <summary>
    /// The routing_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingStrategy is required")]
    public required TerraformValue<string> RoutingStrategy
    {
        get => new TerraformReference<string>(this, "routing_strategy");
        set => SetArgument("routing_strategy", value);
    }

}

/// <summary>
/// Block type for serverless_config in AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlockServerlessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serverless_config";

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConcurrency is required")]
    public required TerraformValue<double> MaxConcurrency
    {
        get => new TerraformReference<double>(this, "max_concurrency");
        set => SetArgument("max_concurrency", value);
    }

    /// <summary>
    /// The memory_size_in_mb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemorySizeInMb is required")]
    public required TerraformValue<double> MemorySizeInMb
    {
        get => new TerraformReference<double>(this, "memory_size_in_mb");
        set => SetArgument("memory_size_in_mb", value);
    }

    /// <summary>
    /// The provisioned_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? ProvisionedConcurrency
    {
        get => new TerraformReference<double>(this, "provisioned_concurrency");
        set => SetArgument("provisioned_concurrency", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_endpoint_configuration Terraform resource.
/// Manages a aws_sagemaker_endpoint_configuration resource.
/// </summary>
public partial class AwsSagemakerEndpointConfiguration(string name) : TerraformResource("aws_sagemaker_endpoint_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// AsyncInferenceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncInferenceConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>? AsyncInferenceConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>>("async_inference_config");
        set => SetArgument("async_inference_config", value);
    }

    /// <summary>
    /// DataCaptureConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCaptureConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>? DataCaptureConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>>("data_capture_config");
        set => SetArgument("data_capture_config", value);
    }

    /// <summary>
    /// ProductionVariants block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductionVariants is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProductionVariants block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ProductionVariants block(s) allowed")]
    public required TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlock> ProductionVariants
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlock>>("production_variants");
        set => SetArgument("production_variants", value);
    }

    /// <summary>
    /// ShadowProductionVariants block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ShadowProductionVariants block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>? ShadowProductionVariants
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>>("shadow_production_variants");
        set => SetArgument("shadow_production_variants", value);
    }

}
