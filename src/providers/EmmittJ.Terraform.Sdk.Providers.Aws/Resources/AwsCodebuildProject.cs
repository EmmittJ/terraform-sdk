using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifacts in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectArtifactsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "artifacts";

    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ArtifactIdentifier
    {
        get => GetArgument<TerraformValue<string>>("artifact_identifier");
        set => SetArgument("artifact_identifier", value);
    }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccess
    {
        get => GetArgument<TerraformValue<string>>("bucket_owner_access");
        set => SetArgument("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionDisabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_disabled");
        set => SetArgument("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The namespace_type attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceType
    {
        get => GetArgument<TerraformValue<string>>("namespace_type");
        set => SetArgument("namespace_type", value);
    }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    public TerraformValue<bool>? OverrideArtifactName
    {
        get => GetArgument<TerraformValue<bool>>("override_artifact_name");
        set => SetArgument("override_artifact_name", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformValue<string>? Packaging
    {
        get => GetArgument<TerraformValue<string>>("packaging");
        set => SetArgument("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
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

}


/// <summary>
/// Block type for build_batch_config in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectBuildBatchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "build_batch_config";

    /// <summary>
    /// The combine_artifacts attribute.
    /// </summary>
    public TerraformValue<bool>? CombineArtifacts
    {
        get => GetArgument<TerraformValue<bool>>("combine_artifacts");
        set => SetArgument("combine_artifacts", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformValue<string> ServiceRole
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_role");
        set => SetArgument("service_role", value);
    }

    /// <summary>
    /// The timeout_in_mins attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMins
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_mins");
        set => SetArgument("timeout_in_mins", value);
    }

    /// <summary>
    /// Restrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    public TerraformList<AwsCodebuildProjectBuildBatchConfigBlockRestrictionsBlock>? Restrictions
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectBuildBatchConfigBlockRestrictionsBlock>>("restrictions");
        set => SetArgument("restrictions", value);
    }

}

/// <summary>
/// Block type for restrictions in AwsCodebuildProjectBuildBatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectBuildBatchConfigBlockRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restrictions";

    /// <summary>
    /// The compute_types_allowed attribute.
    /// </summary>
    public TerraformList<string>? ComputeTypesAllowed
    {
        get => GetArgument<TerraformList<string>>("compute_types_allowed");
        set => SetArgument("compute_types_allowed", value);
    }

    /// <summary>
    /// The maximum_builds_allowed attribute.
    /// </summary>
    public TerraformValue<double>? MaximumBuildsAllowed
    {
        get => GetArgument<TerraformValue<double>>("maximum_builds_allowed");
        set => SetArgument("maximum_builds_allowed", value);
    }

}


/// <summary>
/// Block type for cache in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectCacheBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache";

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The modes attribute.
    /// </summary>
    public TerraformList<string>? Modes
    {
        get => GetArgument<TerraformList<string>>("modes");
        set => SetArgument("modes", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for environment in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformValue<string> ComputeType
    {
        get => GetRequiredArgument<TerraformValue<string>>("compute_type");
        set => SetArgument("compute_type", value);
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
    /// The image_pull_credentials_type attribute.
    /// </summary>
    public TerraformValue<string>? ImagePullCredentialsType
    {
        get => GetArgument<TerraformValue<string>>("image_pull_credentials_type");
        set => SetArgument("image_pull_credentials_type", value);
    }

    /// <summary>
    /// The privileged_mode attribute.
    /// </summary>
    public TerraformValue<bool>? PrivilegedMode
    {
        get => GetArgument<TerraformValue<bool>>("privileged_mode");
        set => SetArgument("privileged_mode", value);
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
    /// DockerServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerServer block(s) allowed")]
    public TerraformList<AwsCodebuildProjectEnvironmentBlockDockerServerBlock>? DockerServer
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectEnvironmentBlockDockerServerBlock>>("docker_server");
        set => SetArgument("docker_server", value);
    }

    /// <summary>
    /// EnvironmentVariable block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodebuildProjectEnvironmentBlockEnvironmentVariableBlock>? EnvironmentVariable
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectEnvironmentBlockEnvironmentVariableBlock>>("environment_variable");
        set => SetArgument("environment_variable", value);
    }

    /// <summary>
    /// Fleet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public TerraformList<AwsCodebuildProjectEnvironmentBlockFleetBlock>? Fleet
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectEnvironmentBlockFleetBlock>>("fleet");
        set => SetArgument("fleet", value);
    }

    /// <summary>
    /// RegistryCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistryCredential block(s) allowed")]
    public TerraformList<AwsCodebuildProjectEnvironmentBlockRegistryCredentialBlock>? RegistryCredential
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectEnvironmentBlockRegistryCredentialBlock>>("registry_credential");
        set => SetArgument("registry_credential", value);
    }

}

/// <summary>
/// Block type for docker_server in AwsCodebuildProjectEnvironmentBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlockDockerServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker_server";

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformValue<string> ComputeType
    {
        get => GetRequiredArgument<TerraformValue<string>>("compute_type");
        set => SetArgument("compute_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformList<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformList<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

}

/// <summary>
/// Block type for environment_variable in AwsCodebuildProjectEnvironmentBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlockEnvironmentVariableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_variable";

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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
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
/// Block type for fleet in AwsCodebuildProjectEnvironmentBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlockFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet";

    /// <summary>
    /// The fleet_arn attribute.
    /// </summary>
    public TerraformValue<string>? FleetArn
    {
        get => GetArgument<TerraformValue<string>>("fleet_arn");
        set => SetArgument("fleet_arn", value);
    }

}

/// <summary>
/// Block type for registry_credential in AwsCodebuildProjectEnvironmentBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlockRegistryCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry_credential";

    /// <summary>
    /// The credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Credential is required")]
    public required TerraformValue<string> Credential
    {
        get => GetRequiredArgument<TerraformValue<string>>("credential");
        set => SetArgument("credential", value);
    }

    /// <summary>
    /// The credential_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialProvider is required")]
    public required TerraformValue<string> CredentialProvider
    {
        get => GetRequiredArgument<TerraformValue<string>>("credential_provider");
        set => SetArgument("credential_provider", value);
    }

}


