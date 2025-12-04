using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for local_disk_encryption in GoogleEdgecontainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_disk_encryption";

    /// <summary>
    /// The Cloud KMS CryptoKey e.g. projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey} to use for protecting node local disks.
    /// If not specified, a Google-managed key will be used instead.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The Cloud KMS CryptoKeyVersion currently in use for protecting node local disks. Only applicable if kmsKey is set.
    /// </summary>
    public TerraformValue<string> KmsKeyActiveVersion
        => AsReference("kms_key_active_version");

    /// <summary>
    /// Availability of the Cloud KMS CryptoKey. If not KEY_AVAILABLE, then nodes may go offline as they cannot access their local data.
    /// This can be caused by a lack of permissions to use the key, or if the key is disabled or deleted.
    /// </summary>
    public TerraformValue<string> KmsKeyState
        => AsReference("kms_key_state");

}


/// <summary>
/// Block type for node_config in GoogleEdgecontainerNodePool.
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerNodePoolNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// &amp;quot;The Kubernetes node labels&amp;quot;
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleEdgecontainerNodePool.
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerNodePoolTimeoutsBlock : TerraformBlock
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
/// Represents a google_edgecontainer_node_pool Terraform resource.
/// Manages a google_edgecontainer_node_pool resource.
/// </summary>
public partial class GoogleEdgecontainerNodePool(string name) : TerraformResource("google_edgecontainer_node_pool", name)
{
    /// <summary>
    /// The name of the target Distributed Cloud Edge Cluster.
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
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Only machines matching this filter will be allowed to join the node pool.
    /// The filtering language accepts strings like &amp;quot;name=&amp;lt;name&amp;gt;&amp;quot;, and is
    /// documented in more detail in [AIP-160](https://google.aip.dev/160).
    /// </summary>
    public TerraformValue<string> MachineFilter
    {
        get => GetArgument<TerraformValue<string>>("machine_filter") ?? AsReference("machine_filter");
        set => SetArgument("machine_filter", value);
    }

    /// <summary>
    /// The resource name of the node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The number of nodes in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformValue<double> NodeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// Name of the Google Distributed Cloud Edge zone where this node pool will be created. For example: &#39;us-central1-edge-customer-a&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeLocation is required")]
    public required TerraformValue<string> NodeLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_location");
        set => SetArgument("node_location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time when the node pool was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The lowest release version among all worker nodes.
    /// </summary>
    public TerraformValue<string> NodeVersion
        => AsReference("node_version");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The time when the node pool was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// LocalDiskEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiskEncryption block(s) allowed")]
    public TerraformList<GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock>? LocalDiskEncryption
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock>>("local_disk_encryption");
        set => SetArgument("local_disk_encryption", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleEdgecontainerNodePoolNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleEdgecontainerNodePoolNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEdgecontainerNodePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEdgecontainerNodePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
