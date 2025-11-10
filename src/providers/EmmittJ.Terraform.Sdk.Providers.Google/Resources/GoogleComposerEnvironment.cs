using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// The URI of the Apache Airflow Web UI hosted within this environment.
    /// </summary>
    public TerraformProperty<string>? AirflowUri
    {
        get => GetProperty<TerraformProperty<string>>("airflow_uri");
        set => WithProperty("airflow_uri", value);
    }

    /// <summary>
    /// The Cloud Storage prefix of the DAGs for this environment. Although Cloud Storage objects reside in a flat namespace, a hierarchical file tree can be simulated using &#39;/&#39;-delimited object name prefixes. DAG objects for this environment reside in a simulated directory with this prefix.
    /// </summary>
    public TerraformProperty<string>? DagGcsPrefix
    {
        get => GetProperty<TerraformProperty<string>>("dag_gcs_prefix");
        set => WithProperty("dag_gcs_prefix", value);
    }

    /// <summary>
    /// Optional. If true, builds performed during operations that install Python packages have only private connectivity to Google services. If false, the builds also have access to the internet.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateBuildsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("enable_private_builds_only");
        set => WithProperty("enable_private_builds_only", value);
    }

    /// <summary>
    /// Optional. If true, a private Composer environment will be created.
    /// </summary>
    public TerraformProperty<bool>? EnablePrivateEnvironment
    {
        get => GetProperty<TerraformProperty<bool>>("enable_private_environment");
        set => WithProperty("enable_private_environment", value);
    }

    /// <summary>
    /// The size of the Cloud Composer environment. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    public TerraformProperty<string>? EnvironmentSize
    {
        get => GetProperty<TerraformProperty<string>>("environment_size");
        set => WithProperty("environment_size", value);
    }

    /// <summary>
    /// The Kubernetes Engine cluster used to run this environment.
    /// </summary>
    public TerraformProperty<string>? GkeCluster
    {
        get => GetProperty<TerraformProperty<string>>("gke_cluster");
        set => WithProperty("gke_cluster", value);
    }

    /// <summary>
    /// The number of nodes in the Kubernetes Engine cluster that will be used to run this environment. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// Whether high resilience is enabled or not. This field is supported for Cloud Composer environments in versions composer-2.1.15-airflow-*.*.* and newer.
    /// </summary>
    public TerraformProperty<string>? ResilienceMode
    {
        get => GetProperty<TerraformProperty<string>>("resilience_mode");
        set => WithProperty("resilience_mode", value);
    }

}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Name of an existing Cloud Storage bucket to be used by the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComposerEnvironmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_composer_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComposerEnvironment : TerraformResource
{
    public GoogleComposerEnvironment(string name) : base("google_composer_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
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
    /// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &amp;lt;= 128 bytes in size.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Name of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The location or Compute Engine region for the environment.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GoogleComposerEnvironmentConfigBlock>? Config
    {
        get => GetProperty<List<GoogleComposerEnvironmentConfigBlock>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public List<GoogleComposerEnvironmentStorageConfigBlock>? StorageConfig
    {
        get => GetProperty<List<GoogleComposerEnvironmentStorageConfigBlock>>("storage_config");
        set => this.WithProperty("storage_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComposerEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComposerEnvironmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
