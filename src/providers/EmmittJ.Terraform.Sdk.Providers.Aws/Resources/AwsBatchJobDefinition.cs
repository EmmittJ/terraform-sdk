using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for eks_properties in AwsBatchJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eks_properties";

    /// <summary>
    /// PodProperties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodProperties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PodProperties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PodProperties block(s) allowed")]
    public required TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock> PodProperties
    {
        get => GetRequiredArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock>>("pod_properties");
        set => SetArgument("pod_properties", value);
    }

}

/// <summary>
/// Block type for pod_properties in AwsBatchJobDefinitionEksPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_properties";

    /// <summary>
    /// The dns_policy attribute.
    /// </summary>
    public TerraformValue<string>? DnsPolicy
    {
        get => GetArgument<TerraformValue<string>>("dns_policy");
        set => SetArgument("dns_policy", value);
    }

    /// <summary>
    /// The host_network attribute.
    /// </summary>
    public TerraformValue<bool>? HostNetwork
    {
        get => GetArgument<TerraformValue<bool>>("host_network");
        set => SetArgument("host_network", value);
    }

    /// <summary>
    /// The service_account_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccountName
    {
        get => GetArgument<TerraformValue<string>>("service_account_name");
        set => SetArgument("service_account_name", value);
    }

    /// <summary>
    /// The share_process_namespace attribute.
    /// </summary>
    public TerraformValue<bool>? ShareProcessNamespace
    {
        get => GetArgument<TerraformValue<bool>>("share_process_namespace");
        set => SetArgument("share_process_namespace", value);
    }

    /// <summary>
    /// Containers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Containers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Containers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Containers block(s) allowed")]
    public required TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock> Containers
    {
        get => GetRequiredArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock>>("containers");
        set => SetArgument("containers", value);
    }

    /// <summary>
    /// ImagePullSecret block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockImagePullSecretBlock>? ImagePullSecret
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockImagePullSecretBlock>>("image_pull_secret");
        set => SetArgument("image_pull_secret", value);
    }

    /// <summary>
    /// InitContainers block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 InitContainers block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock>? InitContainers
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock>>("init_containers");
        set => SetArgument("init_containers", value);
    }

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Volumes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlock>? Volumes
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlock>>("volumes");
        set => SetArgument("volumes", value);
    }

}

