using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_settings in AwsSagemakerUserProfile.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_settings";

    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    public TerraformValue<string>? AutoMountHomeEfs
    {
        get => GetArgument<TerraformValue<string>>("auto_mount_home_efs");
        set => SetArgument("auto_mount_home_efs", value);
    }

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    public TerraformValue<string>? DefaultLandingUri
    {
        get => GetArgument<TerraformValue<string>>("default_landing_uri");
        set => SetArgument("default_landing_uri", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformValue<string> ExecutionRole
    {
        get => GetArgument<TerraformValue<string>>("execution_role");
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
    public TerraformValue<string>? StudioWebPortal
    {
        get => GetArgument<TerraformValue<string>>("studio_web_portal");
        set => SetArgument("studio_web_portal", value);
    }

    /// <summary>
    /// CanvasAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanvasAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock>? CanvasAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock>>("canvas_app_settings");
        set => SetArgument("canvas_app_settings", value);
    }

    /// <summary>
    /// CodeEditorAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlock>? CodeEditorAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlock>>("code_editor_app_settings");
        set => SetArgument("code_editor_app_settings", value);
    }

    /// <summary>
    /// CustomFileSystemConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlock>? CustomFileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlock>>("custom_file_system_config");
        set => SetArgument("custom_file_system_config", value);
    }

    /// <summary>
    /// CustomPosixUserConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPosixUserConfig block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCustomPosixUserConfigBlock>? CustomPosixUserConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCustomPosixUserConfigBlock>>("custom_posix_user_config");
        set => SetArgument("custom_posix_user_config", value);
    }

    /// <summary>
    /// JupyterLabAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock>? JupyterLabAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock>>("jupyter_lab_app_settings");
        set => SetArgument("jupyter_lab_app_settings", value);
    }

    /// <summary>
    /// JupyterServerAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterServerAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlock>? JupyterServerAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlock>>("jupyter_server_app_settings");
        set => SetArgument("jupyter_server_app_settings", value);
    }

    /// <summary>
    /// KernelGatewayAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlock>? KernelGatewayAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlock>>("kernel_gateway_app_settings");
        set => SetArgument("kernel_gateway_app_settings", value);
    }

    /// <summary>
    /// RSessionAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RSessionAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlock>? RSessionAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlock>>("r_session_app_settings");
        set => SetArgument("r_session_app_settings", value);
    }

    /// <summary>
    /// RStudioServerProAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RStudioServerProAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockRStudioServerProAppSettingsBlock>? RStudioServerProAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockRStudioServerProAppSettingsBlock>>("r_studio_server_pro_app_settings");
        set => SetArgument("r_studio_server_pro_app_settings", value);
    }

    /// <summary>
    /// SharingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharingSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockSharingSettingsBlock>? SharingSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockSharingSettingsBlock>>("sharing_settings");
        set => SetArgument("sharing_settings", value);
    }

    /// <summary>
    /// SpaceStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlock>? SpaceStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlock>>("space_storage_settings");
        set => SetArgument("space_storage_settings", value);
    }

    /// <summary>
    /// StudioWebPortalSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StudioWebPortalSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockStudioWebPortalSettingsBlock>? StudioWebPortalSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockStudioWebPortalSettingsBlock>>("studio_web_portal_settings");
        set => SetArgument("studio_web_portal_settings", value);
    }

    /// <summary>
    /// TensorBoardAppSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TensorBoardAppSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlock>? TensorBoardAppSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlock>>("tensor_board_app_settings");
        set => SetArgument("tensor_board_app_settings", value);
    }

}

