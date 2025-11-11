using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for async_inference_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock
{
}

/// <summary>
/// Block type for data_capture_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationDataCaptureConfigBlock
{
    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    [TerraformPropertyName("destination_s3_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DestinationS3Uri { get; set; }

    /// <summary>
    /// The enable_capture attribute.
    /// </summary>
    [TerraformPropertyName("enable_capture")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableCapture { get; set; }

    /// <summary>
    /// The initial_sampling_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialSamplingPercentage is required")]
    [TerraformPropertyName("initial_sampling_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> InitialSamplingPercentage { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for production_variants in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlock
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("container_startup_health_check_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_ssm_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableSsmAccess { get; set; }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    [TerraformPropertyName("inference_ami_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InferenceAmiVersion { get; set; }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("initial_instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InitialInstanceCount { get; set; }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    [TerraformPropertyName("initial_variant_weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InitialVariantWeight { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("model_data_download_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformPropertyName("model_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ModelName { get; set; }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    [TerraformPropertyName("variant_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VariantName { get; set; } = default!;

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("volume_size_in_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> VolumeSizeInGb { get; set; } = default!;

}

/// <summary>
/// Block type for shadow_production_variants in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("container_startup_health_check_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_ssm_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableSsmAccess { get; set; }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    [TerraformPropertyName("inference_ami_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InferenceAmiVersion { get; set; }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("initial_instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InitialInstanceCount { get; set; }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    [TerraformPropertyName("initial_variant_weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InitialVariantWeight { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("model_data_download_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformPropertyName("model_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ModelName { get; set; }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    [TerraformPropertyName("variant_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VariantName { get; set; } = default!;

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("volume_size_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VolumeSizeInGb { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_endpoint_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerEndpointConfiguration : TerraformResource
{
    public AwsSagemakerEndpointConfiguration(string name) : base("aws_sagemaker_endpoint_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for async_inference_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncInferenceConfig block(s) allowed")]
    [TerraformPropertyName("async_inference_config")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>>? AsyncInferenceConfig { get; set; }

    /// <summary>
    /// Block for data_capture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCaptureConfig block(s) allowed")]
    [TerraformPropertyName("data_capture_config")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>>? DataCaptureConfig { get; set; }

    /// <summary>
    /// Block for production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductionVariants is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProductionVariants block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ProductionVariants block(s) allowed")]
    [TerraformPropertyName("production_variants")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationProductionVariantsBlock>>? ProductionVariants { get; set; }

    /// <summary>
    /// Block for shadow_production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ShadowProductionVariants block(s) allowed")]
    [TerraformPropertyName("shadow_production_variants")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>>? ShadowProductionVariants { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
