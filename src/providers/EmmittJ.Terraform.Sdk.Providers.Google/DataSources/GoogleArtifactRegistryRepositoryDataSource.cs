using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_repository.
/// </summary>
public class GoogleArtifactRegistryRepositoryDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryRepositoryDataSource(string name) : base("google_artifact_registry_repository", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// </summary>
    [TerraformPropertyName("cleanup_policies")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> CleanupPolicies => new TerraformReference(this, "cleanup_policies");

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [TerraformPropertyName("cleanup_policy_dry_run")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CleanupPolicyDryRun => new TerraformReference(this, "cleanup_policy_dry_run");

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// </summary>
    [TerraformPropertyName("docker_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DockerConfig => new TerraformReference(this, "docker_config");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [TerraformPropertyName("format")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Format => new TerraformReference(this, "format");

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyName => new TerraformReference(this, "kms_key_name");

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
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// </summary>
    [TerraformPropertyName("maven_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MavenConfig => new TerraformReference(this, "maven_config");

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mode => new TerraformReference(this, "mode");

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
    /// Configuration specific for a Remote Repository.
    /// </summary>
    [TerraformPropertyName("remote_repository_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RemoteRepositoryConfig => new TerraformReference(this, "remote_repository_config");

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

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// </summary>
    [TerraformPropertyName("virtual_repository_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VirtualRepositoryConfig => new TerraformReference(this, "virtual_repository_config");

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// </summary>
    [TerraformPropertyName("vulnerability_scanning_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VulnerabilityScanningConfig => new TerraformReference(this, "vulnerability_scanning_config");

}
