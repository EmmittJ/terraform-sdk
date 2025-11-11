using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cleanup_policies in .
/// Nesting mode: set
/// </summary>
public partial class GoogleArtifactRegistryRepositoryCleanupPoliciesBlock : TerraformBlockBase
{
    /// <summary>
    /// Policy action. Possible values: [&amp;quot;DELETE&amp;quot;, &amp;quot;KEEP&amp;quot;]
    /// </summary>
    [TerraformProperty("action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for docker_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleArtifactRegistryRepositoryDockerConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.
    /// </summary>
    [TerraformProperty("immutable_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ImmutableTags { get; set; }

}

/// <summary>
/// Block type for maven_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleArtifactRegistryRepositoryMavenConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    [TerraformProperty("allow_snapshot_overwrites")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowSnapshotOverwrites { get; set; }

    /// <summary>
    /// Version policy defines the versions that the registry will accept. Default value: &amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RELEASE&amp;quot;, &amp;quot;SNAPSHOT&amp;quot;]
    /// </summary>
    [TerraformProperty("version_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VersionPolicy { get; set; }

}

/// <summary>
/// Block type for remote_repository_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The description of the remote source.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    [TerraformProperty("disable_upstream_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableUpstreamValidation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleArtifactRegistryRepositoryTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_repository_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for vulnerability_scanning_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository. Possible values: [&amp;quot;INHERITED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("enablement_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnablementConfig { get; set; }



}

/// <summary>
/// Manages a google_artifact_registry_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleArtifactRegistryRepository : TerraformResource
{
    public GoogleArtifactRegistryRepository(string name) : base("google_artifact_registry_repository", name)
    {
    }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [TerraformProperty("cleanup_policy_dry_run")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CleanupPolicyDryRun { get; set; }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

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
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformProperty("repository_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// Block for cleanup_policies.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cleanup_policies")]
    public partial TerraformSet<TerraformBlock<GoogleArtifactRegistryRepositoryCleanupPoliciesBlock>>? CleanupPolicies { get; set; }

    /// <summary>
    /// Block for docker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerConfig block(s) allowed")]
    [TerraformProperty("docker_config")]
    public partial TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryDockerConfigBlock>>? DockerConfig { get; set; }

    /// <summary>
    /// Block for maven_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MavenConfig block(s) allowed")]
    [TerraformProperty("maven_config")]
    public partial TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryMavenConfigBlock>>? MavenConfig { get; set; }

    /// <summary>
    /// Block for remote_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteRepositoryConfig block(s) allowed")]
    [TerraformProperty("remote_repository_config")]
    public partial TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock>>? RemoteRepositoryConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleArtifactRegistryRepositoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualRepositoryConfig block(s) allowed")]
    [TerraformProperty("virtual_repository_config")]
    public partial TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock>>? VirtualRepositoryConfig { get; set; }

    /// <summary>
    /// Block for vulnerability_scanning_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VulnerabilityScanningConfig block(s) allowed")]
    [TerraformProperty("vulnerability_scanning_config")]
    public partial TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock>>? VulnerabilityScanningConfig { get; set; }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    [TerraformProperty("registry_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistryUri { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
