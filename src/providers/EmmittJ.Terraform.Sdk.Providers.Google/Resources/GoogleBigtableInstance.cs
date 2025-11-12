using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigtableInstanceClusterBlock() : TerraformBlock("cluster")
{
    /// <summary>
    /// The ID of the Cloud Bigtable cluster. Must be 6-30 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyName { get; set; }

    /// <summary>
    /// The node scaling factor of this cluster. One of &amp;quot;NodeScalingFactor1X&amp;quot; or &amp;quot;NodeScalingFactor2X&amp;quot;. Defaults to &amp;quot;NodeScalingFactor1X&amp;quot;.
    /// </summary>
    [TerraformProperty("node_scaling_factor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeScalingFactor { get; set; }

    /// <summary>
    /// The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based on your data footprint and optimized for 50% storage utilization.
    /// </summary>
    [TerraformProperty("num_nodes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NumNodes { get; set; }


    /// <summary>
    /// The storage type to use. One of &amp;quot;SSD&amp;quot; or &amp;quot;HDD&amp;quot;. Defaults to &amp;quot;SSD&amp;quot;.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageType { get; set; }

    /// <summary>
    /// The zone to create the Cloud Bigtable cluster in. Each cluster must have a different zone in the same region. Zones that support Bigtable instances are noted on the Cloud Bigtable locations page.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigtableInstanceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_instance resource.
/// </summary>
public partial class GoogleBigtableInstance : TerraformResource
{
    public GoogleBigtableInstance(string name) : base("google_bigtable_instance", name)
    {
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The human-readable display name of the Bigtable instance. Defaults to the instance name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// When deleting a BigTable instance, this boolean option will delete all backups within the instance.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance type to create. One of &amp;quot;DEVELOPMENT&amp;quot; or &amp;quot;PRODUCTION&amp;quot;. Defaults to &amp;quot;PRODUCTION&amp;quot;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 				
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance. Must be 6-33 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for cluster.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cluster")]
    public TerraformList<GoogleBigtableInstanceClusterBlock> Cluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigtableInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
