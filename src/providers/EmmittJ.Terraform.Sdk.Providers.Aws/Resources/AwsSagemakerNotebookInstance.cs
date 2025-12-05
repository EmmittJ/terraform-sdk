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
        get => GetArgument<TerraformValue<string>>("minimum_instance_metadata_service_version") ?? CreateReference("minimum_instance_metadata_service_version");
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
        get => GetArgument<TerraformSet<string>>("additional_code_repositories");
        set => SetArgument("additional_code_repositories", value);
    }

    /// <summary>
    /// The default_code_repository attribute.
    /// </summary>
    public TerraformValue<string>? DefaultCodeRepository
    {
        get => GetArgument<TerraformValue<string>>("default_code_repository");
        set => SetArgument("default_code_repository", value);
    }

    /// <summary>
    /// The direct_internet_access attribute.
    /// </summary>
    public TerraformValue<string>? DirectInternetAccess
    {
        get => GetArgument<TerraformValue<string>>("direct_internet_access");
        set => SetArgument("direct_internet_access", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The lifecycle_config_name attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigName
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_name");
        set => SetArgument("lifecycle_config_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform_identifier attribute.
    /// </summary>
    public TerraformValue<string> PlatformIdentifier
    {
        get => GetArgument<TerraformValue<string>>("platform_identifier") ?? CreateReference("platform_identifier");
        set => SetArgument("platform_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The root_access attribute.
    /// </summary>
    public TerraformValue<string>? RootAccess
    {
        get => GetArgument<TerraformValue<string>>("root_access");
        set => SetArgument("root_access", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups") ?? CreateReference("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSize
    {
        get => GetArgument<TerraformValue<double>>("volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkInterfaceId
        => CreateReference("network_interface_id");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => CreateReference("url");

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
