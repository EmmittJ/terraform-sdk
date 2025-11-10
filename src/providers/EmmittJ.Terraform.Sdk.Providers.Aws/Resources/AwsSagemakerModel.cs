using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelContainerBlock : TerraformBlock
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerHostname
    {
        set => SetProperty("container_hostname", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceSpecificationName
    {
        set => SetProperty("inference_specification_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    public TerraformProperty<string>? ModelDataUrl
    {
        set => SetProperty("model_data_url", value);
    }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    public TerraformProperty<string>? ModelPackageName
    {
        set => SetProperty("model_package_name", value);
    }

}

/// <summary>
/// Block type for inference_execution_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelInferenceExecutionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for primary_container in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelPrimaryContainerBlock : TerraformBlock
{
    /// <summary>
    /// The container_hostname attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerHostname
    {
        set => SetProperty("container_hostname", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceSpecificationName
    {
        set => SetProperty("inference_specification_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    public TerraformProperty<string>? ModelDataUrl
    {
        set => SetProperty("model_data_url", value);
    }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    public TerraformProperty<string>? ModelPackageName
    {
        set => SetProperty("model_package_name", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerModelVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_model resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerModel : TerraformResource
{
    public AwsSagemakerModel(string name) : base("aws_sagemaker_model", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("enable_network_isolation");
        SetOutput("execution_role_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    public TerraformProperty<bool> EnableNetworkIsolation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_network_isolation");
        set => SetProperty("enable_network_isolation", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSagemakerModelContainerBlock>? Container
    {
        set => SetProperty("container", value);
    }

    /// <summary>
    /// Block for inference_execution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InferenceExecutionConfig block(s) allowed")]
    public List<AwsSagemakerModelInferenceExecutionConfigBlock>? InferenceExecutionConfig
    {
        set => SetProperty("inference_execution_config", value);
    }

    /// <summary>
    /// Block for primary_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryContainer block(s) allowed")]
    public List<AwsSagemakerModelPrimaryContainerBlock>? PrimaryContainer
    {
        set => SetProperty("primary_container", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsSagemakerModelVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
