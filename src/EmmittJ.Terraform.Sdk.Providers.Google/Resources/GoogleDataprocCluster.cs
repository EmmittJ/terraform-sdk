using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterClusterConfigBlock : TerraformBlock
{
    /// <summary>
    ///  The name of the cloud storage bucket ultimately used to house the staging data for the cluster. If staging_bucket is specified, it will contain this value, otherwise it will be the auto generated name.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// Specifies the tier of the cluster created.
    /// </summary>
    public TerraformProperty<string>? ClusterTier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_tier");
        set => WithProperty("cluster_tier", value);
    }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files, such as Hadoop jars, between client machines and the cluster. Note: If you don&#39;t explicitly specify a staging_bucket then GCP will auto create / assign one for you. However, you are not guaranteed an auto generated bucket which is solely dedicated to your cluster; it may be shared with other clusters in the same region/zone also choosing to use the auto generation option.
    /// </summary>
    public TerraformProperty<string>? StagingBucket
    {
        get => GetProperty<TerraformProperty<string>>("staging_bucket");
        set => WithProperty("staging_bucket", value);
    }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. Note: If you don&#39;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    public TerraformProperty<string>? TempBucket
    {
        get => GetProperty<TerraformProperty<string>>("temp_bucket");
        set => WithProperty("temp_bucket", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocClusterTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocClusterVirtualClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&#39;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket.
    /// </summary>
    public TerraformProperty<string>? StagingBucket
    {
        get => GetProperty<TerraformProperty<string>>("staging_bucket");
        set => WithProperty("staging_bucket", value);
    }

}

/// <summary>
/// Manages a google_dataproc_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocCluster : TerraformResource
{
    public GoogleDataprocCluster(string name) : base("google_dataproc_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The timeout duration which allows graceful decomissioning when you change the number of worker nodes directly through a terraform apply
    /// </summary>
    public TerraformProperty<string>? GracefulDecommissionTimeout
    {
        get => GetProperty<TerraformProperty<string>>("graceful_decommission_timeout");
        set => this.WithProperty("graceful_decommission_timeout", value);
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
    /// The list of the labels (key/value pairs) configured on the resource and to be applied to instances in the cluster.
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
    /// The name of the cluster, unique within the project and zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in. Defaults to global.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    public List<GoogleDataprocClusterClusterConfigBlock>? ClusterConfig
    {
        get => GetProperty<List<GoogleDataprocClusterClusterConfigBlock>>("cluster_config");
        set => this.WithProperty("cluster_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualClusterConfig block(s) allowed")]
    public List<GoogleDataprocClusterVirtualClusterConfigBlock>? VirtualClusterConfig
    {
        get => GetProperty<List<GoogleDataprocClusterVirtualClusterConfigBlock>>("virtual_cluster_config");
        set => this.WithProperty("virtual_cluster_config", value);
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
