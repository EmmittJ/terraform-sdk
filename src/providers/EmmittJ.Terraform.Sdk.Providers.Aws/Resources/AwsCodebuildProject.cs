using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifacts in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectArtifactsBlock() : TerraformBlock("artifacts")
{
    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    [TerraformProperty("artifact_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ArtifactIdentifier { get; set; }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    [TerraformProperty("bucket_owner_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketOwnerAccess { get; set; }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    [TerraformProperty("encryption_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    [TerraformProperty("namespace_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespaceType { get; set; }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    [TerraformProperty("override_artifact_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OverrideArtifactName { get; set; }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    [TerraformProperty("packaging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Packaging { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for build_batch_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectBuildBatchConfigBlock() : TerraformBlock("build_batch_config")
{
    /// <summary>
    /// The combine_artifacts attribute.
    /// </summary>
    [TerraformProperty("combine_artifacts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CombineArtifacts { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformProperty("service_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The timeout_in_mins attribute.
    /// </summary>
    [TerraformProperty("timeout_in_mins")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInMins { get; set; }

}

/// <summary>
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectCacheBlock() : TerraformBlock("cache")
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The modes attribute.
    /// </summary>
    [TerraformProperty("modes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Modes { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for environment in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectEnvironmentBlock() : TerraformBlock("environment")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    [TerraformProperty("compute_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ComputeType { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The image_pull_credentials_type attribute.
    /// </summary>
    [TerraformProperty("image_pull_credentials_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImagePullCredentialsType { get; set; }

    /// <summary>
    /// The privileged_mode attribute.
    /// </summary>
    [TerraformProperty("privileged_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivilegedMode { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for file_system_locations in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodebuildProjectFileSystemLocationsBlock() : TerraformBlock("file_system_locations")
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformProperty("identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Identifier { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    [TerraformProperty("mount_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MountOptions { get; set; }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [TerraformProperty("mount_point")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MountPoint { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for logs_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectLogsConfigBlock() : TerraformBlock("logs_config")
{
}

/// <summary>
/// Block type for secondary_artifacts in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodebuildProjectSecondaryArtifactsBlock() : TerraformBlock("secondary_artifacts")
{
    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactIdentifier is required")]
    [TerraformProperty("artifact_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ArtifactIdentifier { get; set; }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    [TerraformProperty("bucket_owner_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketOwnerAccess { get; set; }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    [TerraformProperty("encryption_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    [TerraformProperty("namespace_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespaceType { get; set; }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    [TerraformProperty("override_artifact_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OverrideArtifactName { get; set; }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    [TerraformProperty("packaging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Packaging { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for secondary_source_version in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodebuildProjectSecondarySourceVersionBlock() : TerraformBlock("secondary_source_version")
{
    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    [TerraformProperty("source_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceIdentifier { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVersion is required")]
    [TerraformProperty("source_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceVersion { get; set; }

}

/// <summary>
/// Block type for secondary_sources in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodebuildProjectSecondarySourcesBlock() : TerraformBlock("secondary_sources")
{
    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    [TerraformProperty("buildspec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Buildspec { get; set; }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    [TerraformProperty("git_clone_depth")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? GitCloneDepth { get; set; }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    [TerraformProperty("insecure_ssl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InsecureSsl { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    [TerraformProperty("report_build_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReportBuildStatus { get; set; }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    [TerraformProperty("source_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceIdentifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectSourceBlock() : TerraformBlock("source")
{
    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    [TerraformProperty("buildspec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Buildspec { get; set; }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    [TerraformProperty("git_clone_depth")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? GitCloneDepth { get; set; }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    [TerraformProperty("insecure_ssl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InsecureSsl { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    [TerraformProperty("report_build_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReportBuildStatus { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildProjectVpcConfigBlock() : TerraformBlock("vpc_config")
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_codebuild_project resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodebuildProject : TerraformResource
{
    public AwsCodebuildProject(string name) : base("aws_codebuild_project", name)
    {
    }

    /// <summary>
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    [TerraformProperty("auto_retry_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AutoRetryLimit { get; set; }

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    [TerraformProperty("badge_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BadgeEnabled { get; set; }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    [TerraformProperty("build_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BuildTimeout { get; set; }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    [TerraformProperty("concurrent_build_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ConcurrentBuildLimit { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformProperty("encryption_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EncryptionKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    [TerraformProperty("project_visibility")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectVisibility { get; set; }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    [TerraformProperty("queued_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueuedTimeout { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_access_role attribute.
    /// </summary>
    [TerraformProperty("resource_access_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceAccessRole { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformProperty("service_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [TerraformProperty("source_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for artifacts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Artifacts is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Artifacts block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Artifacts block(s) allowed")]
    [TerraformProperty("artifacts")]
    public required TerraformList<AwsCodebuildProjectArtifactsBlock> Artifacts { get; set; } = new();

    /// <summary>
    /// Block for build_batch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildBatchConfig block(s) allowed")]
    [TerraformProperty("build_batch_config")]
    public TerraformList<AwsCodebuildProjectBuildBatchConfigBlock> BuildBatchConfig { get; set; } = new();

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    [TerraformProperty("cache")]
    public TerraformList<AwsCodebuildProjectCacheBlock> Cache { get; set; } = new();

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Environment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    [TerraformProperty("environment")]
    public required TerraformList<AwsCodebuildProjectEnvironmentBlock> Environment { get; set; } = new();

    /// <summary>
    /// Block for file_system_locations.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("file_system_locations")]
    public TerraformSet<AwsCodebuildProjectFileSystemLocationsBlock> FileSystemLocations { get; set; } = new();

    /// <summary>
    /// Block for logs_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogsConfig block(s) allowed")]
    [TerraformProperty("logs_config")]
    public TerraformList<AwsCodebuildProjectLogsConfigBlock> LogsConfig { get; set; } = new();

    /// <summary>
    /// Block for secondary_artifacts.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondaryArtifacts block(s) allowed")]
    [TerraformProperty("secondary_artifacts")]
    public TerraformSet<AwsCodebuildProjectSecondaryArtifactsBlock> SecondaryArtifacts { get; set; } = new();

    /// <summary>
    /// Block for secondary_source_version.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySourceVersion block(s) allowed")]
    [TerraformProperty("secondary_source_version")]
    public TerraformSet<AwsCodebuildProjectSecondarySourceVersionBlock> SecondarySourceVersion { get; set; } = new();

    /// <summary>
    /// Block for secondary_sources.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySources block(s) allowed")]
    [TerraformProperty("secondary_sources")]
    public TerraformSet<AwsCodebuildProjectSecondarySourcesBlock> SecondarySources { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public required TerraformList<AwsCodebuildProjectSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public TerraformList<AwsCodebuildProjectVpcConfigBlock> VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The badge_url attribute.
    /// </summary>
    [TerraformProperty("badge_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BadgeUrl { get; }

    /// <summary>
    /// The public_project_alias attribute.
    /// </summary>
    [TerraformProperty("public_project_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicProjectAlias { get; }

}
