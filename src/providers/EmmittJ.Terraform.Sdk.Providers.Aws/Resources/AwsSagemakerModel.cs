using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlock : ITerraformBlock
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    [TerraformPropertyName("container_hostname")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerHostname { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Image { get; set; }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    [TerraformPropertyName("inference_specification_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InferenceSpecificationName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    [TerraformPropertyName("model_data_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ModelDataUrl { get; set; }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    [TerraformPropertyName("model_package_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ModelPackageName { get; set; }

}

/// <summary>
/// Block type for inference_execution_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelInferenceExecutionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

}

/// <summary>
/// Block type for primary_container in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlock : ITerraformBlock
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    [TerraformPropertyName("container_hostname")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerHostname { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Image { get; set; }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    [TerraformPropertyName("inference_specification_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InferenceSpecificationName { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    [TerraformPropertyName("model_data_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ModelDataUrl { get; set; }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    [TerraformPropertyName("model_package_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ModelPackageName { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Subnets { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("container")]
    public TerraformList<TerraformBlock<AwsSagemakerModelContainerBlock>>? Container { get; set; } = new();

    /// <summary>
    /// Block for inference_execution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InferenceExecutionConfig block(s) allowed")]
    [TerraformPropertyName("inference_execution_config")]
    public TerraformList<TerraformBlock<AwsSagemakerModelInferenceExecutionConfigBlock>>? InferenceExecutionConfig { get; set; } = new();

    /// <summary>
    /// Block for primary_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryContainer block(s) allowed")]
    [TerraformPropertyName("primary_container")]
    public TerraformList<TerraformBlock<AwsSagemakerModelPrimaryContainerBlock>>? PrimaryContainer { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsSagemakerModelVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
