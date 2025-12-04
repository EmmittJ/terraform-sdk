using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_space_settings in AwsSagemakerDomain.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_space_settings";

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformValue<string> ExecutionRole
    {
        get => GetRequiredArgument<TerraformValue<string>>("execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// CustomFileSystemConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlock>? CustomFileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlock>>("custom_file_system_config");
        set => SetArgument("custom_file_system_config", value);
    }

    /// <summary>
    /// CustomPosixUserConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPosixUserConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockCustomPosixUserConfigBlock>? CustomPosixUserConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockCustomPosixUserConfigBlock>>("custom_posix_user_config");
        set => SetArgument("custom_posix_user_config", value);
    }

    /// <summary>
    /// JupyterLabAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock>? JupyterLabAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock>>("jupyter_lab_app_settings");
        set => SetArgument("jupyter_lab_app_settings", value);
    }

    /// <summary>
    /// JupyterServerAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterServerAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlock>? JupyterServerAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlock>>("jupyter_server_app_settings");
        set => SetArgument("jupyter_server_app_settings", value);
    }

    /// <summary>
    /// KernelGatewayAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlock>? KernelGatewayAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlock>>("kernel_gateway_app_settings");
        set => SetArgument("kernel_gateway_app_settings", value);
    }

    /// <summary>
    /// SpaceStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlock>? SpaceStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlock>>("space_storage_settings");
        set => SetArgument("space_storage_settings", value);
    }

}

/// <summary>
/// Block type for custom_file_system_config in AwsSagemakerDomainDefaultSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_file_system_config";

    /// <summary>
    /// EfsFileSystemConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileSystemConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock>? EfsFileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock>>("efs_file_system_config");
        set => SetArgument("efs_file_system_config", value);
    }

}

/// <summary>
/// Block type for efs_file_system_config in AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_system_config";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemPath is required")]
    public required TerraformValue<string> FileSystemPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_path");
        set => SetArgument("file_system_path", value);
    }

}

/// <summary>
/// Block type for custom_posix_user_config in AwsSagemakerDomainDefaultSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockCustomPosixUserConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_posix_user_config";

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    public required TerraformValue<double> Gid
    {
        get => GetRequiredArgument<TerraformValue<double>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformValue<double> Uid
    {
        get => GetRequiredArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}

/// <summary>
/// Block type for jupyter_lab_app_settings in AwsSagemakerDomainDefaultSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_lab_app_settings";

    /// <summary>
    /// The built_in_lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInLifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("built_in_lifecycle_config_arn");
        set => SetArgument("built_in_lifecycle_config_arn", value);
    }

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// AppLifecycleManagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppLifecycleManagement block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CodeRepository block(s) allowed")]
    public TerraformSet<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

    /// <summary>
    /// EmrSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmrSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock>? EmrSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock>>("emr_settings");
        set => SetArgument("emr_settings", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle_settings";

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The lifecycle_management attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleManagement
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_management");
        set => SetArgument("lifecycle_management", value);
    }

    /// <summary>
    /// The max_idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MaxIdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("max_idle_timeout_in_minutes");
        set => SetArgument("max_idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The min_idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MinIdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("min_idle_timeout_in_minutes");
        set => SetArgument("min_idle_timeout_in_minutes", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository";

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_image";

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image_version_number attribute.
    /// </summary>
    public TerraformValue<double>? ImageVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("image_version_number");
        set => SetArgument("image_version_number", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for emr_settings in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "emr_settings";

    /// <summary>
    /// The assumable_role_arns attribute.
    /// </summary>
    public TerraformSet<string>? AssumableRoleArns
    {
        get => GetArgument<TerraformSet<string>>("assumable_role_arns");
        set => SetArgument("assumable_role_arns", value);
    }

    /// <summary>
    /// The execution_role_arns attribute.
    /// </summary>
    public TerraformSet<string>? ExecutionRoleArns
    {
        get => GetArgument<TerraformSet<string>>("execution_role_arns");
        set => SetArgument("execution_role_arns", value);
    }

}

/// <summary>
/// Block type for jupyter_server_app_settings in AwsSagemakerDomainDefaultSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_server_app_settings";

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CodeRepository block(s) allowed")]
    public TerraformSet<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository";

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for kernel_gateway_app_settings in AwsSagemakerDomainDefaultSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kernel_gateway_app_settings";

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_image";

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image_version_number attribute.
    /// </summary>
    public TerraformValue<double>? ImageVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("image_version_number");
        set => SetArgument("image_version_number", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for space_storage_settings in AwsSagemakerDomainDefaultSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "space_storage_settings";

    /// <summary>
    /// DefaultEbsStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultEbsStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock>? DefaultEbsStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock>>("default_ebs_storage_settings");
        set => SetArgument("default_ebs_storage_settings", value);
    }

}

/// <summary>
/// Block type for default_ebs_storage_settings in AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultSpaceSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_ebs_storage_settings";

    /// <summary>
    /// The default_ebs_volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultEbsVolumeSizeInGb is required")]
    public required TerraformValue<double> DefaultEbsVolumeSizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("default_ebs_volume_size_in_gb");
        set => SetArgument("default_ebs_volume_size_in_gb", value);
    }

    /// <summary>
    /// The maximum_ebs_volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumEbsVolumeSizeInGb is required")]
    public required TerraformValue<double> MaximumEbsVolumeSizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("maximum_ebs_volume_size_in_gb");
        set => SetArgument("maximum_ebs_volume_size_in_gb", value);
    }

}


