using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling in GoogleContainerAzureNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling";

    /// <summary>
    /// Maximum number of nodes in the node pool. Must be &amp;gt;= min_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// Minimum number of nodes in the node pool. Must be &amp;gt;= 1 and &amp;lt;= max_node_count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformValue<double> MinNodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for config in GoogleContainerAzureNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// Optional. The initial labels assigned to nodes of this node pool. An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Optional. A set of tags to apply to all underlying Azure resources for this node pool. This currently only includes Virtual Machine Scale Sets. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Optional. The Azure VM size name. Example: `Standard_DS2_v2`. See (/anthos/clusters/docs/azure/reference/supported-vms) for options. When unspecified, it defaults to `Standard_DS2_v2`.
    /// </summary>
    public TerraformValue<string> VmSize
    {
        get => GetArgument<TerraformValue<string>>("vm_size") ?? AsReference("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// ProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    public TerraformList<GoogleContainerAzureNodePoolConfigBlockProxyConfigBlock>? ProxyConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAzureNodePoolConfigBlockProxyConfigBlock>>("proxy_config");
        set => SetArgument("proxy_config", value);
    }

    /// <summary>
    /// RootVolume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolume block(s) allowed")]
    public TerraformList<GoogleContainerAzureNodePoolConfigBlockRootVolumeBlock>? RootVolume
    {
        get => GetArgument<TerraformList<GoogleContainerAzureNodePoolConfigBlockRootVolumeBlock>>("root_volume");
        set => SetArgument("root_volume", value);
    }

    /// <summary>
    /// SshConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SshConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshConfig block(s) allowed")]
    public required TerraformList<GoogleContainerAzureNodePoolConfigBlockSshConfigBlock> SshConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureNodePoolConfigBlockSshConfigBlock>>("ssh_config");
        set => SetArgument("ssh_config", value);
    }

}

/// <summary>
/// Block type for proxy_config in GoogleContainerAzureNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolConfigBlockProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_config";

    /// <summary>
    /// The ARM ID the of the resource group containing proxy keyvault. Resource group ids are formatted as `/subscriptions/&amp;lt;subscription-id&amp;gt;/resourceGroups/&amp;lt;resource-group-name&amp;gt;`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The URL the of the proxy setting secret with its version. Secret ids are formatted as `https:&amp;lt;key-vault-name&amp;gt;.vault.azure.net/secrets/&amp;lt;secret-name&amp;gt;/&amp;lt;secret-version&amp;gt;`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

}

/// <summary>
/// Block type for root_volume in GoogleContainerAzureNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolConfigBlockRootVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_volume";

    /// <summary>
    /// Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.
    /// </summary>
    public TerraformValue<double> SizeGib
    {
        get => GetArgument<TerraformValue<double>>("size_gib") ?? AsReference("size_gib");
        set => SetArgument("size_gib", value);
    }

}

/// <summary>
/// Block type for ssh_config in GoogleContainerAzureNodePoolConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolConfigBlockSshConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_config";

    /// <summary>
    /// The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizedKey is required")]
    public required TerraformValue<string> AuthorizedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("authorized_key");
        set => SetArgument("authorized_key", value);
    }

}


/// <summary>
/// Block type for management in GoogleContainerAzureNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolManagementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management";

    /// <summary>
    /// Optional. Whether or not the nodes will be automatically repaired.
    /// </summary>
    public TerraformValue<bool> AutoRepair
    {
        get => GetArgument<TerraformValue<bool>>("auto_repair") ?? AsReference("auto_repair");
        set => SetArgument("auto_repair", value);
    }

}


/// <summary>
/// Block type for max_pods_constraint in GoogleContainerAzureNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureNodePoolMaxPodsConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_pods_constraint";

    /// <summary>
    /// The maximum number of pods to schedule on a single node.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsPerNode is required")]
    public required TerraformValue<double> MaxPodsPerNode
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_pods_per_node");
        set => SetArgument("max_pods_per_node", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAzureNodePool.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAzureNodePoolTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_container_azure_node_pool Terraform resource.
/// Manages a google_container_azure_node_pool resource.
/// </summary>
public partial class GoogleContainerAzureNodePool(string name) : TerraformResource("google_container_azure_node_pool", name)
{
    /// <summary>
    /// Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Optional. The Azure availability zone of the nodes in this nodepool. When unspecified, it defaults to `1`.
    /// </summary>
    public TerraformValue<string> AzureAvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("azure_availability_zone") ?? AsReference("azure_availability_zone");
        set => SetArgument("azure_availability_zone", value);
    }

    /// <summary>
    /// The azureCluster for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ARM ID of the subnet where the node pool VMs run. Make sure it&#39;s a subnet under the virtual network in the cluster configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The Kubernetes version (e.g. `1.19.10-gke.1000`) running on this node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Output only. The time at which this node pool was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output only. If set, there are currently pending changes to the node pool.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Output only. The current state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. A globally unique identifier for the node pool.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. The time at which this node pool was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Autoscaling block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autoscaling is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Autoscaling block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public required TerraformList<GoogleContainerAzureNodePoolAutoscalingBlock> Autoscaling
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureNodePoolAutoscalingBlock>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleContainerAzureNodePoolConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureNodePoolConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Management block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Management block(s) allowed")]
    public TerraformList<GoogleContainerAzureNodePoolManagementBlock>? Management
    {
        get => GetArgument<TerraformList<GoogleContainerAzureNodePoolManagementBlock>>("management");
        set => SetArgument("management", value);
    }

    /// <summary>
    /// MaxPodsConstraint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPodsConstraint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaxPodsConstraint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxPodsConstraint block(s) allowed")]
    public required TerraformList<GoogleContainerAzureNodePoolMaxPodsConstraintBlock> MaxPodsConstraint
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureNodePoolMaxPodsConstraintBlock>>("max_pods_constraint");
        set => SetArgument("max_pods_constraint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAzureNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAzureNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
