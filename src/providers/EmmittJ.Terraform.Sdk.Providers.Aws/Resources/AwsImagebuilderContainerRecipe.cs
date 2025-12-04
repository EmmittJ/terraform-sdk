using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for component in AwsImagebuilderContainerRecipe.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeComponentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component";

    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    public required TerraformValue<string> ComponentArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("component_arn");
        set => SetArgument("component_arn", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderContainerRecipeComponentBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsImagebuilderContainerRecipeComponentBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsImagebuilderContainerRecipeComponentBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderContainerRecipeComponentBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for instance_configuration in AwsImagebuilderContainerRecipe.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeInstanceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_configuration";

    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// BlockDeviceMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlock>? BlockDeviceMapping
    {
        get => GetArgument<TerraformSet<AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlock>>("block_device_mapping");
        set => SetArgument("block_device_mapping", value);
    }

}

/// <summary>
/// Block type for block_device_mapping in AwsImagebuilderContainerRecipeInstanceConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block_device_mapping";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformValue<bool> NoDevice
    {
        get => GetArgument<TerraformValue<bool>>("no_device") ?? AsReference("no_device");
        set => SetArgument("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualName
    {
        get => GetArgument<TerraformValue<string>>("virtual_name");
        set => SetArgument("virtual_name", value);
    }

    /// <summary>
    /// Ebs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ebs block(s) allowed")]
    public TerraformList<AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlockEbsBlock>? Ebs
    {
        get => GetArgument<TerraformList<AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlockEbsBlock>>("ebs");
        set => SetArgument("ebs", value);
    }

}

/// <summary>
/// Block type for ebs in AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlock.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeInstanceConfigurationBlockBlockDeviceMappingBlockEbsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<string>? DeleteOnTermination
    {
        get => GetArgument<TerraformValue<string>>("delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<string>? Encrypted
    {
        get => GetArgument<TerraformValue<string>>("encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotId
    {
        get => GetArgument<TerraformValue<string>>("snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput");
        set => SetArgument("throughput", value);
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
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for target_repository in AwsImagebuilderContainerRecipe.
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeTargetRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_repository";

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Represents a aws_imagebuilder_container_recipe Terraform resource.
/// Manages a aws_imagebuilder_container_recipe resource.
/// </summary>
public partial class AwsImagebuilderContainerRecipe(string name) : TerraformResource("aws_imagebuilder_container_recipe", name)
{
    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerType is required")]
    public required TerraformValue<string> ContainerType
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_type");
        set => SetArgument("container_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformValue<string> DockerfileTemplateData
    {
        get => GetArgument<TerraformValue<string>>("dockerfile_template_data") ?? AsReference("dockerfile_template_data");
        set => SetArgument("dockerfile_template_data", value);
    }

    /// <summary>
    /// The dockerfile_template_uri attribute.
    /// </summary>
    public TerraformValue<string>? DockerfileTemplateUri
    {
        get => GetArgument<TerraformValue<string>>("dockerfile_template_uri");
        set => SetArgument("dockerfile_template_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    public required TerraformValue<string> ParentImage
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent_image");
        set => SetArgument("parent_image", value);
    }

    /// <summary>
    /// The platform_override attribute.
    /// </summary>
    public TerraformValue<string>? PlatformOverride
    {
        get => GetArgument<TerraformValue<string>>("platform_override");
        set => SetArgument("platform_override", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string>? WorkingDirectory
    {
        get => GetArgument<TerraformValue<string>>("working_directory");
        set => SetArgument("working_directory", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => AsReference("date_created");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
        => AsReference("platform");

    /// <summary>
    /// Component block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    public required TerraformList<AwsImagebuilderContainerRecipeComponentBlock> Component
    {
        get => GetRequiredArgument<TerraformList<AwsImagebuilderContainerRecipeComponentBlock>>("component");
        set => SetArgument("component", value);
    }

    /// <summary>
    /// InstanceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    public TerraformList<AwsImagebuilderContainerRecipeInstanceConfigurationBlock>? InstanceConfiguration
    {
        get => GetArgument<TerraformList<AwsImagebuilderContainerRecipeInstanceConfigurationBlock>>("instance_configuration");
        set => SetArgument("instance_configuration", value);
    }

    /// <summary>
    /// TargetRepository block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetRepository block(s) allowed")]
    public required TerraformList<AwsImagebuilderContainerRecipeTargetRepositoryBlock> TargetRepository
    {
        get => GetRequiredArgument<TerraformList<AwsImagebuilderContainerRecipeTargetRepositoryBlock>>("target_repository");
        set => SetArgument("target_repository", value);
    }

}
