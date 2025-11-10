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
        set => SetProperty("artifact_identifier", value);
    }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformProperty<string>? BucketOwnerAccess
    {
        set => SetProperty("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionDisabled
    {
        set => SetProperty("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceType
    {
        set => SetProperty("namespace_type", value);
    }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    public TerraformProperty<bool>? OverrideArtifactName
    {
        set => SetProperty("override_artifact_name", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformProperty<string>? Packaging
    {
        set => SetProperty("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("combine_artifacts", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        set => SetProperty("service_role", value);
    }

    /// <summary>
    /// The timeout_in_mins attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInMins
    {
        set => SetProperty("timeout_in_mins", value);
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
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The modes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Modes
    {
        set => SetProperty("modes", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformProperty<string> ComputeType
    {
        set => SetProperty("compute_type", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The image_pull_credentials_type attribute.
    /// </summary>
    public TerraformProperty<string>? ImagePullCredentialsType
    {
        set => SetProperty("image_pull_credentials_type", value);
    }

    /// <summary>
    /// The privileged_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivilegedMode
    {
        set => SetProperty("privileged_mode", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformProperty<string>? MountOptions
    {
        set => SetProperty("mount_options", value);
    }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    public TerraformProperty<string>? MountPoint
    {
        set => SetProperty("mount_point", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("artifact_identifier", value);
    }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    public TerraformProperty<string>? BucketOwnerAccess
    {
        set => SetProperty("bucket_owner_access", value);
    }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionDisabled
    {
        set => SetProperty("encryption_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceType
    {
        set => SetProperty("namespace_type", value);
    }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    public TerraformProperty<bool>? OverrideArtifactName
    {
        set => SetProperty("override_artifact_name", value);
    }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    public TerraformProperty<string>? Packaging
    {
        set => SetProperty("packaging", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("source_identifier", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVersion is required")]
    public required TerraformProperty<string> SourceVersion
    {
        set => SetProperty("source_version", value);
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
        set => SetProperty("buildspec", value);
    }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    public TerraformProperty<double>? GitCloneDepth
    {
        set => SetProperty("git_clone_depth", value);
    }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    public TerraformProperty<bool>? InsecureSsl
    {
        set => SetProperty("insecure_ssl", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    public TerraformProperty<bool>? ReportBuildStatus
    {
        set => SetProperty("report_build_status", value);
    }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    public required TerraformProperty<string> SourceIdentifier
    {
        set => SetProperty("source_identifier", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("buildspec", value);
    }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    public TerraformProperty<double>? GitCloneDepth
    {
        set => SetProperty("git_clone_depth", value);
    }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    public TerraformProperty<bool>? InsecureSsl
    {
        set => SetProperty("insecure_ssl", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    public TerraformProperty<bool>? ReportBuildStatus
    {
        set => SetProperty("report_build_status", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        set => SetProperty("vpc_id", value);
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
        SetOutput("arn");
        SetOutput("badge_url");
        SetOutput("public_project_alias");
        SetOutput("auto_retry_limit");
        SetOutput("badge_enabled");
        SetOutput("build_timeout");
        SetOutput("concurrent_build_limit");
        SetOutput("description");
        SetOutput("encryption_key");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project_visibility");
        SetOutput("queued_timeout");
        SetOutput("region");
        SetOutput("resource_access_role");
        SetOutput("service_role");
        SetOutput("source_version");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    public TerraformProperty<double> AutoRetryLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("auto_retry_limit");
        set => SetProperty("auto_retry_limit", value);
    }

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BadgeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("badge_enabled");
        set => SetProperty("badge_enabled", value);
    }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    public TerraformProperty<double> BuildTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("build_timeout");
        set => SetProperty("build_timeout", value);
    }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    public TerraformProperty<double> ConcurrentBuildLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("concurrent_build_limit");
        set => SetProperty("concurrent_build_limit", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_key");
        set => SetProperty("encryption_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    public TerraformProperty<string> ProjectVisibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_visibility");
        set => SetProperty("project_visibility", value);
    }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    public TerraformProperty<double> QueuedTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("queued_timeout");
        set => SetProperty("queued_timeout", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_access_role attribute.
    /// </summary>
    public TerraformProperty<string> ResourceAccessRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_access_role");
        set => SetProperty("resource_access_role", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role");
        set => SetProperty("service_role", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformProperty<string> SourceVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_version");
        set => SetProperty("source_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for artifacts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Artifacts is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Artifacts block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Artifacts block(s) allowed")]
    public List<AwsCodebuildProjectArtifactsBlock>? Artifacts
    {
        set => SetProperty("artifacts", value);
    }

    /// <summary>
    /// Block for build_batch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildBatchConfig block(s) allowed")]
    public List<AwsCodebuildProjectBuildBatchConfigBlock>? BuildBatchConfig
    {
        set => SetProperty("build_batch_config", value);
    }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    public List<AwsCodebuildProjectCacheBlock>? Cache
    {
        set => SetProperty("cache", value);
    }

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Environment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    public List<AwsCodebuildProjectEnvironmentBlock>? Environment
    {
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// Block for file_system_locations.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCodebuildProjectFileSystemLocationsBlock>? FileSystemLocations
    {
        set => SetProperty("file_system_locations", value);
    }

    /// <summary>
    /// Block for logs_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogsConfig block(s) allowed")]
    public List<AwsCodebuildProjectLogsConfigBlock>? LogsConfig
    {
        set => SetProperty("logs_config", value);
    }

    /// <summary>
    /// Block for secondary_artifacts.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondaryArtifacts block(s) allowed")]
    public HashSet<AwsCodebuildProjectSecondaryArtifactsBlock>? SecondaryArtifacts
    {
        set => SetProperty("secondary_artifacts", value);
    }

    /// <summary>
    /// Block for secondary_source_version.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySourceVersion block(s) allowed")]
    public HashSet<AwsCodebuildProjectSecondarySourceVersionBlock>? SecondarySourceVersion
    {
        set => SetProperty("secondary_source_version", value);
    }

    /// <summary>
    /// Block for secondary_sources.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySources block(s) allowed")]
    public HashSet<AwsCodebuildProjectSecondarySourcesBlock>? SecondarySources
    {
        set => SetProperty("secondary_sources", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AwsCodebuildProjectSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsCodebuildProjectVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
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
