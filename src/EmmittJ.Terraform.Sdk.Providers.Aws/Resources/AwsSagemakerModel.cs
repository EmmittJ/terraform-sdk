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
        get => GetProperty<TerraformProperty<string>>("container_hostname");
        set => WithProperty("container_hostname", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment");
        set => WithProperty("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
    }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceSpecificationName
    {
        get => GetProperty<TerraformProperty<string>>("inference_specification_name");
        set => WithProperty("inference_specification_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    public TerraformProperty<string>? ModelDataUrl
    {
        get => GetProperty<TerraformProperty<string>>("model_data_url");
        set => WithProperty("model_data_url", value);
    }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    public TerraformProperty<string>? ModelPackageName
    {
        get => GetProperty<TerraformProperty<string>>("model_package_name");
        set => WithProperty("model_package_name", value);
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
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
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
        get => GetProperty<TerraformProperty<string>>("container_hostname");
        set => WithProperty("container_hostname", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment");
        set => WithProperty("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
    }

    /// <summary>
    /// The inference_specification_name attribute.
    /// </summary>
    public TerraformProperty<string>? InferenceSpecificationName
    {
        get => GetProperty<TerraformProperty<string>>("inference_specification_name");
        set => WithProperty("inference_specification_name", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The model_data_url attribute.
    /// </summary>
    public TerraformProperty<string>? ModelDataUrl
    {
        get => GetProperty<TerraformProperty<string>>("model_data_url");
        set => WithProperty("model_data_url", value);
    }

    /// <summary>
    /// The model_package_name attribute.
    /// </summary>
    public TerraformProperty<string>? ModelPackageName
    {
        get => GetProperty<TerraformProperty<string>>("model_package_name");
        set => WithProperty("model_package_name", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableNetworkIsolation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_network_isolation");
        set => this.WithProperty("enable_network_isolation", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSagemakerModelContainerBlock>? Container
    {
        get => GetProperty<List<AwsSagemakerModelContainerBlock>>("container");
        set => this.WithProperty("container", value);
    }

    /// <summary>
    /// Block for inference_execution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InferenceExecutionConfig block(s) allowed")]
    public List<AwsSagemakerModelInferenceExecutionConfigBlock>? InferenceExecutionConfig
    {
        get => GetProperty<List<AwsSagemakerModelInferenceExecutionConfigBlock>>("inference_execution_config");
        set => this.WithProperty("inference_execution_config", value);
    }

    /// <summary>
    /// Block for primary_container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryContainer block(s) allowed")]
    public List<AwsSagemakerModelPrimaryContainerBlock>? PrimaryContainer
    {
        get => GetProperty<List<AwsSagemakerModelPrimaryContainerBlock>>("primary_container");
        set => this.WithProperty("primary_container", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsSagemakerModelVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsSagemakerModelVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