/// <summary>
/// Block type for default_user_settings in AwsSagemakerDomain.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_user_settings";

    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    public TerraformValue<string> AutoMountHomeEfs
    {
        get => GetArgument<TerraformValue<string>>("auto_mount_home_efs") ?? AsReference("auto_mount_home_efs");
        set => SetArgument("auto_mount_home_efs", value);
    }

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    public TerraformValue<string> DefaultLandingUri
    {
        get => GetArgument<TerraformValue<string>>("default_landing_uri") ?? AsReference("default_landing_uri");
        set => SetArgument("default_landing_uri", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformValue<string> ExecutionRole
    {
        get => GetRequiredArgument<TerraformValue<string>>("execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The studio_web_portal attribute.
    /// </summary>
    public TerraformValue<string> StudioWebPortal
    {
        get => GetArgument<TerraformValue<string>>("studio_web_portal") ?? AsReference("studio_web_portal");
        set => SetArgument("studio_web_portal", value);
    }

    /// <summary>
    /// CanvasAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanvasAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock>? CanvasAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock>>("canvas_app_settings");
        set => SetArgument("canvas_app_settings", value);
    }

    /// <summary>
    /// CodeEditorAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlock>? CodeEditorAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlock>>("code_editor_app_settings");
        set => SetArgument("code_editor_app_settings", value);
    }

    /// <summary>
    /// CustomFileSystemConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlock>? CustomFileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlock>>("custom_file_system_config");
        set => SetArgument("custom_file_system_config", value);
    }

    /// <summary>
    /// CustomPosixUserConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPosixUserConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCustomPosixUserConfigBlock>? CustomPosixUserConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCustomPosixUserConfigBlock>>("custom_posix_user_config");
        set => SetArgument("custom_posix_user_config", value);
    }

    /// <summary>
    /// JupyterLabAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock>? JupyterLabAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock>>("jupyter_lab_app_settings");
        set => SetArgument("jupyter_lab_app_settings", value);
    }

    /// <summary>
    /// JupyterServerAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterServerAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlock>? JupyterServerAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlock>>("jupyter_server_app_settings");
        set => SetArgument("jupyter_server_app_settings", value);
    }

    /// <summary>
    /// KernelGatewayAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlock>? KernelGatewayAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlock>>("kernel_gateway_app_settings");
        set => SetArgument("kernel_gateway_app_settings", value);
    }

    /// <summary>
    /// RSessionAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RSessionAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlock>? RSessionAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlock>>("r_session_app_settings");
        set => SetArgument("r_session_app_settings", value);
    }

    /// <summary>
    /// RStudioServerProAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RStudioServerProAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRStudioServerProAppSettingsBlock>? RStudioServerProAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRStudioServerProAppSettingsBlock>>("r_studio_server_pro_app_settings");
        set => SetArgument("r_studio_server_pro_app_settings", value);
    }

    /// <summary>
    /// SharingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockSharingSettingsBlock>? SharingSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockSharingSettingsBlock>>("sharing_settings");
        set => SetArgument("sharing_settings", value);
    }

    /// <summary>
    /// SpaceStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlock>? SpaceStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlock>>("space_storage_settings");
        set => SetArgument("space_storage_settings", value);
    }

    /// <summary>
    /// StudioWebPortalSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StudioWebPortalSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockStudioWebPortalSettingsBlock>? StudioWebPortalSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockStudioWebPortalSettingsBlock>>("studio_web_portal_settings");
        set => SetArgument("studio_web_portal_settings", value);
    }

    /// <summary>
    /// TensorBoardAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TensorBoardAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlock>? TensorBoardAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlock>>("tensor_board_app_settings");
        set => SetArgument("tensor_board_app_settings", value);
    }

}

