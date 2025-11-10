using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for async_inference_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for data_capture_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationDataCaptureConfigBlock : TerraformBlock
{
    /// <summary>
    /// The destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationS3Uri is required")]
    public required TerraformProperty<string> DestinationS3Uri
    {
        get => GetProperty<TerraformProperty<string>>("destination_s3_uri");
        set => WithProperty("destination_s3_uri", value);
    }

    /// <summary>
    /// The enable_capture attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableCapture
    {
        get => GetProperty<TerraformProperty<bool>>("enable_capture");
        set => WithProperty("enable_capture", value);
    }

    /// <summary>
    /// The initial_sampling_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialSamplingPercentage is required")]
    public required TerraformProperty<double> InitialSamplingPercentage
    {
        get => GetProperty<TerraformProperty<double>>("initial_sampling_percentage");
        set => WithProperty("initial_sampling_percentage", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for production_variants in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationProductionVariantsBlock : TerraformBlock
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => WithProperty("accelerator_type", value);
    }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerStartupHealthCheckTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("container_startup_health_check_timeout_in_seconds");
        set => WithProperty("container_startup_health_check_timeout_in_seconds", value);
    }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSsmAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ssm_access");
        set => WithProperty("enable_ssm_access", value);
    }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceAmiVersion
    {
        get => GetProperty<TerraformProperty<string>>("inference_ami_version");
        set => WithProperty("inference_ami_version", value);
    }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InitialInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("initial_instance_count");
        set => WithProperty("initial_instance_count", value);
    }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    public TerraformProperty<double>? InitialVariantWeight
    {
        get => GetProperty<TerraformProperty<double>>("initial_variant_weight");
        set => WithProperty("initial_variant_weight", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ModelDataDownloadTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("model_data_download_timeout_in_seconds");
        set => WithProperty("model_data_download_timeout_in_seconds", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformProperty<string> ModelName
    {
        get => GetProperty<TerraformProperty<string>>("model_name");
        set => WithProperty("model_name", value);
    }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    public TerraformProperty<string>? VariantName
    {
        get => GetProperty<TerraformProperty<string>>("variant_name");
        set => WithProperty("variant_name", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("volume_size_in_gb");
        set => WithProperty("volume_size_in_gb", value);
    }

}

/// <summary>
/// Block type for shadow_production_variants in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock : TerraformBlock
{
    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => WithProperty("accelerator_type", value);
    }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerStartupHealthCheckTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("container_startup_health_check_timeout_in_seconds");
        set => WithProperty("container_startup_health_check_timeout_in_seconds", value);
    }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSsmAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ssm_access");
        set => WithProperty("enable_ssm_access", value);
    }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceAmiVersion
    {
        get => GetProperty<TerraformProperty<string>>("inference_ami_version");
        set => WithProperty("inference_ami_version", value);
    }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InitialInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("initial_instance_count");
        set => WithProperty("initial_instance_count", value);
    }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    public TerraformProperty<double>? InitialVariantWeight
    {
        get => GetProperty<TerraformProperty<double>>("initial_variant_weight");
        set => WithProperty("initial_variant_weight", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ModelDataDownloadTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("model_data_download_timeout_in_seconds");
        set => WithProperty("model_data_download_timeout_in_seconds", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformProperty<string> ModelName
    {
        get => GetProperty<TerraformProperty<string>>("model_name");
        set => WithProperty("model_name", value);
    }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    public TerraformProperty<string>? VariantName
    {
        get => GetProperty<TerraformProperty<string>>("variant_name");
        set => WithProperty("variant_name", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("volume_size_in_gb");
        set => WithProperty("volume_size_in_gb", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_endpoint_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerEndpointConfiguration : TerraformResource
{
    public AwsSagemakerEndpointConfiguration(string name) : base("aws_sagemaker_endpoint_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for async_inference_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncInferenceConfig block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>? AsyncInferenceConfig
    {
        get => GetProperty<List<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>>("async_inference_config");
        set => this.WithProperty("async_inference_config", value);
    }

    /// <summary>
    /// Block for data_capture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCaptureConfig block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>? DataCaptureConfig
    {
        get => GetProperty<List<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>>("data_capture_config");
        set => this.WithProperty("data_capture_config", value);
    }

    /// <summary>
    /// Block for production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProductionVariants block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ProductionVariants block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationProductionVariantsBlock>? ProductionVariants
    {
        get => GetProperty<List<AwsSagemakerEndpointConfigurationProductionVariantsBlock>>("production_variants");
        set => this.WithProperty("production_variants", value);
    }

    /// <summary>
    /// Block for shadow_production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ShadowProductionVariants block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>? ShadowProductionVariants
    {
        get => GetProperty<List<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>>("shadow_production_variants");
        set => this.WithProperty("shadow_production_variants", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
