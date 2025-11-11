using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocClusterClusterConfigBlock : TerraformBlockBase
{

    /// <summary>
    /// Specifies the tier of the cluster created.
    /// </summary>
    [TerraformProperty("cluster_tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ClusterTier { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don&#39;t explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.
    /// </summary>
    [TerraformProperty("staging_bucket")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StagingBucket { get; set; }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don&#39;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    [TerraformProperty("temp_bucket")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TempBucket { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_cluster_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocClusterVirtualClusterConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&#39;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket.
    /// </summary>
    [TerraformProperty("staging_bucket")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StagingBucket { get; set; }

}

/// <summary>
/// Manages a google_dataproc_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocCluster : TerraformResource
{
    public GoogleDataprocCluster(string name) : base("google_dataproc_cluster", name)
    {
    }

    /// <summary>
    /// The timeout duration which allows graceful decomissioning when you change the number of worker nodes directly through a terraform apply
    /// </summary>
    [TerraformProperty("graceful_decommission_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GracefulDecommissionTimeout { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The list of the labels (key/value pairs) configured on the resource and to be applied to instances in the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in. Defaults to global.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    [TerraformProperty("cluster_config")]
    public TerraformList<TerraformBlock<GoogleDataprocClusterClusterConfigBlock>>? ClusterConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataprocClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualClusterConfig block(s) allowed")]
    [TerraformProperty("virtual_cluster_config")]
    public TerraformList<TerraformBlock<GoogleDataprocClusterVirtualClusterConfigBlock>>? VirtualClusterConfig { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
