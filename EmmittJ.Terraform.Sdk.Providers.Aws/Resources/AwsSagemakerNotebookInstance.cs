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
    /// The accelerator_types attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public HashSet<string>? AcceleratorTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("accelerator_types")?.Value;
        set => this.WithProperty("accelerator_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The additional_code_repositories attribute.
    /// </summary>
    public HashSet<string>? AdditionalCodeRepositories
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_code_repositories")?.Value;
        set => this.WithProperty("additional_code_repositories", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    public string? DefaultCodeRepository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_code_repository")?.Value;
        set => this.WithProperty("default_code_repository", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    public string? DirectInternetAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direct_internet_access")?.Value;
        set => this.WithProperty("direct_internet_access", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    public string? LifecycleConfigName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_config_name")?.Value;
        set => this.WithProperty("lifecycle_config_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    public string? PlatformIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_identifier")?.Value;
        set => this.WithProperty("platform_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    public string? RootAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("root_access")?.Value;
        set => this.WithProperty("root_access", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public double? VolumeSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_size")?.Value;
        set => this.WithProperty("volume_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
