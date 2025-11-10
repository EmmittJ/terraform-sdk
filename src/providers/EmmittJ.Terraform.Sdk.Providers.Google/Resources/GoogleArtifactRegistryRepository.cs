using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cleanup_policies in .
/// Nesting mode: set
/// </summary>
public class GoogleArtifactRegistryRepositoryCleanupPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Policy action. Possible values: [&amp;quot;DELETE&amp;quot;, &amp;quot;KEEP&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

}

/// <summary>
/// Block type for docker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryDockerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.
    /// </summary>
    public TerraformProperty<bool>? ImmutableTags
    {
        set => SetProperty("immutable_tags", value);
    }

}

/// <summary>
/// Block type for maven_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryMavenConfigBlock : TerraformBlock
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    public TerraformProperty<bool>? AllowSnapshotOverwrites
    {
        set => SetProperty("allow_snapshot_overwrites", value);
    }

    /// <summary>
    /// Version policy defines the versions that the registry will accept. Default value: &amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;VERSION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RELEASE&amp;quot;, &amp;quot;SNAPSHOT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? VersionPolicy
    {
        set => SetProperty("version_policy", value);
    }

}

/// <summary>
/// Block type for remote_repository_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock : TerraformBlock
{
    /// <summary>
    /// The description of the remote source.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    public TerraformProperty<bool>? DisableUpstreamValidation
    {
        set => SetProperty("disable_upstream_validation", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleArtifactRegistryRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for virtual_repository_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for vulnerability_scanning_config in .
/// Nesting mode: list
/// </summary>
public class GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock : TerraformBlock
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository. Possible values: [&amp;quot;INHERITED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EnablementConfig
    {
        set => SetProperty("enablement_config", value);
    }

    /// <summary>
    /// This field returns whether scanning is active for this repository.
    /// </summary>
    public TerraformProperty<string>? EnablementState
    {
        set => SetProperty("enablement_state", value);
    }

    /// <summary>
    /// This provides an explanation for the state of scanning on this repository.
    /// </summary>
    public TerraformProperty<string>? EnablementStateReason
    {
        set => SetProperty("enablement_state_reason", value);
    }

}

/// <summary>
/// Manages a google_artifact_registry_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleArtifactRegistryRepository : TerraformResource
{
    public GoogleArtifactRegistryRepository(string name) : base("google_artifact_registry_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("registry_uri");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("cleanup_policy_dry_run");
        SetOutput("description");
        SetOutput("format");
        SetOutput("id");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("mode");
        SetOutput("project");
        SetOutput("repository_id");
    }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    public TerraformProperty<bool> CleanupPolicyDryRun
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cleanup_policy_dry_run");
        set => SetProperty("cleanup_policy_dry_run", value);
    }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetRequiredOutput<TerraformProperty<string>>("format");
        set => SetProperty("format", value);
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
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

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
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_id");
        set => SetProperty("repository_id", value);
    }

    /// <summary>
    /// Block for cleanup_policies.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleArtifactRegistryRepositoryCleanupPoliciesBlock>? CleanupPolicies
    {
        set => SetProperty("cleanup_policies", value);
    }

    /// <summary>
    /// Block for docker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerConfig block(s) allowed")]
    public List<GoogleArtifactRegistryRepositoryDockerConfigBlock>? DockerConfig
    {
        set => SetProperty("docker_config", value);
    }

    /// <summary>
    /// Block for maven_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MavenConfig block(s) allowed")]
    public List<GoogleArtifactRegistryRepositoryMavenConfigBlock>? MavenConfig
    {
        set => SetProperty("maven_config", value);
    }

    /// <summary>
    /// Block for remote_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteRepositoryConfig block(s) allowed")]
    public List<GoogleArtifactRegistryRepositoryRemoteRepositoryConfigBlock>? RemoteRepositoryConfig
    {
        set => SetProperty("remote_repository_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleArtifactRegistryRepositoryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_repository_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualRepositoryConfig block(s) allowed")]
    public List<GoogleArtifactRegistryRepositoryVirtualRepositoryConfigBlock>? VirtualRepositoryConfig
    {
        set => SetProperty("virtual_repository_config", value);
    }

    /// <summary>
    /// Block for vulnerability_scanning_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VulnerabilityScanningConfig block(s) allowed")]
    public List<GoogleArtifactRegistryRepositoryVulnerabilityScanningConfigBlock>? VulnerabilityScanningConfig
    {
        set => SetProperty("vulnerability_scanning_config", value);
    }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    public TerraformExpression RegistryUri => this["registry_uri"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
