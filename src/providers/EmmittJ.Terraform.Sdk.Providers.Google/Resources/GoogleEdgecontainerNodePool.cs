using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for local_disk_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud KMS CryptoKey e.g. projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey} to use for protecting node local disks.
    /// If not specified, a Google-managed key will be used instead.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The Cloud KMS CryptoKeyVersion currently in use for protecting node local disks. Only applicable if kmsKey is set.
    /// </summary>
    public TerraformProperty<string>? KmsKeyActiveVersion
    {
        set => SetProperty("kms_key_active_version", value);
    }

    /// <summary>
    /// Availability of the Cloud KMS CryptoKey. If not KEY_AVAILABLE, then nodes may go offline as they cannot access their local data.
    /// This can be caused by a lack of permissions to use the key, or if the key is disabled or deleted.
    /// </summary>
    public TerraformProperty<string>? KmsKeyState
    {
        set => SetProperty("kms_key_state", value);
    }

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerNodePoolNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// &amp;quot;The Kubernetes node labels&amp;quot;
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerNodePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_edgecontainer_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEdgecontainerNodePool : TerraformResource
{
    public GoogleEdgecontainerNodePool(string name) : base("google_edgecontainer_node_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("node_version");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("cluster");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("machine_filter");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("node_location");
        SetOutput("project");
    }

    /// <summary>
    /// The name of the target Distributed Cloud Edge Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Only machines matching this filter will be allowed to join the node pool.
    /// The filtering language accepts strings like &amp;quot;name=&amp;lt;name&amp;gt;&amp;quot;, and is
    /// documented in more detail in [AIP-160](https://google.aip.dev/160).
    /// </summary>
    public TerraformProperty<string> MachineFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("machine_filter");
        set => SetProperty("machine_filter", value);
    }

    /// <summary>
    /// The resource name of the node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The number of nodes in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// Name of the Google Distributed Cloud Edge zone where this node pool will be created. For example: &#39;us-central1-edge-customer-a&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeLocation is required")]
    public required TerraformProperty<string> NodeLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_location");
        set => SetProperty("node_location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for local_disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiskEncryption block(s) allowed")]
    public List<GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock>? LocalDiskEncryption
    {
        set => SetProperty("local_disk_encryption", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleEdgecontainerNodePoolNodeConfigBlock>? NodeConfig
    {
        set => SetProperty("node_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEdgecontainerNodePoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the node pool was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The lowest release version among all worker nodes.
    /// </summary>
    public TerraformExpression NodeVersion => this["node_version"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the node pool was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
