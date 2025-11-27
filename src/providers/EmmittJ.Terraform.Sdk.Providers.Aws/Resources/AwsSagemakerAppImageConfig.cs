using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for code_editor_app_image_config in AwsSagemakerAppImageConfig.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_editor_app_image_config";

    /// <summary>
    /// ContainerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlockContainerConfigBlock>? ContainerConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlockContainerConfigBlock>>("container_config");
        set => SetArgument("container_config", value);
    }

    /// <summary>
    /// FileSystemConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlockFileSystemConfigBlock>? FileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlockFileSystemConfigBlock>>("file_system_config");
        set => SetArgument("file_system_config", value);
    }

}

/// <summary>
/// Block type for container_config in AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlockContainerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_config";

    /// <summary>
    /// The container_arguments attribute.
    /// </summary>
    public TerraformList<string>? ContainerArguments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "container_arguments").ResolveNodes(ctx));
        set => SetArgument("container_arguments", value);
    }

    /// <summary>
    /// The container_entrypoint attribute.
    /// </summary>
    public TerraformList<string>? ContainerEntrypoint
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "container_entrypoint").ResolveNodes(ctx));
        set => SetArgument("container_entrypoint", value);
    }

    /// <summary>
    /// The container_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? ContainerEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "container_environment_variables").ResolveNodes(ctx));
        set => SetArgument("container_environment_variables", value);
    }

}

/// <summary>
/// Block type for file_system_config in AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlockFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_config";

    /// <summary>
    /// The default_gid attribute.
    /// </summary>
    public TerraformValue<double>? DefaultGid
    {
        get => new TerraformReference<double>(this, "default_gid");
        set => SetArgument("default_gid", value);
    }

    /// <summary>
    /// The default_uid attribute.
    /// </summary>
    public TerraformValue<double>? DefaultUid
    {
        get => new TerraformReference<double>(this, "default_uid");
        set => SetArgument("default_uid", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

}


/// <summary>
/// Block type for jupyter_lab_image_config in AwsSagemakerAppImageConfig.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigJupyterLabImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_lab_image_config";

    /// <summary>
    /// ContainerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigJupyterLabImageConfigBlockContainerConfigBlock>? ContainerConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigJupyterLabImageConfigBlockContainerConfigBlock>>("container_config");
        set => SetArgument("container_config", value);
    }

    /// <summary>
    /// FileSystemConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigJupyterLabImageConfigBlockFileSystemConfigBlock>? FileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigJupyterLabImageConfigBlockFileSystemConfigBlock>>("file_system_config");
        set => SetArgument("file_system_config", value);
    }

}

/// <summary>
/// Block type for container_config in AwsSagemakerAppImageConfigJupyterLabImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigJupyterLabImageConfigBlockContainerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_config";

    /// <summary>
    /// The container_arguments attribute.
    /// </summary>
    public TerraformList<string>? ContainerArguments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "container_arguments").ResolveNodes(ctx));
        set => SetArgument("container_arguments", value);
    }

    /// <summary>
    /// The container_entrypoint attribute.
    /// </summary>
    public TerraformList<string>? ContainerEntrypoint
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "container_entrypoint").ResolveNodes(ctx));
        set => SetArgument("container_entrypoint", value);
    }

    /// <summary>
    /// The container_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? ContainerEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "container_environment_variables").ResolveNodes(ctx));
        set => SetArgument("container_environment_variables", value);
    }

}

/// <summary>
/// Block type for file_system_config in AwsSagemakerAppImageConfigJupyterLabImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigJupyterLabImageConfigBlockFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_config";

    /// <summary>
    /// The default_gid attribute.
    /// </summary>
    public TerraformValue<double>? DefaultGid
    {
        get => new TerraformReference<double>(this, "default_gid");
        set => SetArgument("default_gid", value);
    }

    /// <summary>
    /// The default_uid attribute.
    /// </summary>
    public TerraformValue<double>? DefaultUid
    {
        get => new TerraformReference<double>(this, "default_uid");
        set => SetArgument("default_uid", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

}


/// <summary>
/// Block type for kernel_gateway_image_config in AwsSagemakerAppImageConfig.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kernel_gateway_image_config";

    /// <summary>
    /// FileSystemConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystemConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlockFileSystemConfigBlock>? FileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlockFileSystemConfigBlock>>("file_system_config");
        set => SetArgument("file_system_config", value);
    }

    /// <summary>
    /// KernelSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KernelSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KernelSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 KernelSpec block(s) allowed")]
    public required TerraformList<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlockKernelSpecBlock> KernelSpec
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlockKernelSpecBlock>>("kernel_spec");
        set => SetArgument("kernel_spec", value);
    }

}

/// <summary>
/// Block type for file_system_config in AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigKernelGatewayImageConfigBlockFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_config";

    /// <summary>
    /// The default_gid attribute.
    /// </summary>
    public TerraformValue<double>? DefaultGid
    {
        get => new TerraformReference<double>(this, "default_gid");
        set => SetArgument("default_gid", value);
    }

    /// <summary>
    /// The default_uid attribute.
    /// </summary>
    public TerraformValue<double>? DefaultUid
    {
        get => new TerraformReference<double>(this, "default_uid");
        set => SetArgument("default_uid", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

}

/// <summary>
/// Block type for kernel_spec in AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigKernelGatewayImageConfigBlockKernelSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kernel_spec";

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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

}


/// <summary>
/// Represents a aws_sagemaker_app_image_config Terraform resource.
/// Manages a aws_sagemaker_app_image_config resource.
/// </summary>
public partial class AwsSagemakerAppImageConfig(string name) : TerraformResource("aws_sagemaker_app_image_config", name)
{
    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => new TerraformReference<string>(this, "app_image_config_name");
        set => SetArgument("app_image_config_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// CodeEditorAppImageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppImageConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock>? CodeEditorAppImageConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock>>("code_editor_app_image_config");
        set => SetArgument("code_editor_app_image_config", value);
    }

    /// <summary>
    /// JupyterLabImageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabImageConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigJupyterLabImageConfigBlock>? JupyterLabImageConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigJupyterLabImageConfigBlock>>("jupyter_lab_image_config");
        set => SetArgument("jupyter_lab_image_config", value);
    }

    /// <summary>
    /// KernelGatewayImageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayImageConfig block(s) allowed")]
    public TerraformList<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock>? KernelGatewayImageConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock>>("kernel_gateway_image_config");
        set => SetArgument("kernel_gateway_image_config", value);
    }

}
