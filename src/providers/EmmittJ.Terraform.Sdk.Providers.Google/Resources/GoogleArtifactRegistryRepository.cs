using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cleanup_policies in .
/// Nesting mode: set
/// </summary>
public class GoogleArtifactRegistryRepositoryCleanupPoliciesBlock
{
    /// <summary>
    /// Policy action. Possible values: [&amp;quot;DELETE&amp;quot;, &amp;quot;KEEP&amp;quot;]
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for docker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryDockerConfigBlock
{
    /// <summary>
    /// The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.
    /// </summary>
    [TerraformPropertyName("immutable_tags")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ImmutableTags { get; set; }

}

/// <summary>
/// Block type for maven_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryMavenConfigBlock
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    [TerraformPropertyName("allow_snapshot_overwrites")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowSnapshotOverwrites { get; set; }

    /// <summary>
    /// Version policy defines the versions that the registry will accept. Default value: &amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RELEASE&amp;quot;, &amp;quot;SNAPSHOT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("version_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionPolicy { get; set; }

}

/// <summary>
/// Block type for remote_repository_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock
{
    /// <summary>
    /// The description of the remote source.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    [TerraformPropertyName("disable_upstream_validation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableUpstreamValidation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleArtifactRegistryRepositoryTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_repository_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock
{
}

/// <summary>
/// Block type for vulnerability_scanning_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository. Possible values: [&amp;quot;INHERITED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("enablement_config")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EnablementConfig { get; set; }



}

/// <summary>
/// Manages a google_artifact_registry_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleArtifactRegistryRepository : TerraformResource
{
    public GoogleArtifactRegistryRepository(string name) : base("google_artifact_registry_repository", name)
    {
    }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [TerraformPropertyName("cleanup_policy_dry_run")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CleanupPolicyDryRun { get; set; }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// This field may contain up to 64 entries. Label keys and values may be no
    /// longer than 63 characters. Label keys must begin with a lowercase letter
    /// and may only contain lowercase letters, numeric characters, underscores,
    /// and dashes.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Location { get; set; } = default!;

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// Block for cleanup_policies.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cleanup_policies")]
    public TerraformSet<TerraformBlock<GoogleArtifactRegistryRepositoryCleanupPoliciesBlock>>? CleanupPolicies { get; set; }

    /// <summary>
    /// Block for docker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerConfig block(s) allowed")]
    [TerraformPropertyName("docker_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryDockerConfigBlock>>? DockerConfig { get; set; }

    /// <summary>
    /// Block for maven_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MavenConfig block(s) allowed")]
    [TerraformPropertyName("maven_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryMavenConfigBlock>>? MavenConfig { get; set; }

    /// <summary>
    /// Block for remote_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteRepositoryConfig block(s) allowed")]
    [TerraformPropertyName("remote_repository_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock>>? RemoteRepositoryConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleArtifactRegistryRepositoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualRepositoryConfig block(s) allowed")]
    [TerraformPropertyName("virtual_repository_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock>>? VirtualRepositoryConfig { get; set; }

    /// <summary>
    /// Block for vulnerability_scanning_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VulnerabilityScanningConfig block(s) allowed")]
    [TerraformPropertyName("vulnerability_scanning_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock>>? VulnerabilityScanningConfig { get; set; }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    [TerraformPropertyName("registry_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegistryUri => new TerraformReference(this, "registry_uri");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