/// <summary>
/// Block type for canvas_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "canvas_app_settings";

    /// <summary>
    /// DirectDeploySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectDeploySettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockDirectDeploySettingsBlock>? DirectDeploySettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockDirectDeploySettingsBlock>>("direct_deploy_settings");
        set => SetArgument("direct_deploy_settings", value);
    }

    /// <summary>
    /// EmrServerlessSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmrServerlessSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockEmrServerlessSettingsBlock>? EmrServerlessSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockEmrServerlessSettingsBlock>>("emr_serverless_settings");
        set => SetArgument("emr_serverless_settings", value);
    }

    /// <summary>
    /// GenerativeAiSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerativeAiSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockGenerativeAiSettingsBlock>? GenerativeAiSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockGenerativeAiSettingsBlock>>("generative_ai_settings");
        set => SetArgument("generative_ai_settings", value);
    }

    /// <summary>
    /// IdentityProviderOauthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 IdentityProviderOauthSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockIdentityProviderOauthSettingsBlock>? IdentityProviderOauthSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockIdentityProviderOauthSettingsBlock>>("identity_provider_oauth_settings");
        set => SetArgument("identity_provider_oauth_settings", value);
    }

    /// <summary>
    /// KendraSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KendraSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockKendraSettingsBlock>? KendraSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockKendraSettingsBlock>>("kendra_settings");
        set => SetArgument("kendra_settings", value);
    }

    /// <summary>
    /// ModelRegisterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelRegisterSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockModelRegisterSettingsBlock>? ModelRegisterSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockModelRegisterSettingsBlock>>("model_register_settings");
        set => SetArgument("model_register_settings", value);
    }

    /// <summary>
    /// TimeSeriesForecastingSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeSeriesForecastingSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockTimeSeriesForecastingSettingsBlock>? TimeSeriesForecastingSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockTimeSeriesForecastingSettingsBlock>>("time_series_forecasting_settings");
        set => SetArgument("time_series_forecasting_settings", value);
    }

    /// <summary>
    /// WorkspaceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkspaceSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockWorkspaceSettingsBlock>? WorkspaceSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockWorkspaceSettingsBlock>>("workspace_settings");
        set => SetArgument("workspace_settings", value);
    }

}

/// <summary>
/// Block type for direct_deploy_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockDirectDeploySettingsBlock : TerraformBlock
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
/// Block type for emr_serverless_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockEmrServerlessSettingsBlock : TerraformBlock
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
/// Block type for generative_ai_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockGenerativeAiSettingsBlock : TerraformBlock
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
/// Block type for identity_provider_oauth_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockIdentityProviderOauthSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("secret_arn");
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
/// Block type for kendra_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockKendraSettingsBlock : TerraformBlock
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
/// Block type for model_register_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockModelRegisterSettingsBlock : TerraformBlock
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
/// Block type for time_series_forecasting_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockTimeSeriesForecastingSettingsBlock : TerraformBlock
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
/// Block type for workspace_settings in AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCanvasAppSettingsBlockWorkspaceSettingsBlock : TerraformBlock
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
/// Block type for code_editor_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlock : TerraformBlock
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
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
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
/// Block type for custom_image in AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockCustomImageBlock : TerraformBlock
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
/// Block type for default_resource_spec in AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCodeEditorAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for custom_file_system_config in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_file_system_config";

    /// <summary>
    /// EfsFileSystemConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock>? EfsFileSystemConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock>>("efs_file_system_config");
        set => SetArgument("efs_file_system_config", value);
    }

}

/// <summary>
/// Block type for efs_file_system_config in AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCustomFileSystemConfigBlockEfsFileSystemConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemPath
    {
        get => GetArgument<TerraformValue<string>>("file_system_path");
        set => SetArgument("file_system_path", value);
    }

}

/// <summary>
/// Block type for custom_posix_user_config in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockCustomPosixUserConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformValue<double> Uid
    {
        get => GetArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}

/// <summary>
/// Block type for jupyter_lab_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock : TerraformBlock
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
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>? AppLifecycleManagement
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock>>("app_lifecycle_management");
        set => SetArgument("app_lifecycle_management", value);
    }

    /// <summary>
    /// CodeRepository block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 CodeRepository block(s) allowed")]
    public TerraformSet<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

    /// <summary>
    /// EmrSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmrSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock>? EmrSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock>>("emr_settings");
        set => SetArgument("emr_settings", value);
    }

}

/// <summary>
/// Block type for app_lifecycle_management in AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_lifecycle_management";

    /// <summary>
    /// IdleSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>? IdleSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock>>("idle_settings");
        set => SetArgument("idle_settings", value);
    }

}

