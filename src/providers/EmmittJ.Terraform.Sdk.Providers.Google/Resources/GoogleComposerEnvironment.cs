using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComposerEnvironmentConfigBlock() : TerraformBlock("config")
{


    /// <summary>
    /// Optional. If true, builds performed during operations that install Python packages have only private connectivity to Google services. If false, the builds also have access to the internet.
    /// </summary>
    [TerraformProperty("enable_private_builds_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnablePrivateBuildsOnly { get; set; }

    /// <summary>
    /// Optional. If true, a private Composer environment will be created.
    /// </summary>
    [TerraformProperty("enable_private_environment")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnablePrivateEnvironment { get; set; }

    /// <summary>
    /// The size of the Cloud Composer environment. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    [TerraformProperty("environment_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EnvironmentSize { get; set; }


    /// <summary>
    /// The number of nodes in the Kubernetes Engine cluster that will be used to run this environment. This field is supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// Whether high resilience is enabled or not. This field is supported for Cloud Composer environments in versions composer-2.1.15-airflow-*.*.* and newer.
    /// </summary>
    [TerraformProperty("resilience_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResilienceMode { get; set; }

}

/// <summary>
/// Block type for storage_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComposerEnvironmentStorageConfigBlock() : TerraformBlock("storage_config")
{
    /// <summary>
    /// Optional. Name of an existing Cloud Storage bucket to be used by the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComposerEnvironmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_composer_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComposerEnvironment : TerraformResource
{
    public GoogleComposerEnvironment(string name) : base("google_composer_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &amp;lt;= 128 bytes in size.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The location or Compute Engine region for the environment.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformProperty("config")]
    public TerraformList<GoogleComposerEnvironmentConfigBlock> Config { get; set; } = new();

    /// <summary>
    /// Block for storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    [TerraformProperty("storage_config")]
    public TerraformList<GoogleComposerEnvironmentStorageConfigBlock> StorageConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComposerEnvironmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
