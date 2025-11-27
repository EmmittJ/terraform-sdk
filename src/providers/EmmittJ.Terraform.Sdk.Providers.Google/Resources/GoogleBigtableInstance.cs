using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster in GoogleBigtableInstance.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableInstanceClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster";

    /// <summary>
    /// The ID of the Cloud Bigtable cluster. Must be 6-30 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The node scaling factor of this cluster. One of &amp;quot;NodeScalingFactor1X&amp;quot; or &amp;quot;NodeScalingFactor2X&amp;quot;. Defaults to &amp;quot;NodeScalingFactor1X&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NodeScalingFactor
    {
        get => new TerraformReference<string>(this, "node_scaling_factor");
        set => SetArgument("node_scaling_factor", value);
    }

    /// <summary>
    /// The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based on your data footprint and optimized for 50% storage utilization.
    /// </summary>
    public TerraformValue<double> NumNodes
    {
        get => new TerraformReference<double>(this, "num_nodes");
        set => SetArgument("num_nodes", value);
    }

    /// <summary>
    /// The state of the cluster
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The storage type to use. One of &amp;quot;SSD&amp;quot; or &amp;quot;HDD&amp;quot;. Defaults to &amp;quot;SSD&amp;quot;.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The zone to create the Cloud Bigtable cluster in. Each cluster must have a different zone in the same region. Zones that support Bigtable instances are noted on the Cloud Bigtable locations page.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// AutoscalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    public TerraformList<GoogleBigtableInstanceClusterBlockAutoscalingConfigBlock>? AutoscalingConfig
    {
        get => GetArgument<TerraformList<GoogleBigtableInstanceClusterBlockAutoscalingConfigBlock>>("autoscaling_config");
        set => SetArgument("autoscaling_config", value);
    }

}

/// <summary>
/// Block type for autoscaling_config in GoogleBigtableInstanceClusterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableInstanceClusterBlockAutoscalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_config";

    /// <summary>
    /// The target CPU utilization for autoscaling. Value must be between 10 and 80.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuTarget is required")]
    public required TerraformValue<double> CpuTarget
    {
        get => new TerraformReference<double>(this, "cpu_target");
        set => SetArgument("cpu_target", value);
    }

    /// <summary>
    /// The maximum number of nodes for autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodes is required")]
    public required TerraformValue<double> MaxNodes
    {
        get => new TerraformReference<double>(this, "max_nodes");
        set => SetArgument("max_nodes", value);
    }

    /// <summary>
    /// The minimum number of nodes for autoscaling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodes is required")]
    public required TerraformValue<double> MinNodes
    {
        get => new TerraformReference<double>(this, "min_nodes");
        set => SetArgument("min_nodes", value);
    }

    /// <summary>
    /// The target storage utilization for autoscaling, in GB, for each node in a cluster. This number is limited between 2560 (2.5TiB) and 5120 (5TiB) for a SSD cluster and between 8192 (8TiB) and 16384 (16 TiB) for an HDD cluster. If not set, whatever is already set for the cluster will not change, or if the cluster is just being created, it will use the default value of 2560 for SSD clusters and 8192 for HDD clusters.
    /// </summary>
    public TerraformValue<double> StorageTarget
    {
        get => new TerraformReference<double>(this, "storage_target");
        set => SetArgument("storage_target", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigtableInstance.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigtable_instance Terraform resource.
/// Manages a google_bigtable_instance resource.
/// </summary>
public partial class GoogleBigtableInstance(string name) : TerraformResource("google_bigtable_instance", name)
{
    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The human-readable display name of the Bigtable instance. Defaults to the instance name.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// When deleting a BigTable instance, this boolean option will delete all backups within the instance.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance type to create. One of &amp;quot;DEVELOPMENT&amp;quot; or &amp;quot;PRODUCTION&amp;quot;. Defaults to &amp;quot;PRODUCTION&amp;quot;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 				
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance. Must be 6-33 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cluster block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigtableInstanceClusterBlock>? Cluster
    {
        get => GetArgument<TerraformList<GoogleBigtableInstanceClusterBlock>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