/// <summary>
/// Block type for canvas_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "canvas_app_settings";

    /// <summary>
    /// DirectDeploySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectDeploySettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockDirectDeploySettingsBlock>? DirectDeploySettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockDirectDeploySettingsBlock>>("direct_deploy_settings");
        set => SetArgument("direct_deploy_settings", value);
    }

    /// <summary>
    /// EmrServerlessSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmrServerlessSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockEmrServerlessSettingsBlock>? EmrServerlessSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockEmrServerlessSettingsBlock>>("emr_serverless_settings");
        set => SetArgument("emr_serverless_settings", value);
    }

    /// <summary>
    /// GenerativeAiSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeAiSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockGenerativeAiSettingsBlock>? GenerativeAiSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockGenerativeAiSettingsBlock>>("generative_ai_settings");
        set => SetArgument("generative_ai_settings", value);
    }

    /// <summary>
    /// IdentityProviderOauthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 IdentityProviderOauthSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockIdentityProviderOauthSettingsBlock>? IdentityProviderOauthSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockIdentityProviderOauthSettingsBlock>>("identity_provider_oauth_settings");
        set => SetArgument("identity_provider_oauth_settings", value);
    }

    /// <summary>
    /// KendraSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KendraSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockKendraSettingsBlock>? KendraSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockKendraSettingsBlock>>("kendra_settings");
        set => SetArgument("kendra_settings", value);
    }

    /// <summary>
    /// ModelRegisterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelRegisterSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockModelRegisterSettingsBlock>? ModelRegisterSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockModelRegisterSettingsBlock>>("model_register_settings");
        set => SetArgument("model_register_settings", value);
    }

    /// <summary>
    /// TimeSeriesForecastingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeSeriesForecastingSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockTimeSeriesForecastingSettingsBlock>? TimeSeriesForecastingSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockTimeSeriesForecastingSettingsBlock>>("time_series_forecasting_settings");
        set => SetArgument("time_series_forecasting_settings", value);
    }

    /// <summary>
    /// WorkspaceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockWorkspaceSettingsBlock>? WorkspaceSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockWorkspaceSettingsBlock>>("workspace_settings");
        set => SetArgument("workspace_settings", value);
    }

}

