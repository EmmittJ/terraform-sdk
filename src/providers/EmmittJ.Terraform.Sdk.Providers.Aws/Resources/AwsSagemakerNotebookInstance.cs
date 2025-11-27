using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_service_configuration in AwsSagemakerNotebookInstance.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_metadata_service_configuration";

    /// <summary>
    /// The minimum_instance_metadata_service_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumInstanceMetadataServiceVersion
    {
        get => new TerraformReference<string>(this, "minimum_instance_metadata_service_version");
        set => SetArgument("minimum_instance_metadata_service_version", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_notebook_instance Terraform resource.
/// Manages a aws_sagemaker_notebook_instance resource.
/// </summary>
public partial class AwsSagemakerNotebookInstance(string name) : TerraformResource("aws_sagemaker_notebook_instance", name)
{
    /// <summary>
    /// The additional_code_repositories attribute.
    /// </summary>
    public TerraformSet<string>? AdditionalCodeRepositories
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "additional_code_repositories").ResolveNodes(ctx));
        set => SetArgument("additional_code_repositories", value);
    }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    public TerraformValue<string>? DefaultCodeRepository
    {
        get => new TerraformReference<string>(this, "default_code_repository");
        set => SetArgument("default_code_repository", value);
    }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    public TerraformValue<string>? DirectInternetAccess
    {
        get => new TerraformReference<string>(this, "direct_internet_access");
        set => SetArgument("direct_internet_access", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigName
    {
        get => new TerraformReference<string>(this, "lifecycle_config_name");
        set => SetArgument("lifecycle_config_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    public TerraformValue<string> PlatformIdentifier
    {
        get => new TerraformReference<string>(this, "platform_identifier");
        set => SetArgument("platform_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    public TerraformValue<string>? RootAccess
    {
        get => new TerraformReference<string>(this, "root_access");
        set => SetArgument("root_access", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

    /// <summary>
    /// InstanceMetadataServiceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataServiceConfiguration block(s) allowed")]
    public TerraformList<AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock>? InstanceMetadataServiceConfiguration
    {
        get => GetArgument<TerraformList<AwsSagemakerNotebookInstanceInstanceMetadataServiceConfigurationBlock>>("instance_metadata_service_configuration");
        set => SetArgument("instance_metadata_service_configuration", value);
    }

}
