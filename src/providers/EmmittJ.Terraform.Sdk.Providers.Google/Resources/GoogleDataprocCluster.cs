using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlock : ITerraformBlock
{
    /// <summary>
    ///  The name of the cloud storage bucket ultimately used to house the staging data for the cluster. If staging_bucket is specified, it will contain this value, otherwise it will be the auto generated name.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Bucket => new TerraformReferenceProperty<TerraformProperty<string>>("", "bucket");

    /// <summary>
    /// Specifies the tier of the cluster created.
    /// </summary>
    [TerraformPropertyName("cluster_tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterTier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_tier");

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don&#39;t explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.
    /// </summary>
    [TerraformPropertyName("staging_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StagingBucket { get; set; }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don&#39;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    [TerraformPropertyName("temp_bucket")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TempBucket { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "temp_bucket");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocClusterTimeoutsBlock : ITerraformBlock
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
/// Block type for virtual_cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&#39;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket.
    /// </summary>
    [TerraformPropertyName("staging_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StagingBucket { get; set; }

}

/// <summary>
/// Manages a google_dataproc_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocCluster : TerraformResource
{
    public GoogleDataprocCluster(string name) : base("google_dataproc_cluster", name)
    {
    }

    /// <summary>
    /// The timeout duration which allows graceful decomissioning when you change the number of worker nodes directly through a terraform apply
    /// </summary>
    [TerraformPropertyName("graceful_decommission_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GracefulDecommissionTimeout { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The list of the labels (key/value pairs) configured on the resource and to be applied to instances in the cluster.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in. Defaults to global.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    [TerraformPropertyName("cluster_config")]
    public TerraformList<TerraformBlock<GoogleDataprocClusterClusterConfigBlock>>? ClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualClusterConfig block(s) allowed")]
    [TerraformPropertyName("virtual_cluster_config")]
    public TerraformList<TerraformBlock<GoogleDataprocClusterVirtualClusterConfigBlock>>? VirtualClusterConfig { get; set; } = new();

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
