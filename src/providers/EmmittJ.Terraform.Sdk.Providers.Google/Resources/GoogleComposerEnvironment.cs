using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The URI of the Apache Airflow Web UI hosted within this environment.
    /// </summary>
    [TerraformPropertyName("airflow_uri")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AirflowUri => new TerraformReferenceProperty<TerraformProperty<string>>("", "airflow_uri");

    /// <summary>
    /// The Cloud Storage prefix of the DAGs for this environment. Although Cloud Storage objects reside in a flat namespace, a hierarchical file tree can be simulated using &#39;/&#39;-delimited object name prefixes. DAG objects for this environment reside in a simulated directory with this prefix.
    /// </summary>
    [TerraformPropertyName("dag_gcs_prefix")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DagGcsPrefix => new TerraformReferenceProperty<TerraformProperty<string>>("", "dag_gcs_prefix");

    /// <summary>
    /// Optional. If true, builds performed during operations that install Python packages have only private connectivity to Google services. If false, the builds also have access to the internet.
    /// </summary>
    [TerraformPropertyName("enable_private_builds_only")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnablePrivateBuildsOnly { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable_private_builds_only");

    /// <summary>
    /// Optional. If true, a private Composer environment will be created.
    /// </summary>
    [TerraformPropertyName("enable_private_environment")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnablePrivateEnvironment { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable_private_environment");

    /// <summary>
    /// The size of the Cloud Composer environment. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    [TerraformPropertyName("environment_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EnvironmentSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "environment_size");

    /// <summary>
    /// The Kubernetes Engine cluster used to run this environment.
    /// </summary>
    [TerraformPropertyName("gke_cluster")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GkeCluster => new TerraformReferenceProperty<TerraformProperty<string>>("", "gke_cluster");

    /// <summary>
    /// The number of nodes in the Kubernetes Engine cluster that will be used to run this environment. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "node_count");

    /// <summary>
    /// Whether high resilience is enabled or not. This field is supported for Cloud Composer environments in versions composer-2.1.15-airflow-*.*.* and newer.
    /// </summary>
    [TerraformPropertyName("resilience_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResilienceMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "resilience_mode");

}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComposerEnvironmentStorageConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Name of an existing Cloud Storage bucket to be used by the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComposerEnvironmentTimeoutsBlock : ITerraformBlock
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
/// Manages a google_composer_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComposerEnvironment : TerraformResource
{
    public GoogleComposerEnvironment(string name) : base("google_composer_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &amp;lt;= 128 bytes in size.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Name of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The location or Compute Engine region for the environment.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GoogleComposerEnvironmentConfigBlock>>? Config { get; set; } = new();

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    [TerraformPropertyName("storage_config")]
    public TerraformList<TerraformBlock<GoogleComposerEnvironmentStorageConfigBlock>>? StorageConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComposerEnvironmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
