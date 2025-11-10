using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableInstanceClusterBlock : ITerraformBlock
{
    /// <summary>
    /// The ID of the Cloud Bigtable cluster. Must be 6-30 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_name");

    /// <summary>
    /// The node scaling factor of this cluster. One of &amp;quot;NodeScalingFactor1X&amp;quot; or &amp;quot;NodeScalingFactor2X&amp;quot;. Defaults to &amp;quot;NodeScalingFactor1X&amp;quot;.
    /// </summary>
    [TerraformPropertyName("node_scaling_factor")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeScalingFactor { get; set; }

    /// <summary>
    /// The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based on your data footprint and optimized for 50% storage utilization.
    /// </summary>
    [TerraformPropertyName("num_nodes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumNodes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "num_nodes");

    /// <summary>
    /// The state of the cluster
    /// </summary>
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The storage type to use. One of &amp;quot;SSD&amp;quot; or &amp;quot;HDD&amp;quot;. Defaults to &amp;quot;SSD&amp;quot;.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageType { get; set; }

    /// <summary>
    /// The zone to create the Cloud Bigtable cluster in. Each cluster must have a different zone in the same region. Zones that support Bigtable instances are noted on the Cloud Bigtable locations page.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "zone");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_instance resource.
/// </summary>
public class GoogleBigtableInstance : TerraformResource
{
    public GoogleBigtableInstance(string name) : base("google_bigtable_instance", name)
    {
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The human-readable display name of the Bigtable instance. Defaults to the instance name.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// When deleting a BigTable instance, this boolean option will delete all backups within the instance.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance type to create. One of &amp;quot;DEVELOPMENT&amp;quot; or &amp;quot;PRODUCTION&amp;quot;. Defaults to &amp;quot;PRODUCTION&amp;quot;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceType { get; set; }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 				
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance. Must be 6-33 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for cluster.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cluster")]
    public TerraformList<TerraformBlock<GoogleBigtableInstanceClusterBlock>>? Cluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigtableInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

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
