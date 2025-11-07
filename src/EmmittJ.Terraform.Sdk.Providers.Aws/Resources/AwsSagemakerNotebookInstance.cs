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
    public TerraformLiteralProperty<HashSet<string>>? AdditionalCodeRepositories
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_code_repositories");
        set => this.WithProperty("additional_code_repositories", value);
    }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultCodeRepository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_code_repository");
        set => this.WithProperty("default_code_repository", value);
    }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DirectInternetAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direct_internet_access");
        set => this.WithProperty("direct_internet_access", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LifecycleConfigName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_config_name");
        set => this.WithProperty("lifecycle_config_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlatformIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_identifier");
        set => this.WithProperty("platform_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RootAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_access");
        set => this.WithProperty("root_access", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_size");
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
