using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_instance.
/// </summary>
public class GoogleAlloydbInstanceDataSource : TerraformDataSource
{
    public GoogleAlloydbInstanceDataSource(string name) : base("google_alloydb_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("activation_policy");
        this.DeclareOutput("annotations");
        this.DeclareOutput("availability_type");
        this.DeclareOutput("client_connection_config");
        this.DeclareOutput("cluster");
        this.DeclareOutput("create_time");
        this.DeclareOutput("database_flags");
        this.DeclareOutput("display_name");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("gce_zone");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("labels");
        this.DeclareOutput("machine_config");
        this.DeclareOutput("name");
        this.DeclareOutput("network_config");
        this.DeclareOutput("outbound_public_ip_addresses");
        this.DeclareOutput("psc_instance_config");
        this.DeclareOutput("public_ip_address");
        this.DeclareOutput("query_insights_config");
        this.DeclareOutput("read_pool_config");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID of the alloydb cluster that the instance belongs to.&#39;alloydb_cluster_id&#39;
    /// </summary>
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// The ID of the alloydb instance.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The canonical ID for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// &#39;Specifies whether an instance needs to spin up. Once the instance is
    /// active, the activation policy can be updated to the &#39;NEVER&#39; to stop the
    /// instance. Likewise, the activation policy can be updated to &#39;ALWAYS&#39; to
    /// start the instance.
    /// There are restrictions around when an instance can/cannot be activated (for
    /// example, a read pool instance should be stopped before stopping primary
    /// etc.). Please refer to the API documentation for more details.
    /// Possible values are: &#39;ACTIVATION_POLICY_UNSPECIFIED&#39;, &#39;ALWAYS&#39;, &#39;NEVER&#39;.&#39; Possible values: [&amp;quot;ACTIVATION_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;ALWAYS&amp;quot;, &amp;quot;NEVER&amp;quot;]
    /// </summary>
    public TerraformExpression ActivationPolicy => this["activation_policy"];

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformExpression Annotations => this["annotations"];

    /// <summary>
    /// &#39;Availability type of an Instance. Defaults to REGIONAL for both primary and read instances.
    /// Note that primary and read instances can have different availability types.
    /// Primary instances can be either ZONAL or REGIONAL. Read Pool instances can also be either ZONAL or REGIONAL.
    /// Read pools of size 1 can only have zonal availability. Read pools with a node count of 2 or more
    /// can have regional availability (nodes are present in 2 or more zones in a region).
    /// Possible values are: &#39;AVAILABILITY_TYPE_UNSPECIFIED&#39;, &#39;ZONAL&#39;, &#39;REGIONAL&#39;.&#39; Possible values: [&amp;quot;AVAILABILITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ZONAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public TerraformExpression AvailabilityType => this["availability_type"];

    /// <summary>
    /// Client connection specific configurations.
    /// </summary>
    public TerraformExpression ClientConnectionConfig => this["client_connection_config"];

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    public TerraformExpression Cluster => this["cluster"];

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Database flags. Set at instance level. * They are copied from primary instance on read instance creation. * Read instances can set new or override existing flags that are relevant for reads, e.g. for enabling columnar cache on a read instance. Flags set on read instance may or may not be present on primary.
    /// </summary>
    public TerraformExpression DatabaseFlags => this["database_flags"];

    /// <summary>
    /// User-settable and human-readable display name for the Instance.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The Compute Engine zone that the instance should serve from, per https://cloud.google.com/compute/docs/regions-zones This can ONLY be specified for ZONAL instances. If present for a REGIONAL instance, an error will be thrown. If this is absent for a ZONAL instance, instance is created in a random zone with available capacity.
    /// </summary>
    public TerraformExpression GceZone => this["gce_zone"];

    /// <summary>
    /// The type of the instance.
    /// If the instance type is READ_POOL, provide the associated PRIMARY/SECONDARY instance in the &#39;depends_on&#39; meta-data attribute.
    /// If the instance type is SECONDARY, point to the cluster_type of the associated secondary cluster instead of mentioning SECONDARY.
    /// Example: {instance_type = google_alloydb_cluster.&amp;lt;secondary_cluster_name&amp;gt;.cluster_type} instead of {instance_type = SECONDARY}
    /// If the instance type is SECONDARY, the terraform delete instance operation does not delete the secondary instance but abandons it instead.
    /// Use deletion_policy = &amp;quot;FORCE&amp;quot; in the associated secondary cluster and delete the cluster forcefully to delete the secondary cluster as well its associated secondary instance.
    /// Users can undo the delete secondary instance action by importing the deleted secondary instance by calling terraform import. Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;READ_POOL&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The IP address for the Instance. This is the connection endpoint for an end-user application.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// User-defined labels for the alloydb instance.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Configurations for the machines that host the underlying database engine.
    /// </summary>
    public TerraformExpression MachineConfig => this["machine_config"];

    /// <summary>
    /// The name of the instance resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Instance level network configuration.
    /// </summary>
    public TerraformExpression NetworkConfig => this["network_config"];

    /// <summary>
    /// The outbound public IP addresses for the instance. This is available ONLY when
    /// networkConfig.enableOutboundPublicIp is set to true. These IP addresses are used
    /// for outbound connections.
    /// </summary>
    public TerraformExpression OutboundPublicIpAddresses => this["outbound_public_ip_addresses"];

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the instance.
    /// </summary>
    public TerraformExpression PscInstanceConfig => this["psc_instance_config"];

    /// <summary>
    /// The public IP addresses for the Instance. This is available ONLY when
    /// networkConfig.enablePublicIp is set to true. This is the connection
    /// endpoint for an end-user application.
    /// </summary>
    public TerraformExpression PublicIpAddress => this["public_ip_address"];

    /// <summary>
    /// Configuration for query insights.
    /// </summary>
    public TerraformExpression QueryInsightsConfig => this["query_insights_config"];

    /// <summary>
    /// Read pool specific config. If the instance type is READ_POOL, this configuration must be provided.
    /// </summary>
    public TerraformExpression ReadPoolConfig => this["read_pool_config"];

    /// <summary>
    /// Set to true if the current state of Instance does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them. This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of the alloydb instance.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