/// <summary>
/// Block type for containers in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containers";

    /// <summary>
    /// The args attribute.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetRequiredArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The image_pull_policy attribute.
    /// </summary>
    public TerraformValue<string>? ImagePullPolicy
    {
        get => GetArgument<TerraformValue<string>>("image_pull_policy");
        set => SetArgument("image_pull_policy", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Env block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// SecurityContext block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityContext block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockSecurityContextBlock>? SecurityContext
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockSecurityContextBlock>>("security_context");
        set => SetArgument("security_context", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock.
/// Nesting mode: set
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

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
/// Block type for resources in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// The limits attribute.
    /// </summary>
    public TerraformMap<string>? Limits
    {
        get => GetArgument<TerraformMap<string>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// The requests attribute.
    /// </summary>
    public TerraformMap<string>? Requests
    {
        get => GetArgument<TerraformMap<string>>("requests");
        set => SetArgument("requests", value);
    }

}

/// <summary>
/// Block type for security_context in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockSecurityContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_context";

    /// <summary>
    /// The privileged attribute.
    /// </summary>
    public TerraformValue<bool>? Privileged
    {
        get => GetArgument<TerraformValue<bool>>("privileged");
        set => SetArgument("privileged", value);
    }

    /// <summary>
    /// The read_only_root_file_system attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyRootFileSystem
    {
        get => GetArgument<TerraformValue<bool>>("read_only_root_file_system");
        set => SetArgument("read_only_root_file_system", value);
    }

    /// <summary>
    /// The run_as_group attribute.
    /// </summary>
    public TerraformValue<double>? RunAsGroup
    {
        get => GetArgument<TerraformValue<double>>("run_as_group");
        set => SetArgument("run_as_group", value);
    }

    /// <summary>
    /// The run_as_non_root attribute.
    /// </summary>
    public TerraformValue<bool>? RunAsNonRoot
    {
        get => GetArgument<TerraformValue<bool>>("run_as_non_root");
        set => SetArgument("run_as_non_root", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public TerraformValue<double>? RunAsUser
    {
        get => GetArgument<TerraformValue<double>>("run_as_user");
        set => SetArgument("run_as_user", value);
    }

}

/// <summary>
/// Block type for volume_mounts in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockContainersBlockVolumeMountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_mounts";

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
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
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

}

/// <summary>
/// Block type for image_pull_secret in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockImagePullSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_pull_secret";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for init_containers in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "init_containers";

    /// <summary>
    /// The args attribute.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetRequiredArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The image_pull_policy attribute.
    /// </summary>
    public TerraformValue<string>? ImagePullPolicy
    {
        get => GetArgument<TerraformValue<string>>("image_pull_policy");
        set => SetArgument("image_pull_policy", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Env block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// SecurityContext block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityContext block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockSecurityContextBlock>? SecurityContext
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockSecurityContextBlock>>("security_context");
        set => SetArgument("security_context", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock.
/// Nesting mode: set
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

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
/// Block type for resources in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// The limits attribute.
    /// </summary>
    public TerraformMap<string>? Limits
    {
        get => GetArgument<TerraformMap<string>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// The requests attribute.
    /// </summary>
    public TerraformMap<string>? Requests
    {
        get => GetArgument<TerraformMap<string>>("requests");
        set => SetArgument("requests", value);
    }

}

/// <summary>
/// Block type for security_context in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockSecurityContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_context";

    /// <summary>
    /// The privileged attribute.
    /// </summary>
    public TerraformValue<bool>? Privileged
    {
        get => GetArgument<TerraformValue<bool>>("privileged");
        set => SetArgument("privileged", value);
    }

    /// <summary>
    /// The read_only_root_file_system attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyRootFileSystem
    {
        get => GetArgument<TerraformValue<bool>>("read_only_root_file_system");
        set => SetArgument("read_only_root_file_system", value);
    }

    /// <summary>
    /// The run_as_group attribute.
    /// </summary>
    public TerraformValue<double>? RunAsGroup
    {
        get => GetArgument<TerraformValue<double>>("run_as_group");
        set => SetArgument("run_as_group", value);
    }

    /// <summary>
    /// The run_as_non_root attribute.
    /// </summary>
    public TerraformValue<bool>? RunAsNonRoot
    {
        get => GetArgument<TerraformValue<bool>>("run_as_non_root");
        set => SetArgument("run_as_non_root", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public TerraformValue<double>? RunAsUser
    {
        get => GetArgument<TerraformValue<double>>("run_as_user");
        set => SetArgument("run_as_user", value);
    }

}

/// <summary>
/// Block type for volume_mounts in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockInitContainersBlockVolumeMountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_mounts";

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
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
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

}

/// <summary>
/// Block type for metadata in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for volumes in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volumes";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// EmptyDir block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmptyDir block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockEmptyDirBlock>? EmptyDir
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockEmptyDirBlock>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// HostPath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostPath block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockHostPathBlock>? HostPath
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockHostPathBlock>>("host_path");
        set => SetArgument("host_path", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secret block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for empty_dir in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockEmptyDirBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "empty_dir";

    /// <summary>
    /// The medium attribute.
    /// </summary>
    public TerraformValue<string>? Medium
    {
        get => GetArgument<TerraformValue<string>>("medium");
        set => SetArgument("medium", value);
    }

    /// <summary>
    /// The size_limit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeLimit is required")]
    public required TerraformValue<string> SizeLimit
    {
        get => GetRequiredArgument<TerraformValue<string>>("size_limit");
        set => SetArgument("size_limit", value);
    }

}

/// <summary>
/// Block type for host_path in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockHostPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "host_path";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for secret in AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionEksPropertiesBlockPodPropertiesBlockVolumesBlockSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The optional attribute.
    /// </summary>
    public TerraformValue<bool>? Optional
    {
        get => GetArgument<TerraformValue<bool>>("optional");
        set => SetArgument("optional", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}


/// <summary>
/// Block type for retry_strategy in AwsBatchJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionRetryStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_strategy";

    /// <summary>
    /// The attempts attribute.
    /// </summary>
    public TerraformValue<double>? Attempts
    {
        get => GetArgument<TerraformValue<double>>("attempts");
        set => SetArgument("attempts", value);
    }

    /// <summary>
    /// EvaluateOnExit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EvaluateOnExit block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionRetryStrategyBlockEvaluateOnExitBlock>? EvaluateOnExit
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionRetryStrategyBlockEvaluateOnExitBlock>>("evaluate_on_exit");
        set => SetArgument("evaluate_on_exit", value);
    }

}

/// <summary>
/// Block type for evaluate_on_exit in AwsBatchJobDefinitionRetryStrategyBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionRetryStrategyBlockEvaluateOnExitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "evaluate_on_exit";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The on_exit_code attribute.
    /// </summary>
    public TerraformValue<string>? OnExitCode
    {
        get => GetArgument<TerraformValue<string>>("on_exit_code");
        set => SetArgument("on_exit_code", value);
    }

    /// <summary>
    /// The on_reason attribute.
    /// </summary>
    public TerraformValue<string>? OnReason
    {
        get => GetArgument<TerraformValue<string>>("on_reason");
        set => SetArgument("on_reason", value);
    }

    /// <summary>
    /// The on_status_reason attribute.
    /// </summary>
    public TerraformValue<string>? OnStatusReason
    {
        get => GetArgument<TerraformValue<string>>("on_status_reason");
        set => SetArgument("on_status_reason", value);
    }

}


/// <summary>
/// Block type for timeout in AwsBatchJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsBatchJobDefinitionTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// The attempt_duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? AttemptDurationSeconds
    {
        get => GetArgument<TerraformValue<double>>("attempt_duration_seconds");
        set => SetArgument("attempt_duration_seconds", value);
    }

}


/// <summary>
/// Represents a aws_batch_job_definition Terraform resource.
/// Manages a aws_batch_job_definition resource.
/// </summary>
public partial class AwsBatchJobDefinition(string name) : TerraformResource("aws_batch_job_definition", name)
{
    /// <summary>
    /// The container_properties attribute.
    /// </summary>
    public TerraformValue<string>? ContainerProperties
    {
        get => GetArgument<TerraformValue<string>>("container_properties");
        set => SetArgument("container_properties", value);
    }

    /// <summary>
    /// The deregister_on_new_revision attribute.
    /// </summary>
    public TerraformValue<bool>? DeregisterOnNewRevision
    {
        get => GetArgument<TerraformValue<bool>>("deregister_on_new_revision");
        set => SetArgument("deregister_on_new_revision", value);
    }

    /// <summary>
    /// The ecs_properties attribute.
    /// </summary>
    public TerraformValue<string>? EcsProperties
    {
        get => GetArgument<TerraformValue<string>>("ecs_properties");
        set => SetArgument("ecs_properties", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_properties attribute.
    /// </summary>
    public TerraformValue<string>? NodeProperties
    {
        get => GetArgument<TerraformValue<string>>("node_properties");
        set => SetArgument("node_properties", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The platform_capabilities attribute.
    /// </summary>
    public TerraformSet<string>? PlatformCapabilities
    {
        get => GetArgument<TerraformSet<string>>("platform_capabilities");
        set => SetArgument("platform_capabilities", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<bool>? PropagateTags
    {
        get => GetArgument<TerraformValue<bool>>("propagate_tags");
        set => SetArgument("propagate_tags", value);
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
    /// The scheduling_priority attribute.
    /// </summary>
    public TerraformValue<double>? SchedulingPriority
    {
        get => GetArgument<TerraformValue<double>>("scheduling_priority");
        set => SetArgument("scheduling_priority", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The arn_prefix attribute.
    /// </summary>
    public TerraformValue<string> ArnPrefix
        => CreateReference("arn_prefix");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double> Revision
        => CreateReference("revision");

    /// <summary>
    /// EksProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksProperties block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionEksPropertiesBlock>? EksProperties
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionEksPropertiesBlock>>("eks_properties");
        set => SetArgument("eks_properties", value);
    }

    /// <summary>
    /// RetryStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryStrategy block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionRetryStrategyBlock>? RetryStrategy
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionRetryStrategyBlock>>("retry_strategy");
        set => SetArgument("retry_strategy", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsBatchJobDefinitionTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsBatchJobDefinitionTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

}
