using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerModelContainerBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    [TerraformProperty("container_hostname")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerHostname { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformProperty("image")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Image { get; set; }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    [TerraformProperty("inference_specification_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InferenceSpecificationName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    [TerraformProperty("model_data_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ModelDataUrl { get; set; }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    [TerraformProperty("model_package_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ModelPackageName { get; set; }

}

/// <summary>
/// Block type for inference_execution_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerModelInferenceExecutionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for primary_container in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerModelPrimaryContainerBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    [TerraformProperty("container_hostname")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerHostname { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformProperty("image")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Image { get; set; }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    [TerraformProperty("inference_specification_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InferenceSpecificationName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    [TerraformProperty("model_data_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ModelDataUrl { get; set; }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    [TerraformProperty("model_package_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ModelPackageName { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerModelVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_model resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerModel : TerraformResource
{
    public AwsSagemakerModel(string name) : base("aws_sagemaker_model", name)
    {
    }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    [TerraformProperty("enable_network_isolation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

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
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("container")]
    public partial TerraformList<TerraformBlock<AwsSagemakerModelContainerBlock>>? Container { get; set; }

    /// <summary>
    /// Block for inference_execution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InferenceExecutionConfig block(s) allowed")]
    [TerraformProperty("inference_execution_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerModelInferenceExecutionConfigBlock>>? InferenceExecutionConfig { get; set; }

    /// <summary>
    /// Block for primary_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryContainer block(s) allowed")]
    [TerraformProperty("primary_container")]
    public partial TerraformList<TerraformBlock<AwsSagemakerModelPrimaryContainerBlock>>? PrimaryContainer { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerModelVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