/// <summary>
/// Block type for direct_deploy_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockDirectDeploySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "direct_deploy_settings";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for emr_serverless_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockEmrServerlessSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "emr_serverless_settings";

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for generative_ai_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockGenerativeAiSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generative_ai_settings";

    /// <summary>
    /// The amazon_bedrock_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? AmazonBedrockRoleArn
    {
        get => GetArgument<TerraformValue<string>>("amazon_bedrock_role_arn");
        set => SetArgument("amazon_bedrock_role_arn", value);
    }

}

/// <summary>
/// Block type for identity_provider_oauth_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockIdentityProviderOauthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_provider_oauth_settings";

    /// <summary>
    /// The data_source_name attribute.
    /// </summary>
    public TerraformValue<string>? DataSourceName
    {
        get => GetArgument<TerraformValue<string>>("data_source_name");
        set => SetArgument("data_source_name", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretArn is required")]
    public required TerraformValue<string> SecretArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for kendra_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockKendraSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kendra_settings";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for model_register_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockModelRegisterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_register_settings";

    /// <summary>
    /// The cross_account_model_register_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? CrossAccountModelRegisterRoleArn
    {
        get => GetArgument<TerraformValue<string>>("cross_account_model_register_role_arn");
        set => SetArgument("cross_account_model_register_role_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for time_series_forecasting_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockTimeSeriesForecastingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_series_forecasting_settings";

    /// <summary>
    /// The amazon_forecast_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? AmazonForecastRoleArn
    {
        get => GetArgument<TerraformValue<string>>("amazon_forecast_role_arn");
        set => SetArgument("amazon_forecast_role_arn", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}

/// <summary>
/// Block type for workspace_settings in AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCanvasAppSettingsBlockWorkspaceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workspace_settings";

    /// <summary>
    /// The s3_artifact_path attribute.
    /// </summary>
    public TerraformValue<string>? S3ArtifactPath
    {
        get => GetArgument<TerraformValue<string>>("s3_artifact_path");
        set => SetArgument("s3_artifact_path", value);
    }

    /// <summary>
    /// The s3_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? S3KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("s3_kms_key_id");
        set => SetArgument("s3_kms_key_id", value);
    }

}

/// <summary>
/// Block type for code_editor_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_editor_app_settings";

    /// <summary>
    /// The built_in_lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInLifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("built_in_lifecycle_config_arn");
        set => SetArgument("built_in_lifecycle_config_arn", value);
    }

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// AppLifecycleManagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppLifecycleManagement block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle_settings";

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The lifecycle_management attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleManagement
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_management");
        set => SetArgument("lifecycle_management", value);
    }

    /// <summary>
    /// The max_idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MaxIdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("max_idle_timeout_in_minutes");
        set => SetArgument("max_idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The min_idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MinIdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("min_idle_timeout_in_minutes");
        set => SetArgument("min_idle_timeout_in_minutes", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockCustomImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_image";

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image_version_number attribute.
    /// </summary>
    public TerraformValue<double>? ImageVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("image_version_number");
        set => SetArgument("image_version_number", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for custom_file_system_config in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_file_system_config";

    /// <summary>
    /// EfsFileSystemConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileSystemConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock>? EfsFileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock>>("efs_file_system_config");
        set => SetArgument("efs_file_system_config", value);
    }

}

/// <summary>
/// Block type for efs_file_system_config in AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_system_config";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemPath is required")]
    public required TerraformValue<string> FileSystemPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_path");
        set => SetArgument("file_system_path", value);
    }

}

