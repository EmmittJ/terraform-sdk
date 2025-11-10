using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for async_inference_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for data_capture_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationDataCaptureConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    [TerraformPropertyName("destination_s3_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationS3Uri { get; set; }

    /// <summary>
    /// The enable_capture attribute.
    /// </summary>
    [TerraformPropertyName("enable_capture")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableCapture { get; set; }

    /// <summary>
    /// The initial_sampling_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialSamplingPercentage is required")]
    [TerraformPropertyName("initial_sampling_percentage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> InitialSamplingPercentage { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for production_variants in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlock : ITerraformBlock
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceleratorType { get; set; }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("container_startup_health_check_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_ssm_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSsmAccess { get; set; }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    [TerraformPropertyName("inference_ami_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InferenceAmiVersion { get; set; }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("initial_instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialInstanceCount { get; set; }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    [TerraformPropertyName("initial_variant_weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialVariantWeight { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceType { get; set; }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("model_data_download_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformPropertyName("model_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ModelName { get; set; }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    [TerraformPropertyName("variant_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VariantName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "variant_name");

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("volume_size_in_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> VolumeSizeInGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "volume_size_in_gb");

}

/// <summary>
/// Block type for shadow_production_variants in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock : ITerraformBlock
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceleratorType { get; set; }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("container_startup_health_check_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_ssm_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSsmAccess { get; set; }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    [TerraformPropertyName("inference_ami_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InferenceAmiVersion { get; set; }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("initial_instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialInstanceCount { get; set; }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    [TerraformPropertyName("initial_variant_weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialVariantWeight { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceType { get; set; }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("model_data_download_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformPropertyName("model_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ModelName { get; set; }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    [TerraformPropertyName("variant_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VariantName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "variant_name");

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("volume_size_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VolumeSizeInGb { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for async_inference_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncInferenceConfig block(s) allowed")]
    [TerraformPropertyName("async_inference_config")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>>? AsyncInferenceConfig { get; set; } = new();

    /// <summary>
    /// Block for data_capture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCaptureConfig block(s) allowed")]
    [TerraformPropertyName("data_capture_config")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>>? DataCaptureConfig { get; set; } = new();

    /// <summary>
    /// Block for production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductionVariants is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProductionVariants block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ProductionVariants block(s) allowed")]
    [TerraformPropertyName("production_variants")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationProductionVariantsBlock>>? ProductionVariants { get; set; } = new();

    /// <summary>
    /// Block for shadow_production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ShadowProductionVariants block(s) allowed")]
    [TerraformPropertyName("shadow_production_variants")]
    public TerraformList<TerraformBlock<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>>? ShadowProductionVariants { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
