using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for async_inference_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock() : TerraformBlock("async_inference_config")
{
}

/// <summary>
/// Block type for data_capture_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerEndpointConfigurationDataCaptureConfigBlock() : TerraformBlock("data_capture_config")
{
    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    [TerraformProperty("destination_s3_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationS3Uri { get; set; }

    /// <summary>
    /// The enable_capture attribute.
    /// </summary>
    [TerraformProperty("enable_capture")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableCapture { get; set; }

    /// <summary>
    /// The initial_sampling_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialSamplingPercentage is required")]
    [TerraformProperty("initial_sampling_percentage")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> InitialSamplingPercentage { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for production_variants in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerEndpointConfigurationProductionVariantsBlock() : TerraformBlock("production_variants")
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformProperty("accelerator_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("container_startup_health_check_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    [TerraformProperty("enable_ssm_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSsmAccess { get; set; }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    [TerraformProperty("inference_ami_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InferenceAmiVersion { get; set; }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    [TerraformProperty("initial_instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialInstanceCount { get; set; }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    [TerraformProperty("initial_variant_weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialVariantWeight { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("model_data_download_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformProperty("model_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ModelName { get; set; }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    [TerraformProperty("variant_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VariantName { get; set; }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [TerraformProperty("volume_size_in_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> VolumeSizeInGb { get; set; }

}

/// <summary>
/// Block type for shadow_production_variants in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock() : TerraformBlock("shadow_production_variants")
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformProperty("accelerator_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("container_startup_health_check_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    [TerraformProperty("enable_ssm_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSsmAccess { get; set; }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    [TerraformProperty("inference_ami_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InferenceAmiVersion { get; set; }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    [TerraformProperty("initial_instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialInstanceCount { get; set; }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    [TerraformProperty("initial_variant_weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialVariantWeight { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("model_data_download_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformProperty("model_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ModelName { get; set; }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    [TerraformProperty("variant_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VariantName { get; set; }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [TerraformProperty("volume_size_in_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VolumeSizeInGb { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_endpoint_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerEndpointConfiguration : TerraformResource
{
    public AwsSagemakerEndpointConfiguration(string name) : base("aws_sagemaker_endpoint_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

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
    /// Block for async_inference_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncInferenceConfig block(s) allowed")]
    [TerraformProperty("async_inference_config")]
    public TerraformList<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock> AsyncInferenceConfig { get; set; } = new();

    /// <summary>
    /// Block for data_capture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCaptureConfig block(s) allowed")]
    [TerraformProperty("data_capture_config")]
    public TerraformList<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock> DataCaptureConfig { get; set; } = new();

    /// <summary>
    /// Block for production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductionVariants is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProductionVariants block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ProductionVariants block(s) allowed")]
    [TerraformProperty("production_variants")]
    public required TerraformList<AwsSagemakerEndpointConfigurationProductionVariantsBlock> ProductionVariants { get; set; } = new();

    /// <summary>
    /// Block for shadow_production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ShadowProductionVariants block(s) allowed")]
    [TerraformProperty("shadow_production_variants")]
    public TerraformList<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock> ShadowProductionVariants { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
