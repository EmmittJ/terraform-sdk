using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cleanup_policies in .
/// Nesting mode: set
/// </summary>
public class GoogleArtifactRegistryRepositoryCleanupPoliciesBlock : ITerraformBlock
{
    /// <summary>
    /// Policy action. Possible values: [&amp;quot;DELETE&amp;quot;, &amp;quot;KEEP&amp;quot;]
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Action { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

}

/// <summary>
/// Block type for docker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryDockerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.
    /// </summary>
    [TerraformPropertyName("immutable_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ImmutableTags { get; set; }

}

/// <summary>
/// Block type for maven_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryMavenConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    [TerraformPropertyName("allow_snapshot_overwrites")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowSnapshotOverwrites { get; set; }

    /// <summary>
    /// Version policy defines the versions that the registry will accept. Default value: &amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RELEASE&amp;quot;, &amp;quot;SNAPSHOT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("version_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionPolicy { get; set; }

}

/// <summary>
/// Block type for remote_repository_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The description of the remote source.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    [TerraformPropertyName("disable_upstream_validation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableUpstreamValidation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleArtifactRegistryRepositoryTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_repository_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for vulnerability_scanning_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock : ITerraformBlock
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository. Possible values: [&amp;quot;INHERITED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("enablement_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnablementConfig { get; set; }

    /// <summary>
    /// This field returns whether scanning is active for this repository.
    /// </summary>
    [TerraformPropertyName("enablement_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnablementState => new TerraformReferenceProperty<TerraformProperty<string>>("", "enablement_state");

    /// <summary>
    /// This provides an explanation for the state of scanning on this repository.
    /// </summary>
    [TerraformPropertyName("enablement_state_reason")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnablementStateReason => new TerraformReferenceProperty<TerraformProperty<string>>("", "enablement_state_reason");

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
    public TerraformProperty<TerraformProperty<bool>>? CleanupPolicyDryRun { get; set; }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Format { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Location { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryId { get; set; }

    /// <summary>
    /// Block for cleanup_policies.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cleanup_policies")]
    public TerraformSet<TerraformBlock<GoogleArtifactRegistryRepositoryCleanupPoliciesBlock>>? CleanupPolicies { get; set; } = new();

    /// <summary>
    /// Block for docker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerConfig block(s) allowed")]
    [TerraformPropertyName("docker_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryDockerConfigBlock>>? DockerConfig { get; set; } = new();

    /// <summary>
    /// Block for maven_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MavenConfig block(s) allowed")]
    [TerraformPropertyName("maven_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryMavenConfigBlock>>? MavenConfig { get; set; } = new();

    /// <summary>
    /// Block for remote_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteRepositoryConfig block(s) allowed")]
    [TerraformPropertyName("remote_repository_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock>>? RemoteRepositoryConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleArtifactRegistryRepositoryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualRepositoryConfig block(s) allowed")]
    [TerraformPropertyName("virtual_repository_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock>>? VirtualRepositoryConfig { get; set; } = new();

    /// <summary>
    /// Block for vulnerability_scanning_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VulnerabilityScanningConfig block(s) allowed")]
    [TerraformPropertyName("vulnerability_scanning_config")]
    public TerraformList<TerraformBlock<GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock>>? VulnerabilityScanningConfig { get; set; } = new();

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    [TerraformPropertyName("registry_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistryUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registry_uri");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
