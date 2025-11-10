using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for local_disk_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The Cloud KMS CryptoKey e.g. projects/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{cryptoKey} to use for protecting node local disks.
    /// If not specified, a Google-managed key will be used instead.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// The Cloud KMS CryptoKeyVersion currently in use for protecting node local disks. Only applicable if kmsKey is set.
    /// </summary>
    [TerraformPropertyName("kms_key_active_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyActiveVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_active_version");

    /// <summary>
    /// Availability of the Cloud KMS CryptoKey. If not KEY_AVAILABLE, then nodes may go offline as they cannot access their local data.
    /// This can be caused by a lack of permissions to use the key, or if the key is disabled or deleted.
    /// </summary>
    [TerraformPropertyName("kms_key_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyState => new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_state");

}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerNodePoolNodeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// &amp;quot;The Kubernetes node labels&amp;quot;
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "labels");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerNodePoolTimeoutsBlock : ITerraformBlock
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
/// Manages a google_edgecontainer_node_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEdgecontainerNodePool : TerraformResource
{
    public GoogleEdgecontainerNodePool(string name) : base("google_edgecontainer_node_pool", name)
    {
    }

    /// <summary>
    /// The name of the target Distributed Cloud Edge Cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Only machines matching this filter will be allowed to join the node pool.
    /// The filtering language accepts strings like &amp;quot;name=&amp;lt;name&amp;gt;&amp;quot;, and is
    /// documented in more detail in [AIP-160](https://google.aip.dev/160).
    /// </summary>
    [TerraformPropertyName("machine_filter")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MachineFilter { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "machine_filter");

    /// <summary>
    /// The resource name of the node pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The number of nodes in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> NodeCount { get; set; }

    /// <summary>
    /// Name of the Google Distributed Cloud Edge zone where this node pool will be created. For example: &#39;us-central1-edge-customer-a&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeLocation is required")]
    [TerraformPropertyName("node_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeLocation { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for local_disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiskEncryption block(s) allowed")]
    [TerraformPropertyName("local_disk_encryption")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerNodePoolLocalDiskEncryptionBlock>>? LocalDiskEncryption { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformPropertyName("node_config")]
    public TerraformList<TerraformBlock<GoogleEdgecontainerNodePoolNodeConfigBlock>>? NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleEdgecontainerNodePoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time when the node pool was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The lowest release version among all worker nodes.
    /// </summary>
    [TerraformPropertyName("node_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_version");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The time when the node pool was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
