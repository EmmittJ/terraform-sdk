using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifacts in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectArtifactsBlock
{
    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    [TerraformPropertyName("artifact_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ArtifactIdentifier { get; set; }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    [TerraformPropertyName("bucket_owner_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketOwnerAccess { get; set; }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    [TerraformPropertyName("namespace_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamespaceType { get; set; }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    [TerraformPropertyName("override_artifact_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OverrideArtifactName { get; set; }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    [TerraformPropertyName("packaging")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Packaging { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for build_batch_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectBuildBatchConfigBlock
{
    /// <summary>
    /// The combine_artifacts attribute.
    /// </summary>
    [TerraformPropertyName("combine_artifacts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CombineArtifacts { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformPropertyName("service_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The timeout_in_mins attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_mins")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInMins { get; set; }

}

/// <summary>
/// Block type for cache in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectCacheBlock
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The modes attribute.
    /// </summary>
    [TerraformPropertyName("modes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Modes { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for environment in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectEnvironmentBlock
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    [TerraformPropertyName("compute_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ComputeType { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformPropertyName("image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The image_pull_credentials_type attribute.
    /// </summary>
    [TerraformPropertyName("image_pull_credentials_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImagePullCredentialsType { get; set; }

    /// <summary>
    /// The privileged_mode attribute.
    /// </summary>
    [TerraformPropertyName("privileged_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivilegedMode { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for file_system_locations in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectFileSystemLocationsBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Identifier { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    [TerraformPropertyName("mount_options")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MountOptions { get; set; }

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [TerraformPropertyName("mount_point")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MountPoint { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for logs_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectLogsConfigBlock
{
}

/// <summary>
/// Block type for secondary_artifacts in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondaryArtifactsBlock
{
    /// <summary>
    /// The artifact_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactIdentifier is required")]
    [TerraformPropertyName("artifact_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ArtifactIdentifier { get; set; }

    /// <summary>
    /// The bucket_owner_access attribute.
    /// </summary>
    [TerraformPropertyName("bucket_owner_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketOwnerAccess { get; set; }

    /// <summary>
    /// The encryption_disabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The namespace_type attribute.
    /// </summary>
    [TerraformPropertyName("namespace_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamespaceType { get; set; }

    /// <summary>
    /// The override_artifact_name attribute.
    /// </summary>
    [TerraformPropertyName("override_artifact_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OverrideArtifactName { get; set; }

    /// <summary>
    /// The packaging attribute.
    /// </summary>
    [TerraformPropertyName("packaging")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Packaging { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for secondary_source_version in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondarySourceVersionBlock
{
    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    [TerraformPropertyName("source_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceIdentifier { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVersion is required")]
    [TerraformPropertyName("source_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceVersion { get; set; }

}

/// <summary>
/// Block type for secondary_sources in .
/// Nesting mode: set
/// </summary>
public class AwsCodebuildProjectSecondarySourcesBlock
{
    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    [TerraformPropertyName("buildspec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Buildspec { get; set; }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    [TerraformPropertyName("git_clone_depth")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? GitCloneDepth { get; set; }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    [TerraformPropertyName("insecure_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InsecureSsl { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    [TerraformPropertyName("report_build_status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReportBuildStatus { get; set; }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIdentifier is required")]
    [TerraformPropertyName("source_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceIdentifier { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectSourceBlock
{
    /// <summary>
    /// The buildspec attribute.
    /// </summary>
    [TerraformPropertyName("buildspec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Buildspec { get; set; }

    /// <summary>
    /// The git_clone_depth attribute.
    /// </summary>
    [TerraformPropertyName("git_clone_depth")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? GitCloneDepth { get; set; }

    /// <summary>
    /// The insecure_ssl attribute.
    /// </summary>
    [TerraformPropertyName("insecure_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InsecureSsl { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The report_build_status attribute.
    /// </summary>
    [TerraformPropertyName("report_build_status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReportBuildStatus { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildProjectVpcConfigBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_codebuild_project resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodebuildProject : TerraformResource
{
    public AwsCodebuildProject(string name) : base("aws_codebuild_project", name)
    {
    }

    /// <summary>
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    [TerraformPropertyName("auto_retry_limit")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AutoRetryLimit { get; set; } = default!;

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    [TerraformPropertyName("badge_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BadgeEnabled { get; set; }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    [TerraformPropertyName("build_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BuildTimeout { get; set; }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    [TerraformPropertyName("concurrent_build_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ConcurrentBuildLimit { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EncryptionKey { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    [TerraformPropertyName("project_visibility")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProjectVisibility { get; set; }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    [TerraformPropertyName("queued_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? QueuedTimeout { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_access_role attribute.
    /// </summary>
    [TerraformPropertyName("resource_access_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceAccessRole { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformPropertyName("service_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [TerraformPropertyName("source_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for artifacts.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Artifacts is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Artifacts block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Artifacts block(s) allowed")]
    [TerraformPropertyName("artifacts")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectArtifactsBlock>>? Artifacts { get; set; }

    /// <summary>
    /// Block for build_batch_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildBatchConfig block(s) allowed")]
    [TerraformPropertyName("build_batch_config")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectBuildBatchConfigBlock>>? BuildBatchConfig { get; set; }

    /// <summary>
    /// Block for cache.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cache block(s) allowed")]
    [TerraformPropertyName("cache")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectCacheBlock>>? Cache { get; set; }

    /// <summary>
    /// Block for environment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Environment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Environment block(s) allowed")]
    [TerraformPropertyName("environment")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectEnvironmentBlock>>? Environment { get; set; }

    /// <summary>
    /// Block for file_system_locations.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("file_system_locations")]
    public TerraformSet<TerraformBlock<AwsCodebuildProjectFileSystemLocationsBlock>>? FileSystemLocations { get; set; }

    /// <summary>
    /// Block for logs_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogsConfig block(s) allowed")]
    [TerraformPropertyName("logs_config")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectLogsConfigBlock>>? LogsConfig { get; set; }

    /// <summary>
    /// Block for secondary_artifacts.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondaryArtifacts block(s) allowed")]
    [TerraformPropertyName("secondary_artifacts")]
    public TerraformSet<TerraformBlock<AwsCodebuildProjectSecondaryArtifactsBlock>>? SecondaryArtifacts { get; set; }

    /// <summary>
    /// Block for secondary_source_version.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySourceVersion block(s) allowed")]
    [TerraformPropertyName("secondary_source_version")]
    public TerraformSet<TerraformBlock<AwsCodebuildProjectSecondarySourceVersionBlock>>? SecondarySourceVersion { get; set; }

    /// <summary>
    /// Block for secondary_sources.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 SecondarySources block(s) allowed")]
    [TerraformPropertyName("secondary_sources")]
    public TerraformSet<TerraformBlock<AwsCodebuildProjectSecondarySourcesBlock>>? SecondarySources { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsCodebuildProjectVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The badge_url attribute.
    /// </summary>
    [TerraformPropertyName("badge_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BadgeUrl => new TerraformReference(this, "badge_url");

    /// <summary>
    /// The public_project_alias attribute.
    /// </summary>
    [TerraformPropertyName("public_project_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicProjectAlias => new TerraformReference(this, "public_project_alias");

}