/// <summary>
/// Block type for custom_posix_user_config in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockCustomPosixUserConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_posix_user_config";

    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    public required TerraformValue<double> Gid
    {
        get => GetRequiredArgument<TerraformValue<double>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformValue<double> Uid
    {
        get => GetRequiredArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}

/// <summary>
/// Block type for jupyter_lab_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_lab_app_settings";

    /// <summary>
    /// The built_in_lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInLifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("built_in_lifecycle_config_arn");
        set => SetArgument("built_in_lifecycle_config_arn", value);
    }

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// AppLifecycleManagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppLifecycleManagement block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CodeRepository block(s) allowed")]
    public TerraformSet<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

    /// <summary>
    /// EmrSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmrSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock>? EmrSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock>>("emr_settings");
        set => SetArgument("emr_settings", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle_settings";

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The lifecycle_management attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleManagement
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_management");
        set => SetArgument("lifecycle_management", value);
    }

    /// <summary>
    /// The max_idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MaxIdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("max_idle_timeout_in_minutes");
        set => SetArgument("max_idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The min_idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? MinIdleTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("min_idle_timeout_in_minutes");
        set => SetArgument("min_idle_timeout_in_minutes", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository";

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_image";

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image_version_number attribute.
    /// </summary>
    public TerraformValue<double>? ImageVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("image_version_number");
        set => SetArgument("image_version_number", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for emr_settings in AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "emr_settings";

    /// <summary>
    /// The assumable_role_arns attribute.
    /// </summary>
    public TerraformSet<string>? AssumableRoleArns
    {
        get => GetArgument<TerraformSet<string>>("assumable_role_arns");
        set => SetArgument("assumable_role_arns", value);
    }

    /// <summary>
    /// The execution_role_arns attribute.
    /// </summary>
    public TerraformSet<string>? ExecutionRoleArns
    {
        get => GetArgument<TerraformSet<string>>("execution_role_arns");
        set => SetArgument("execution_role_arns", value);
    }

}

/// <summary>
/// Block type for jupyter_server_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_server_app_settings";

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CodeRepository block(s) allowed")]
    public TerraformSet<AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_repository";

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryUrl is required")]
    public required TerraformValue<string> RepositoryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for kernel_gateway_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kernel_gateway_app_settings";

    /// <summary>
    /// The lifecycle_config_arns attribute.
    /// </summary>
    public TerraformSet<string>? LifecycleConfigArns
    {
        get => GetArgument<TerraformSet<string>>("lifecycle_config_arns");
        set => SetArgument("lifecycle_config_arns", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_image";

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image_version_number attribute.
    /// </summary>
    public TerraformValue<double>? ImageVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("image_version_number");
        set => SetArgument("image_version_number", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for r_session_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "r_session_app_settings";

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlockCustomImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_image";

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformValue<string> AppImageConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image_version_number attribute.
    /// </summary>
    public TerraformValue<double>? ImageVersionNumber
    {
        get => GetArgument<TerraformValue<double>>("image_version_number");
        set => SetArgument("image_version_number", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockRSessionAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}

/// <summary>
/// Block type for r_studio_server_pro_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockRStudioServerProAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "r_studio_server_pro_app_settings";

    /// <summary>
    /// The access_status attribute.
    /// </summary>
    public TerraformValue<string>? AccessStatus
    {
        get => GetArgument<TerraformValue<string>>("access_status");
        set => SetArgument("access_status", value);
    }

    /// <summary>
    /// The user_group attribute.
    /// </summary>
    public TerraformValue<string>? UserGroup
    {
        get => GetArgument<TerraformValue<string>>("user_group");
        set => SetArgument("user_group", value);
    }

}

/// <summary>
/// Block type for sharing_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockSharingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sharing_settings";

    /// <summary>
    /// The notebook_output_option attribute.
    /// </summary>
    public TerraformValue<string>? NotebookOutputOption
    {
        get => GetArgument<TerraformValue<string>>("notebook_output_option");
        set => SetArgument("notebook_output_option", value);
    }

    /// <summary>
    /// The s3_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? S3KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("s3_kms_key_id");
        set => SetArgument("s3_kms_key_id", value);
    }

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    public TerraformValue<string>? S3OutputPath
    {
        get => GetArgument<TerraformValue<string>>("s3_output_path");
        set => SetArgument("s3_output_path", value);
    }

}

/// <summary>
/// Block type for space_storage_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "space_storage_settings";

    /// <summary>
    /// DefaultEbsStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultEbsStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock>? DefaultEbsStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock>>("default_ebs_storage_settings");
        set => SetArgument("default_ebs_storage_settings", value);
    }

}

/// <summary>
/// Block type for default_ebs_storage_settings in AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_ebs_storage_settings";

    /// <summary>
    /// The default_ebs_volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultEbsVolumeSizeInGb is required")]
    public required TerraformValue<double> DefaultEbsVolumeSizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("default_ebs_volume_size_in_gb");
        set => SetArgument("default_ebs_volume_size_in_gb", value);
    }

    /// <summary>
    /// The maximum_ebs_volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumEbsVolumeSizeInGb is required")]
    public required TerraformValue<double> MaximumEbsVolumeSizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("maximum_ebs_volume_size_in_gb");
        set => SetArgument("maximum_ebs_volume_size_in_gb", value);
    }

}

