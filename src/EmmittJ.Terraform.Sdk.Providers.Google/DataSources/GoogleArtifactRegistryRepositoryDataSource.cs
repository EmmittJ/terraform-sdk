using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_artifact_registry_repository.
/// </summary>
public class GoogleArtifactRegistryRepositoryDataSource : TerraformDataSource
{
    public GoogleArtifactRegistryRepositoryDataSource(string name) : base("google_artifact_registry_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cleanup_policies");
        this.DeclareOutput("cleanup_policy_dry_run");
        this.DeclareOutput("create_time");
        this.DeclareOutput("description");
        this.DeclareOutput("docker_config");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("format");
        this.DeclareOutput("kms_key_name");
        this.DeclareOutput("labels");
        this.DeclareOutput("maven_config");
        this.DeclareOutput("mode");
        this.DeclareOutput("name");
        this.DeclareOutput("registry_uri");
        this.DeclareOutput("remote_repository_config");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
        this.DeclareOutput("virtual_repository_config");
        this.DeclareOutput("vulnerability_scanning_config");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the repository&#39;s location. In addition to specific regions,
    /// special values for multi-region locations are &#39;asia&#39;, &#39;europe&#39;, and &#39;us&#39;.
    /// See [here](https://cloud.google.com/artifact-registry/docs/repositories/repo-locations),
    /// or use the
    /// [google_artifact_registry_locations](https://registry.terraform.io/providers/hashicorp/google/latest/docs/data-sources/artifact_registry_locations)
    /// data source for possible values.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The last part of the repository name, for example:
    /// &amp;quot;repo1&amp;quot;
    /// </summary>
    public TerraformProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// </summary>
    public TerraformExpression CleanupPolicies => this["cleanup_policies"];

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    public TerraformExpression CleanupPolicyDryRun => this["cleanup_policy_dry_run"];

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The user-provided description of the repository.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// </summary>
    public TerraformExpression DockerConfig => this["docker_config"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found [here](https://cloud.google.com/artifact-registry/docs/supported-formats).
    /// You can only create alpha formats if you are a member of the
    /// [alpha user group](https://cloud.google.com/artifact-registry/docs/supported-formats#alpha-access).
    /// </summary>
    public TerraformExpression Format => this["format"];

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

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
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// </summary>
    public TerraformExpression MavenConfig => this["maven_config"];

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources. Default value: &amp;quot;STANDARD_REPOSITORY&amp;quot; Possible values: [&amp;quot;STANDARD_REPOSITORY&amp;quot;, &amp;quot;VIRTUAL_REPOSITORY&amp;quot;, &amp;quot;REMOTE_REPOSITORY&amp;quot;]
    /// </summary>
    public TerraformExpression Mode => this["mode"];

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
    /// Configuration specific for a Remote Repository.
    /// </summary>
    public TerraformExpression RemoteRepositoryConfig => this["remote_repository_config"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// </summary>
    public TerraformExpression VirtualRepositoryConfig => this["virtual_repository_config"];

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// </summary>
    public TerraformExpression VulnerabilityScanningConfig => this["vulnerability_scanning_config"];

}
