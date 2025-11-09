using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_notebook_instance resource.
/// </summary>
public class AwsSagemakerNotebookInstance : TerraformResource
{
    public AwsSagemakerNotebookInstance(string name) : base("aws_sagemaker_notebook_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The additional_code_repositories attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AdditionalCodeRepositories
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("additional_code_repositories");
        set => this.WithProperty("additional_code_repositories", value);
    }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultCodeRepository
    {
        get => GetProperty<TerraformProperty<string>>("default_code_repository");
        set => this.WithProperty("default_code_repository", value);
    }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    public TerraformProperty<string>? DirectInternetAccess
    {
        get => GetProperty<TerraformProperty<string>>("direct_internet_access");
        set => this.WithProperty("direct_internet_access", value);
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
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    public TerraformProperty<string>? LifecycleConfigName
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle_config_name");
        set => this.WithProperty("lifecycle_config_name", value);
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
    /// The platform_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("platform_identifier");
        set => this.WithProperty("platform_identifier", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    public TerraformProperty<string>? RootAccess
    {
        get => GetProperty<TerraformProperty<string>>("root_access");
        set => this.WithProperty("root_access", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => this.WithProperty("volume_size", value);
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
