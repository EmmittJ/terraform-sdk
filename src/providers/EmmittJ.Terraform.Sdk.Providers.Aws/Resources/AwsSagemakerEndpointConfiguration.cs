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
        set => SetProperty("destination_s3_uri", value);
    }

    /// <summary>
    /// The enable_capture attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableCapture
    {
        set => SetProperty("enable_capture", value);
    }

    /// <summary>
    /// The initial_sampling_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialSamplingPercentage is required")]
    public required TerraformProperty<double> InitialSamplingPercentage
    {
        set => SetProperty("initial_sampling_percentage", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
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
        set => SetProperty("accelerator_type", value);
    }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerStartupHealthCheckTimeoutInSeconds
    {
        set => SetProperty("container_startup_health_check_timeout_in_seconds", value);
    }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSsmAccess
    {
        set => SetProperty("enable_ssm_access", value);
    }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceAmiVersion
    {
        set => SetProperty("inference_ami_version", value);
    }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InitialInstanceCount
    {
        set => SetProperty("initial_instance_count", value);
    }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    public TerraformProperty<double>? InitialVariantWeight
    {
        set => SetProperty("initial_variant_weight", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ModelDataDownloadTimeoutInSeconds
    {
        set => SetProperty("model_data_download_timeout_in_seconds", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformProperty<string> ModelName
    {
        set => SetProperty("model_name", value);
    }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    public TerraformProperty<string>? VariantName
    {
        set => SetProperty("variant_name", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSizeInGb
    {
        set => SetProperty("volume_size_in_gb", value);
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
        set => SetProperty("accelerator_type", value);
    }

    /// <summary>
    /// The container_startup_health_check_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ContainerStartupHealthCheckTimeoutInSeconds
    {
        set => SetProperty("container_startup_health_check_timeout_in_seconds", value);
    }

    /// <summary>
    /// The enable_ssm_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSsmAccess
    {
        set => SetProperty("enable_ssm_access", value);
    }

    /// <summary>
    /// The inference_ami_version attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceAmiVersion
    {
        set => SetProperty("inference_ami_version", value);
    }

    /// <summary>
    /// The initial_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InitialInstanceCount
    {
        set => SetProperty("initial_instance_count", value);
    }

    /// <summary>
    /// The initial_variant_weight attribute.
    /// </summary>
    public TerraformProperty<double>? InitialVariantWeight
    {
        set => SetProperty("initial_variant_weight", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The model_data_download_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ModelDataDownloadTimeoutInSeconds
    {
        set => SetProperty("model_data_download_timeout_in_seconds", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformProperty<string> ModelName
    {
        set => SetProperty("model_name", value);
    }

    /// <summary>
    /// The variant_name attribute.
    /// </summary>
    public TerraformProperty<string>? VariantName
    {
        set => SetProperty("variant_name", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSizeInGb
    {
        set => SetProperty("volume_size_in_gb", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for async_inference_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AsyncInferenceConfig block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationAsyncInferenceConfigBlock>? AsyncInferenceConfig
    {
        set => SetProperty("async_inference_config", value);
    }

    /// <summary>
    /// Block for data_capture_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCaptureConfig block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationDataCaptureConfigBlock>? DataCaptureConfig
    {
        set => SetProperty("data_capture_config", value);
    }

    /// <summary>
    /// Block for production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductionVariants is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProductionVariants block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ProductionVariants block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationProductionVariantsBlock>? ProductionVariants
    {
        set => SetProperty("production_variants", value);
    }

    /// <summary>
    /// Block for shadow_production_variants.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 ShadowProductionVariants block(s) allowed")]
    public List<AwsSagemakerEndpointConfigurationShadowProductionVariantsBlock>? ShadowProductionVariants
    {
        set => SetProperty("shadow_production_variants", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