/// <summary>
/// Block type for studio_web_portal_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockStudioWebPortalSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "studio_web_portal_settings";

    /// <summary>
    /// The hidden_app_types attribute.
    /// </summary>
    public TerraformSet<string>? HiddenAppTypes
    {
        get => GetArgument<TerraformSet<string>>("hidden_app_types");
        set => SetArgument("hidden_app_types", value);
    }

    /// <summary>
    /// The hidden_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? HiddenInstanceTypes
    {
        get => GetArgument<TerraformSet<string>>("hidden_instance_types");
        set => SetArgument("hidden_instance_types", value);
    }

    /// <summary>
    /// The hidden_ml_tools attribute.
    /// </summary>
    public TerraformSet<string>? HiddenMlTools
    {
        get => GetArgument<TerraformSet<string>>("hidden_ml_tools");
        set => SetArgument("hidden_ml_tools", value);
    }

}

/// <summary>
/// Block type for tensor_board_app_settings in AwsSagemakerDomainDefaultUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tensor_board_app_settings";

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDefaultUserSettingsBlockTensorBoardAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}


/// <summary>
/// Block type for domain_settings in AwsSagemakerDomain.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDomainSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "domain_settings";

    /// <summary>
    /// The execution_role_identity_config attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleIdentityConfig
    {
        get => GetArgument<TerraformValue<string>>("execution_role_identity_config");
        set => SetArgument("execution_role_identity_config", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// DockerSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDomainSettingsBlockDockerSettingsBlock>? DockerSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDomainSettingsBlockDockerSettingsBlock>>("docker_settings");
        set => SetArgument("docker_settings", value);
    }

    /// <summary>
    /// RStudioServerProDomainSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RStudioServerProDomainSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlock>? RStudioServerProDomainSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlock>>("r_studio_server_pro_domain_settings");
        set => SetArgument("r_studio_server_pro_domain_settings", value);
    }

}

/// <summary>
/// Block type for docker_settings in AwsSagemakerDomainDomainSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDomainSettingsBlockDockerSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker_settings";

    /// <summary>
    /// The enable_docker_access attribute.
    /// </summary>
    public TerraformValue<string>? EnableDockerAccess
    {
        get => GetArgument<TerraformValue<string>>("enable_docker_access");
        set => SetArgument("enable_docker_access", value);
    }

    /// <summary>
    /// The vpc_only_trusted_accounts attribute.
    /// </summary>
    public TerraformSet<string>? VpcOnlyTrustedAccounts
    {
        get => GetArgument<TerraformSet<string>>("vpc_only_trusted_accounts");
        set => SetArgument("vpc_only_trusted_accounts", value);
    }

}