/// <summary>
/// Block type for idle_settings in AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockAppLifecycleManagementBlockIdleSettingsBlock : TerraformBlock
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
/// Block type for code_repository in AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockCodeRepositoryBlock : TerraformBlock
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
/// Block type for custom_image in AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockCustomImageBlock : TerraformBlock
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
/// Block type for default_resource_spec in AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for emr_settings in AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterLabAppSettingsBlockEmrSettingsBlock : TerraformBlock
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
/// Block type for jupyter_server_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlock : TerraformBlock
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
    public TerraformSet<AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>? CodeRepository
    {
        get => GetArgument<TerraformSet<AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock>>("code_repository");
        set => SetArgument("code_repository", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for code_repository in AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlockCodeRepositoryBlock : TerraformBlock
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
/// Block type for default_resource_spec in AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockJupyterServerAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for kernel_gateway_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlock : TerraformBlock
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
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlockCustomImageBlock : TerraformBlock
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
/// Block type for default_resource_spec in AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockKernelGatewayAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for r_session_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "r_session_app_settings";

    /// <summary>
    /// CustomImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 CustomImage block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlockCustomImageBlock>? CustomImage
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlockCustomImageBlock>>("custom_image");
        set => SetArgument("custom_image", value);
    }

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for custom_image in AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlockCustomImageBlock : TerraformBlock
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
/// Block type for default_resource_spec in AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockRSessionAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Block type for r_studio_server_pro_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockRStudioServerProAppSettingsBlock : TerraformBlock
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
/// Block type for sharing_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockSharingSettingsBlock : TerraformBlock
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
/// Block type for space_storage_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "space_storage_settings";

    /// <summary>
    /// DefaultEbsStorageSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultEbsStorageSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock>? DefaultEbsStorageSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock>>("default_ebs_storage_settings");
        set => SetArgument("default_ebs_storage_settings", value);
    }

}

/// <summary>
/// Block type for default_ebs_storage_settings in AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockSpaceStorageSettingsBlockDefaultEbsStorageSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("default_ebs_volume_size_in_gb");
        set => SetArgument("default_ebs_volume_size_in_gb", value);
    }

    /// <summary>
    /// The maximum_ebs_volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumEbsVolumeSizeInGb is required")]
    public required TerraformValue<double> MaximumEbsVolumeSizeInGb
    {
        get => GetArgument<TerraformValue<double>>("maximum_ebs_volume_size_in_gb");
        set => SetArgument("maximum_ebs_volume_size_in_gb", value);
    }

}

/// <summary>
/// Block type for studio_web_portal_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockStudioWebPortalSettingsBlock : TerraformBlock
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
/// Block type for tensor_board_app_settings in AwsSagemakerUserProfileUserSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tensor_board_app_settings";

    /// <summary>
    /// DefaultResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlockDefaultResourceSpecBlock>? DefaultResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlockDefaultResourceSpecBlock>>("default_resource_spec");
        set => SetArgument("default_resource_spec", value);
    }

}

/// <summary>
/// Block type for default_resource_spec in AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlockTensorBoardAppSettingsBlockDefaultResourceSpecBlock : TerraformBlock
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
/// Represents a aws_sagemaker_user_profile Terraform resource.
/// Manages a aws_sagemaker_user_profile resource.
/// </summary>
public partial class AwsSagemakerUserProfile(string name) : TerraformResource("aws_sagemaker_user_profile", name)
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
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SingleSignOnUserIdentifier
    {
        get => GetArgument<TerraformValue<string>>("single_sign_on_user_identifier");
        set => SetArgument("single_sign_on_user_identifier", value);
    }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    public TerraformValue<string>? SingleSignOnUserValue
    {
        get => GetArgument<TerraformValue<string>>("single_sign_on_user_value");
        set => SetArgument("single_sign_on_user_value", value);
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
    /// The user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserProfileName is required")]
    public required TerraformValue<string> UserProfileName
    {
        get => GetArgument<TerraformValue<string>>("user_profile_name");
        set => SetArgument("user_profile_name", value);
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
    /// UserSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserSettings block(s) allowed")]
    public TerraformList<AwsSagemakerUserProfileUserSettingsBlock>? UserSettings
    {
        get => GetArgument<TerraformList<AwsSagemakerUserProfileUserSettingsBlock>>("user_settings");
        set => SetArgument("user_settings", value);
    }

}
