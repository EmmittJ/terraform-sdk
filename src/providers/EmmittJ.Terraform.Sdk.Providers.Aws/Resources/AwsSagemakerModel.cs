using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlock
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    [TerraformPropertyName("container_hostname")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerHostname { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Image { get; set; }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    [TerraformPropertyName("inference_specification_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InferenceSpecificationName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    [TerraformPropertyName("model_data_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ModelDataUrl { get; set; }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    [TerraformPropertyName("model_package_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ModelPackageName { get; set; }

}

/// <summary>
/// Block type for inference_execution_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelInferenceExecutionConfigBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for primary_container in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlock
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    [TerraformPropertyName("container_hostname")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerHostname { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Image { get; set; }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    [TerraformPropertyName("inference_specification_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InferenceSpecificationName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    [TerraformPropertyName("model_data_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ModelDataUrl { get; set; }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    [TerraformPropertyName("model_package_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ModelPackageName { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelVpcConfigBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_model resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerModel : TerraformResource
{
    public AwsSagemakerModel(string name) : base("aws_sagemaker_model", name)
    {
    }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_isolation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

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
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("container")]
    public TerraformList<TerraformBlock<AwsSagemakerModelContainerBlock>>? Container { get; set; }

    /// <summary>
    /// Block for inference_execution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InferenceExecutionConfig block(s) allowed")]
    [TerraformPropertyName("inference_execution_config")]
    public TerraformList<TerraformBlock<AwsSagemakerModelInferenceExecutionConfigBlock>>? InferenceExecutionConfig { get; set; }

    /// <summary>
    /// Block for primary_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryContainer block(s) allowed")]
    [TerraformPropertyName("primary_container")]
    public TerraformList<TerraformBlock<AwsSagemakerModelPrimaryContainerBlock>>? PrimaryContainer { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsSagemakerModelVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