/// <summary>
/// Block type for file_system_locations in AwsCodebuildProject.
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectFileSystemLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_locations";

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string>? Identifier
    {
        get => GetArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformValue<string>? MountOptions
    {
        get => GetArgument<TerraformValue<string>>("mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    public TerraformValue<string>? MountPoint
    {
        get => GetArgument<TerraformValue<string>>("mount_point");
        set => SetArgument("mount_point", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logs_config in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectLogsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs_config";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsCodebuildProjectLogsConfigBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectLogsConfigBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// S3Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Logs block(s) allowed")]
    public TerraformList<AwsCodebuildProjectLogsConfigBlockS3LogsBlock>? S3Logs
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectLogsConfigBlockS3LogsBlock>>("s3_logs");
        set => SetArgument("s3_logs", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsCodebuildProjectLogsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectLogsConfigBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformValue<string>? GroupName
    {
        get => GetArgument<TerraformValue<string>>("group_name");
        set => SetArgument("group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    public TerraformValue<string>? StreamName
    {
        get => GetArgument<TerraformValue<string>>("stream_name");
        set => SetArgument("stream_name", value);
    }

}

/// <summary>
/// Block type for s3_logs in AwsCodebuildProjectLogsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectLogsConfigBlockS3LogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_logs";

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccess
    {
        get => GetArgument<TerraformValue<string>>("bucket_owner_access");
        set => SetArgument("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionDisabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_disabled");
        set => SetArgument("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
/// Block type for secondary_artifacts in AwsCodebuildProject.
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondaryArtifactsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_artifacts";

    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactIdentifier is required")]
    public required TerraformValue<string> ArtifactIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("artifact_identifier");
        set => SetArgument("artifact_identifier", value);
    }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccess
    {
        get => GetArgument<TerraformValue<string>>("bucket_owner_access");
        set => SetArgument("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionDisabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_disabled");
        set => SetArgument("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The namespace_type attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceType
    {
        get => GetArgument<TerraformValue<string>>("namespace_type");
        set => SetArgument("namespace_type", value);
    }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    public TerraformValue<bool>? OverrideArtifactName
    {
        get => GetArgument<TerraformValue<bool>>("override_artifact_name");
        set => SetArgument("override_artifact_name", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformValue<string>? Packaging
    {
        get => GetArgument<TerraformValue<string>>("packaging");
        set => SetArgument("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
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

}


/// <summary>
/// Block type for secondary_source_version in AwsCodebuildProject.
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondarySourceVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_source_version";

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    public required TerraformValue<string> SourceIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_identifier");
        set => SetArgument("source_identifier", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVersion is required")]
    public required TerraformValue<string> SourceVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_version");
        set => SetArgument("source_version", value);
    }

}


/// <summary>
/// Block type for secondary_sources in AwsCodebuildProject.
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondarySourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_sources";

    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    public TerraformValue<string>? Buildspec
    {
        get => GetArgument<TerraformValue<string>>("buildspec");
        set => SetArgument("buildspec", value);
    }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    public TerraformValue<double>? GitCloneDepth
    {
        get => GetArgument<TerraformValue<double>>("git_clone_depth");
        set => SetArgument("git_clone_depth", value);
    }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    public TerraformValue<bool>? InsecureSsl
    {
        get => GetArgument<TerraformValue<bool>>("insecure_ssl");
        set => SetArgument("insecure_ssl", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    public TerraformValue<bool>? ReportBuildStatus
    {
        get => GetArgument<TerraformValue<bool>>("report_build_status");
        set => SetArgument("report_build_status", value);
    }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    public required TerraformValue<string> SourceIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_identifier");
        set => SetArgument("source_identifier", value);
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
    /// Auth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Auth block(s) allowed")]
    public TerraformList<AwsCodebuildProjectSecondarySourcesBlockAuthBlock>? Auth
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectSecondarySourcesBlockAuthBlock>>("auth");
        set => SetArgument("auth", value);
    }

    /// <summary>
    /// BuildStatusConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildStatusConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectSecondarySourcesBlockBuildStatusConfigBlock>? BuildStatusConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectSecondarySourcesBlockBuildStatusConfigBlock>>("build_status_config");
        set => SetArgument("build_status_config", value);
    }

    /// <summary>
    /// GitSubmodulesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitSubmodulesConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectSecondarySourcesBlockGitSubmodulesConfigBlock>? GitSubmodulesConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectSecondarySourcesBlockGitSubmodulesConfigBlock>>("git_submodules_config");
        set => SetArgument("git_submodules_config", value);
    }

}

/// <summary>
/// Block type for auth in AwsCodebuildProjectSecondarySourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSecondarySourcesBlockAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth";

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
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

}

/// <summary>
/// Block type for build_status_config in AwsCodebuildProjectSecondarySourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSecondarySourcesBlockBuildStatusConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "build_status_config";

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformValue<string>? Context
    {
        get => GetArgument<TerraformValue<string>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    public TerraformValue<string>? TargetUrl
    {
        get => GetArgument<TerraformValue<string>>("target_url");
        set => SetArgument("target_url", value);
    }

}

/// <summary>
/// Block type for git_submodules_config in AwsCodebuildProjectSecondarySourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSecondarySourcesBlockGitSubmodulesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_submodules_config";

    /// <summary>
    /// The fetch_submodules attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FetchSubmodules is required")]
    public required TerraformValue<bool> FetchSubmodules
    {
        get => GetRequiredArgument<TerraformValue<bool>>("fetch_submodules");
        set => SetArgument("fetch_submodules", value);
    }

}


/// <summary>
/// Block type for source in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    public TerraformValue<string>? Buildspec
    {
        get => GetArgument<TerraformValue<string>>("buildspec");
        set => SetArgument("buildspec", value);
    }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    public TerraformValue<double>? GitCloneDepth
    {
        get => GetArgument<TerraformValue<double>>("git_clone_depth");
        set => SetArgument("git_clone_depth", value);
    }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    public TerraformValue<bool>? InsecureSsl
    {
        get => GetArgument<TerraformValue<bool>>("insecure_ssl");
        set => SetArgument("insecure_ssl", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    public TerraformValue<bool>? ReportBuildStatus
    {
        get => GetArgument<TerraformValue<bool>>("report_build_status");
        set => SetArgument("report_build_status", value);
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
    /// Auth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Auth block(s) allowed")]
    public TerraformList<AwsCodebuildProjectSourceBlockAuthBlock>? Auth
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectSourceBlockAuthBlock>>("auth");
        set => SetArgument("auth", value);
    }

    /// <summary>
    /// BuildStatusConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildStatusConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectSourceBlockBuildStatusConfigBlock>? BuildStatusConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectSourceBlockBuildStatusConfigBlock>>("build_status_config");
        set => SetArgument("build_status_config", value);
    }

    /// <summary>
    /// GitSubmodulesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitSubmodulesConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectSourceBlockGitSubmodulesConfigBlock>? GitSubmodulesConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectSourceBlockGitSubmodulesConfigBlock>>("git_submodules_config");
        set => SetArgument("git_submodules_config", value);
    }

}

/// <summary>
/// Block type for auth in AwsCodebuildProjectSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSourceBlockAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth";

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
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

}

/// <summary>
/// Block type for build_status_config in AwsCodebuildProjectSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSourceBlockBuildStatusConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "build_status_config";

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformValue<string>? Context
    {
        get => GetArgument<TerraformValue<string>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The target_url attribute.
    /// </summary>
    public TerraformValue<string>? TargetUrl
    {
        get => GetArgument<TerraformValue<string>>("target_url");
        set => SetArgument("target_url", value);
    }

}

/// <summary>
/// Block type for git_submodules_config in AwsCodebuildProjectSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSourceBlockGitSubmodulesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_submodules_config";

    /// <summary>
    /// The fetch_submodules attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FetchSubmodules is required")]
    public required TerraformValue<bool> FetchSubmodules
    {
        get => GetRequiredArgument<TerraformValue<bool>>("fetch_submodules");
        set => SetArgument("fetch_submodules", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsCodebuildProject.
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
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

}


/// <summary>
/// Represents a aws_codebuild_project Terraform resource.
/// Manages a aws_codebuild_project resource.
/// </summary>
public partial class AwsCodebuildProject(string name) : TerraformResource("aws_codebuild_project", name)
{
    /// <summary>
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    public TerraformValue<double> AutoRetryLimit
    {
        get => GetArgument<TerraformValue<double>>("auto_retry_limit") ?? AsReference("auto_retry_limit");
        set => SetArgument("auto_retry_limit", value);
    }

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BadgeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("badge_enabled");
        set => SetArgument("badge_enabled", value);
    }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    public TerraformValue<double>? BuildTimeout
    {
        get => GetArgument<TerraformValue<double>>("build_timeout");
        set => SetArgument("build_timeout", value);
    }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    public TerraformValue<double>? ConcurrentBuildLimit
    {
        get => GetArgument<TerraformValue<double>>("concurrent_build_limit");
        set => SetArgument("concurrent_build_limit", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? AsReference("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKey
    {
        get => GetArgument<TerraformValue<string>>("encryption_key") ?? AsReference("encryption_key");
        set => SetArgument("encryption_key", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    public TerraformValue<string>? ProjectVisibility
    {
        get => GetArgument<TerraformValue<string>>("project_visibility");
        set => SetArgument("project_visibility", value);
    }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    public TerraformValue<double>? QueuedTimeout
    {
        get => GetArgument<TerraformValue<double>>("queued_timeout");
        set => SetArgument("queued_timeout", value);
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
    /// The resource_access_role attribute.
    /// </summary>
    public TerraformValue<string>? ResourceAccessRole
    {
        get => GetArgument<TerraformValue<string>>("resource_access_role");
        set => SetArgument("resource_access_role", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformValue<string> ServiceRole
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_role");
        set => SetArgument("service_role", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformValue<string>? SourceVersion
    {
        get => GetArgument<TerraformValue<string>>("source_version");
        set => SetArgument("source_version", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The badge_url attribute.
    /// </summary>
    public TerraformValue<string> BadgeUrl
        => AsReference("badge_url");

    /// <summary>
    /// The public_project_alias attribute.
    /// </summary>
    public TerraformValue<string> PublicProjectAlias
        => AsReference("public_project_alias");

    /// <summary>
    /// Artifacts block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Artifacts is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Artifacts block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Artifacts block(s) allowed")]
    public required TerraformList<AwsCodebuildProjectArtifactsBlock> Artifacts
    {
        get => GetRequiredArgument<TerraformList<AwsCodebuildProjectArtifactsBlock>>("artifacts");
        set => SetArgument("artifacts", value);
    }

    /// <summary>
    /// BuildBatchConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildBatchConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectBuildBatchConfigBlock>? BuildBatchConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectBuildBatchConfigBlock>>("build_batch_config");
        set => SetArgument("build_batch_config", value);
    }

    /// <summary>
    /// Cache block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    public TerraformList<AwsCodebuildProjectCacheBlock>? Cache
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectCacheBlock>>("cache");
        set => SetArgument("cache", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Environment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public required TerraformList<AwsCodebuildProjectEnvironmentBlock> Environment
    {
        get => GetRequiredArgument<TerraformList<AwsCodebuildProjectEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// FileSystemLocations block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCodebuildProjectFileSystemLocationsBlock>? FileSystemLocations
    {
        get => GetArgument<TerraformSet<AwsCodebuildProjectFileSystemLocationsBlock>>("file_system_locations");
        set => SetArgument("file_system_locations", value);
    }

    /// <summary>
    /// LogsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogsConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectLogsConfigBlock>? LogsConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectLogsConfigBlock>>("logs_config");
        set => SetArgument("logs_config", value);
    }

    /// <summary>
    /// SecondaryArtifacts block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondaryArtifacts block(s) allowed")]
    public TerraformSet<AwsCodebuildProjectSecondaryArtifactsBlock>? SecondaryArtifacts
    {
        get => GetArgument<TerraformSet<AwsCodebuildProjectSecondaryArtifactsBlock>>("secondary_artifacts");
        set => SetArgument("secondary_artifacts", value);
    }

    /// <summary>
    /// SecondarySourceVersion block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySourceVersion block(s) allowed")]
    public TerraformSet<AwsCodebuildProjectSecondarySourceVersionBlock>? SecondarySourceVersion
    {
        get => GetArgument<TerraformSet<AwsCodebuildProjectSecondarySourceVersionBlock>>("secondary_source_version");
        set => SetArgument("secondary_source_version", value);
    }

    /// <summary>
    /// SecondarySources block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySources block(s) allowed")]
    public TerraformSet<AwsCodebuildProjectSecondarySourcesBlock>? SecondarySources
    {
        get => GetArgument<TerraformSet<AwsCodebuildProjectSecondarySourcesBlock>>("secondary_sources");
        set => SetArgument("secondary_sources", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AwsCodebuildProjectSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AwsCodebuildProjectSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsCodebuildProjectVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsCodebuildProjectVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
