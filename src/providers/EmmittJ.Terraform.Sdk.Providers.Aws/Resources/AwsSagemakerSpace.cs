using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ownership_settings in AwsSagemakerSpace.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceOwnershipSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ownership_settings";

    /// <summary>
    /// The owner_user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerUserProfileName is required")]
    public required TerraformValue<string> OwnerUserProfileName
    {
        get => GetArgument<TerraformValue<string>>("owner_user_profile_name");
        set => SetArgument("owner_user_profile_name", value);
    }

}


/// <summary>
/// Block type for space_settings in AwsSagemakerSpace.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "space_settings";

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    public TerraformValue<string>? AppType
    {
        get => GetArgument<TerraformValue<string>>("app_type");
        set => SetArgument("app_type", value);
    }

    /// <summary>
    /// CodeEditorAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlock>? CodeEditorAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlock>>("code_editor_app_settings");
        set => SetArgument("code_editor_app_settings", value);
    }

    /// <summary>
    /// CustomFileSystem block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlock>? CustomFileSystem
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlock>>("custom_file_system");
        set => SetArgument("custom_file_system", value);
    }

    /// <summary>
    /// JupyterLabAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlock>? JupyterLabAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlock>>("jupyter_lab_app_settings");
        set => SetArgument("jupyter_lab_app_settings", value);
    }

    /// <summary>
    /// JupyterServerAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterServerAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlock>? JupyterServerAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlock>>("jupyter_server_app_settings");
        set => SetArgument("jupyter_server_app_settings", value);
    }

    /// <summary>
    /// KernelGatewayAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlock>? KernelGatewayAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlock>>("kernel_gateway_app_settings");
        set => SetArgument("kernel_gateway_app_settings", value);
    }

    /// <summary>
    /// SpaceStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlock>? SpaceStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlock>>("space_storage_settings");
        set => SetArgument("space_storage_settings", value);
    }

}

/// <summary>
/// Block type for code_editor_app_settings in AwsSagemakerSpaceSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_editor_app_settings";

    /// <summary>
    /// AppLifecycleManagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppLifecycleManagement block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultResourceSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public required TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock> DefaultResourceSpec
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
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

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for custom_file_system in AwsSagemakerSpaceSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_file_system";

    /// <summary>
    /// EfsFileSystem block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EfsFileSystem is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EfsFileSystem block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileSystem block(s) allowed")]
    public required TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlockEfsFileSystemBlock> EfsFileSystem
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlockEfsFileSystemBlock>>("efs_file_system");
        set => SetArgument("efs_file_system", value);
    }

}

/// <summary>
/// Block type for efs_file_system in AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockCustomFileSystemBlockEfsFileSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_system";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

}

/// <summary>
/// Block type for jupyter_lab_app_settings in AwsSagemakerSpaceSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jupyter_lab_app_settings";

    /// <summary>
    /// AppLifecycleManagement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppLifecycleManagement block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CodeRepository block(s) allowed")]
    public TerraformSet<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultResourceSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public required TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock> DefaultResourceSpec
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
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

}

/// <summary>
/// Block type for code_repository in AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for jupyter_server_app_settings in AwsSagemakerSpaceSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlock : TerraformBlock
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
    public TerraformSet<AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultResourceSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public required TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock> DefaultResourceSpec
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("repository_url");
        set => SetArgument("repository_url", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for kernel_gateway_app_settings in AwsSagemakerSpaceSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlock : TerraformBlock
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
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultResourceSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public required TerraformList<AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock> DefaultResourceSpec
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("app_image_config_name");
        set => SetArgument("app_image_config_name", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
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
/// Block type for default_resource_spec in AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for space_storage_settings in AwsSagemakerSpaceSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "space_storage_settings";

    /// <summary>
    /// EbsStorageSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsStorageSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EbsStorageSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsStorageSettings block(s) allowed")]
    public required TerraformList<AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlockEbsStorageSettingsBlock> EbsStorageSettings
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlockEbsStorageSettingsBlock>>("ebs_storage_settings");
        set => SetArgument("ebs_storage_settings", value);
    }

}

/// <summary>
/// Block type for ebs_storage_settings in AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlockSpaceStorageSettingsBlockEbsStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_storage_settings";

    /// <summary>
    /// The ebs_volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsVolumeSizeInGb is required")]
    public required TerraformValue<double> EbsVolumeSizeInGb
    {
        get => GetArgument<TerraformValue<double>>("ebs_volume_size_in_gb");
        set => SetArgument("ebs_volume_size_in_gb", value);
    }

}


/// <summary>
/// Block type for space_sharing_settings in AwsSagemakerSpace.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSharingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "space_sharing_settings";

    /// <summary>
    /// The sharing_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharingType is required")]
    public required TerraformValue<string> SharingType
    {
        get => GetArgument<TerraformValue<string>>("sharing_type");
        set => SetArgument("sharing_type", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_space Terraform resource.
/// Manages a aws_sagemaker_space resource.
/// </summary>
public partial class AwsSagemakerSpace(string name) : TerraformResource("aws_sagemaker_space", name)
{
    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformValue<string> DomainId
    {
        get => GetArgument<TerraformValue<string>>("domain_id");
        set => SetArgument("domain_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The space_display_name attribute.
    /// </summary>
    public TerraformValue<string>? SpaceDisplayName
    {
        get => GetArgument<TerraformValue<string>>("space_display_name");
        set => SetArgument("space_display_name", value);
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    public required TerraformValue<string> SpaceName
    {
        get => GetArgument<TerraformValue<string>>("space_name");
        set => SetArgument("space_name", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    public TerraformValue<string> HomeEfsFileSystemUid
        => AsReference("home_efs_file_system_uid");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// OwnershipSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OwnershipSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceOwnershipSettingsBlock>? OwnershipSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceOwnershipSettingsBlock>>("ownership_settings");
        set => SetArgument("ownership_settings", value);
    }

    /// <summary>
    /// SpaceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSettingsBlock>? SpaceSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSettingsBlock>>("space_settings");
        set => SetArgument("space_settings", value);
    }

    /// <summary>
    /// SpaceSharingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSharingSettings block(s) allowed")]
    public TerraformList<AwsSagemakerSpaceSpaceSharingSettingsBlock>? SpaceSharingSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerSpaceSpaceSharingSettingsBlock>>("space_sharing_settings");
        set => SetArgument("space_sharing_settings", value);
    }

}
