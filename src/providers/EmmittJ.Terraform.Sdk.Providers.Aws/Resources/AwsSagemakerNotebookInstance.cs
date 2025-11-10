using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_service_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The minimum_instance_metadata_service_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumInstanceMetadataServiceVersion
    {
        set => SetProperty("minimum_instance_metadata_service_version", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_notebook_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerNotebookInstance : TerraformResource
{
    public AwsSagemakerNotebookInstance(string name) : base("aws_sagemaker_notebook_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("network_interface_id");
        SetOutput("url");
        SetOutput("additional_code_repositories");
        SetOutput("default_code_repository");
        SetOutput("direct_internet_access");
        SetOutput("id");
        SetOutput("instance_type");
        SetOutput("kms_key_id");
        SetOutput("lifecycle_config_name");
        SetOutput("name");
        SetOutput("platform_identifier");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("root_access");
        SetOutput("security_groups");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("volume_size");
    }

    /// <summary>
    /// The additional_code_repositories attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AdditionalCodeRepositories
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("additional_code_repositories");
        set => SetProperty("additional_code_repositories", value);
    }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    public TerraformProperty<string> DefaultCodeRepository
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_code_repository");
        set => SetProperty("default_code_repository", value);
    }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    public TerraformProperty<string> DirectInternetAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("direct_internet_access");
        set => SetProperty("direct_internet_access", value);
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
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    public TerraformProperty<string> LifecycleConfigName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifecycle_config_name");
        set => SetProperty("lifecycle_config_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    public TerraformProperty<string> PlatformIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_identifier");
        set => SetProperty("platform_identifier", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    public TerraformProperty<string> RootAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("root_access");
        set => SetProperty("root_access", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_groups");
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double> VolumeSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("volume_size");
        set => SetProperty("volume_size", value);
    }

    /// <summary>
    /// Block for instance_metadata_service_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataServiceConfiguration block(s) allowed")]
    public List<AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock>? InstanceMetadataServiceConfiguration
    {
        set => SetProperty("instance_metadata_service_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
