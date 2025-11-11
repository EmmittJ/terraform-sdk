using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_repository.
/// </summary>
public partial class GoogleArtifactRegistryRepositoryDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryRepositoryDataSource(string name) : base("google_artifact_registry_repository", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformProperty("repository_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// </summary>
    [TerraformProperty("cleanup_policies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> CleanupPolicies { get; }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [TerraformProperty("cleanup_policy_dry_run")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> CleanupPolicyDryRun { get; }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// </summary>
    [TerraformProperty("docker_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DockerConfig { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [TerraformProperty("format")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Format { get; }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyName { get; }

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
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// </summary>
    [TerraformProperty("maven_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MavenConfig { get; }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Mode { get; }

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    [TerraformProperty("registry_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegistryUri { get; }

    /// <summary>
    /// Configuration specific for a Remote Repository.
    /// </summary>
    [TerraformProperty("remote_repository_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RemoteRepositoryConfig { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// </summary>
    [TerraformProperty("virtual_repository_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VirtualRepositoryConfig { get; }

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// </summary>
    [TerraformProperty("vulnerability_scanning_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VulnerabilityScanningConfig { get; }

}
