using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifacts in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectArtifactsBlock : TerraformBlock
{
    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ArtifactIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("artifact_identifier");
        set => WithProperty("artifact_identifier", value);
    }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformProperty<string>? BucketOwnerAccess
    {
        get => GetProperty<TerraformProperty<string>>("bucket_owner_access");
        set => WithProperty("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_disabled");
        set => WithProperty("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceType
    {
        get => GetProperty<TerraformProperty<string>>("namespace_type");
        set => WithProperty("namespace_type", value);
    }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    public TerraformProperty<bool>? OverrideArtifactName
    {
        get => GetProperty<TerraformProperty<bool>>("override_artifact_name");
        set => WithProperty("override_artifact_name", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformProperty<string>? Packaging
    {
        get => GetProperty<TerraformProperty<string>>("packaging");
        set => WithProperty("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for build_batch_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectBuildBatchConfigBlock : TerraformBlock
{
    /// <summary>
    /// The combine_artifacts attribute.
    /// </summary>
    public TerraformProperty<bool>? CombineArtifacts
    {
        get => GetProperty<TerraformProperty<bool>>("combine_artifacts");
        set => WithProperty("combine_artifacts", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetProperty<TerraformProperty<string>>("service_role");
        set => WithProperty("service_role", value);
    }

    /// <summary>
    /// The timeout_in_mins attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInMins
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_mins");
        set => WithProperty("timeout_in_mins", value);
    }

}

/// <summary>
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectCacheBlock : TerraformBlock
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The modes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Modes
    {
        get => GetProperty<List<TerraformProperty<string>>>("modes");
        set => WithProperty("modes", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for environment in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => WithProperty("certificate", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformProperty<string> ComputeType
    {
        get => GetProperty<TerraformProperty<string>>("compute_type");
        set => WithProperty("compute_type", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
    }

    /// <summary>
    /// The image_pull_credentials_type attribute.
    /// </summary>
    public TerraformProperty<string>? ImagePullCredentialsType
    {
        get => GetProperty<TerraformProperty<string>>("image_pull_credentials_type");
        set => WithProperty("image_pull_credentials_type", value);
    }

    /// <summary>
    /// The privileged_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivilegedMode
    {
        get => GetProperty<TerraformProperty<bool>>("privileged_mode");
        set => WithProperty("privileged_mode", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for file_system_locations in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectFileSystemLocationsBlock : TerraformBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => WithProperty("identifier", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformProperty<string>? MountOptions
    {
        get => GetProperty<TerraformProperty<string>>("mount_options");
        set => WithProperty("mount_options", value);
    }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    public TerraformProperty<string>? MountPoint
    {
        get => GetProperty<TerraformProperty<string>>("mount_point");
        set => WithProperty("mount_point", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for logs_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectLogsConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for secondary_artifacts in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondaryArtifactsBlock : TerraformBlock
{
    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactIdentifier is required")]
    public required TerraformProperty<string> ArtifactIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("artifact_identifier");
        set => WithProperty("artifact_identifier", value);
    }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformProperty<string>? BucketOwnerAccess
    {
        get => GetProperty<TerraformProperty<string>>("bucket_owner_access");
        set => WithProperty("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_disabled");
        set => WithProperty("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceType
    {
        get => GetProperty<TerraformProperty<string>>("namespace_type");
        set => WithProperty("namespace_type", value);
    }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    public TerraformProperty<bool>? OverrideArtifactName
    {
        get => GetProperty<TerraformProperty<bool>>("override_artifact_name");
        set => WithProperty("override_artifact_name", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformProperty<string>? Packaging
    {
        get => GetProperty<TerraformProperty<string>>("packaging");
        set => WithProperty("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for secondary_source_version in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondarySourceVersionBlock : TerraformBlock
{
    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    public required TerraformProperty<string> SourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_identifier");
        set => WithProperty("source_identifier", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVersion is required")]
    public required TerraformProperty<string> SourceVersion
    {
        get => GetProperty<TerraformProperty<string>>("source_version");
        set => WithProperty("source_version", value);
    }

}

/// <summary>
/// Block type for secondary_sources in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondarySourcesBlock : TerraformBlock
{
    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    public TerraformProperty<string>? Buildspec
    {
        get => GetProperty<TerraformProperty<string>>("buildspec");
        set => WithProperty("buildspec", value);
    }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    public TerraformProperty<double>? GitCloneDepth
    {
        get => GetProperty<TerraformProperty<double>>("git_clone_depth");
        set => WithProperty("git_clone_depth", value);
    }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    public TerraformProperty<bool>? InsecureSsl
    {
        get => GetProperty<TerraformProperty<bool>>("insecure_ssl");
        set => WithProperty("insecure_ssl", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    public TerraformProperty<bool>? ReportBuildStatus
    {
        get => GetProperty<TerraformProperty<bool>>("report_build_status");
        set => WithProperty("report_build_status", value);
    }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    public required TerraformProperty<string> SourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_identifier");
        set => WithProperty("source_identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSourceBlock : TerraformBlock
{
    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    public TerraformProperty<string>? Buildspec
    {
        get => GetProperty<TerraformProperty<string>>("buildspec");
        set => WithProperty("buildspec", value);
    }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    public TerraformProperty<double>? GitCloneDepth
    {
        get => GetProperty<TerraformProperty<double>>("git_clone_depth");
        set => WithProperty("git_clone_depth", value);
    }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    public TerraformProperty<bool>? InsecureSsl
    {
        get => GetProperty<TerraformProperty<bool>>("insecure_ssl");
        set => WithProperty("insecure_ssl", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    public TerraformProperty<bool>? ReportBuildStatus
    {
        get => GetProperty<TerraformProperty<bool>>("report_build_status");
        set => WithProperty("report_build_status", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_codebuild_project resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodebuildProject : TerraformResource
{
    public AwsCodebuildProject(string name) : base("aws_codebuild_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("badge_url");
        this.DeclareOutput("public_project_alias");
    }

    /// <summary>
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    public TerraformProperty<double>? AutoRetryLimit
    {
        get => GetProperty<TerraformProperty<double>>("auto_retry_limit");
        set => this.WithProperty("auto_retry_limit", value);
    }

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BadgeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("badge_enabled");
        set => this.WithProperty("badge_enabled", value);
    }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? BuildTimeout
    {
        get => GetProperty<TerraformProperty<double>>("build_timeout");
        set => this.WithProperty("build_timeout", value);
    }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ConcurrentBuildLimit
    {
        get => GetProperty<TerraformProperty<double>>("concurrent_build_limit");
        set => this.WithProperty("concurrent_build_limit", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key");
        set => this.WithProperty("encryption_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    public TerraformProperty<string>? ProjectVisibility
    {
        get => GetProperty<TerraformProperty<string>>("project_visibility");
        set => this.WithProperty("project_visibility", value);
    }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? QueuedTimeout
    {
        get => GetProperty<TerraformProperty<double>>("queued_timeout");
        set => this.WithProperty("queued_timeout", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_access_role attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceAccessRole
    {
        get => GetProperty<TerraformProperty<string>>("resource_access_role");
        set => this.WithProperty("resource_access_role", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetProperty<TerraformProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVersion
    {
        get => GetProperty<TerraformProperty<string>>("source_version");
        set => this.WithProperty("source_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for artifacts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Artifacts block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Artifacts block(s) allowed")]
    public List<AwsCodebuildProjectArtifactsBlock>? Artifacts
    {
        get => GetProperty<List<AwsCodebuildProjectArtifactsBlock>>("artifacts");
        set => this.WithProperty("artifacts", value);
    }

    /// <summary>
    /// Block for build_batch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildBatchConfig block(s) allowed")]
    public List<AwsCodebuildProjectBuildBatchConfigBlock>? BuildBatchConfig
    {
        get => GetProperty<List<AwsCodebuildProjectBuildBatchConfigBlock>>("build_batch_config");
        set => this.WithProperty("build_batch_config", value);
    }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    public List<AwsCodebuildProjectCacheBlock>? Cache
    {
        get => GetProperty<List<AwsCodebuildProjectCacheBlock>>("cache");
        set => this.WithProperty("cache", value);
    }

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Environment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public List<AwsCodebuildProjectEnvironmentBlock>? Environment
    {
        get => GetProperty<List<AwsCodebuildProjectEnvironmentBlock>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// Block for file_system_locations.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodebuildProjectFileSystemLocationsBlock>? FileSystemLocations
    {
        get => GetProperty<HashSet<AwsCodebuildProjectFileSystemLocationsBlock>>("file_system_locations");
        set => this.WithProperty("file_system_locations", value);
    }

    /// <summary>
    /// Block for logs_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogsConfig block(s) allowed")]
    public List<AwsCodebuildProjectLogsConfigBlock>? LogsConfig
    {
        get => GetProperty<List<AwsCodebuildProjectLogsConfigBlock>>("logs_config");
        set => this.WithProperty("logs_config", value);
    }

    /// <summary>
    /// Block for secondary_artifacts.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondaryArtifacts block(s) allowed")]
    public HashSet<AwsCodebuildProjectSecondaryArtifactsBlock>? SecondaryArtifacts
    {
        get => GetProperty<HashSet<AwsCodebuildProjectSecondaryArtifactsBlock>>("secondary_artifacts");
        set => this.WithProperty("secondary_artifacts", value);
    }

    /// <summary>
    /// Block for secondary_source_version.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySourceVersion block(s) allowed")]
    public HashSet<AwsCodebuildProjectSecondarySourceVersionBlock>? SecondarySourceVersion
    {
        get => GetProperty<HashSet<AwsCodebuildProjectSecondarySourceVersionBlock>>("secondary_source_version");
        set => this.WithProperty("secondary_source_version", value);
    }

    /// <summary>
    /// Block for secondary_sources.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySources block(s) allowed")]
    public HashSet<AwsCodebuildProjectSecondarySourcesBlock>? SecondarySources
    {
        get => GetProperty<HashSet<AwsCodebuildProjectSecondarySourcesBlock>>("secondary_sources");
        set => this.WithProperty("secondary_sources", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AwsCodebuildProjectSourceBlock>? Source
    {
        get => GetProperty<List<AwsCodebuildProjectSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsCodebuildProjectVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsCodebuildProjectVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The badge_url attribute.
    /// </summary>
    public TerraformExpression BadgeUrl => this["badge_url"];

    /// <summary>
    /// The public_project_alias attribute.
    /// </summary>
    public TerraformExpression PublicProjectAlias => this["public_project_alias"];

}