/// <summary>
/// Block type for r_studio_server_pro_domain_settings in AwsSagemakerDomainDomainSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "r_studio_server_pro_domain_settings";

    /// <summary>
    /// The domain_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainExecutionRoleArn is required")]
    public required TerraformValue<string> DomainExecutionRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_execution_role_arn");
        set => SetArgument("domain_execution_role_arn", value);
    }

    /// <summary>
    /// The r_studio_connect_url attribute.
    /// </summary>
    public TerraformValue<string>? RStudioConnectUrl
    {
        get => GetArgument<TerraformValue<string>>("r_studio_connect_url");
        set => SetArgument("r_studio_connect_url", value);
    }

    /// <summary>
    /// The r_studio_package_manager_url attribute.
    /// </summary>
    public TerraformValue<string>? RStudioPackageManagerUrl
    {
        get => GetArgument<TerraformValue<string>>("r_studio_package_manager_url");
        set => SetArgument("r_studio_package_manager_url", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainDomainSettingsBlockRStudioServerProDomainSettingsBlockDefaultResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => GetArgument<TerraformValue<string>>("sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}


/// <summary>
/// Block type for retention_policy in AwsSagemakerDomain.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDomainRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The home_efs_file_system attribute.
    /// </summary>
    public TerraformValue<string>? HomeEfsFileSystem
    {
        get => GetArgument<TerraformValue<string>>("home_efs_file_system");
        set => SetArgument("home_efs_file_system", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_domain Terraform resource.
/// Manages a aws_sagemaker_domain resource.
/// </summary>
public partial class AwsSagemakerDomain(string name) : TerraformResource("aws_sagemaker_domain", name)
{
    /// <summary>
    /// The app_network_access_type attribute.
    /// </summary>
    public TerraformValue<string>? AppNetworkAccessType
    {
        get => GetArgument<TerraformValue<string>>("app_network_access_type");
        set => SetArgument("app_network_access_type", value);
    }

    /// <summary>
    /// The app_security_group_management attribute.
    /// </summary>
    public TerraformValue<string>? AppSecurityGroupManagement
    {
        get => GetArgument<TerraformValue<string>>("app_security_group_management");
        set => SetArgument("app_security_group_management", value);
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    public required TerraformValue<string> AuthMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_mode");
        set => SetArgument("auth_mode", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tag_propagation attribute.
    /// </summary>
    public TerraformValue<string>? TagPropagation
    {
        get => GetArgument<TerraformValue<string>>("tag_propagation");
        set => SetArgument("tag_propagation", value);
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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The home_efs_file_system_id attribute.
    /// </summary>
    public TerraformValue<string> HomeEfsFileSystemId
        => AsReference("home_efs_file_system_id");

    /// <summary>
    /// The security_group_id_for_domain_boundary attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupIdForDomainBoundary
        => AsReference("security_group_id_for_domain_boundary");

    /// <summary>
    /// The single_sign_on_application_arn attribute.
    /// </summary>
    public TerraformValue<string> SingleSignOnApplicationArn
        => AsReference("single_sign_on_application_arn");

    /// <summary>
    /// The single_sign_on_managed_application_instance_id attribute.
    /// </summary>
    public TerraformValue<string> SingleSignOnManagedApplicationInstanceId
        => AsReference("single_sign_on_managed_application_instance_id");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// DefaultSpaceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultSpaceSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlock>? DefaultSpaceSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDefaultSpaceSettingsBlock>>("default_space_settings");
        set => SetArgument("default_space_settings", value);
    }

    /// <summary>
    /// DefaultUserSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultUserSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultUserSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultUserSettings block(s) allowed")]
    public required TerraformList<AwsSagemakerDomainDefaultUserSettingsBlock> DefaultUserSettings
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDomainDefaultUserSettingsBlock>>("default_user_settings");
        set => SetArgument("default_user_settings", value);
    }

    /// <summary>
    /// DomainSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainSettings block(s) allowed")]
    public TerraformList<AwsSagemakerDomainDomainSettingsBlock>? DomainSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainDomainSettingsBlock>>("domain_settings");
        set => SetArgument("domain_settings", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public TerraformList<AwsSagemakerDomainRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<AwsSagemakerDomainRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

}
