using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_repository Terraform data source.
/// Retrieves information about a google_artifact_registry_repository.
/// </summary>
public partial class GoogleArtifactRegistryRepositoryDataSource(string name) : TerraformDataSource("google_artifact_registry_repository", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => new TerraformReference<string>(this, "repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CleanupPolicies
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "cleanup_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    public TerraformValue<bool> CleanupPolicyDryRun
    {
        get => new TerraformReference<bool>(this, "cleanup_policy_dry_run");
    }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// </summary>
    public TerraformList<TerraformMap<object>> DockerConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "docker_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    public TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
    }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
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
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// </summary>
    public TerraformList<TerraformMap<object>> MavenConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maven_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// The name of the repository, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The repository endpoint, for example: us-docker.pkg.dev/my-proj/my-repo.
    /// </summary>
    public TerraformValue<string> RegistryUri
    {
        get => new TerraformReference<string>(this, "registry_uri");
    }

    /// <summary>
    /// Configuration specific for a Remote Repository.
    /// </summary>
    public TerraformList<TerraformMap<object>> RemoteRepositoryConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "remote_repository_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// </summary>
    public TerraformList<TerraformMap<object>> VirtualRepositoryConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "virtual_repository_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// </summary>
    public TerraformList<TerraformMap<object>> VulnerabilityScanningConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vulnerability_scanning_config").ResolveNodes(ctx));
    }

}
