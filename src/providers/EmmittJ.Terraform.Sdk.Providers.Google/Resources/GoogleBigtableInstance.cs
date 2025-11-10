using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableInstanceClusterBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the Cloud Bigtable cluster. Must be 6-30 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_id");
        set => WithProperty("cluster_id", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// The node scaling factor of this cluster. One of &amp;quot;NodeScalingFactor1X&amp;quot; or &amp;quot;NodeScalingFactor2X&amp;quot;. Defaults to &amp;quot;NodeScalingFactor1X&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? NodeScalingFactor
    {
        get => GetProperty<TerraformProperty<string>>("node_scaling_factor");
        set => WithProperty("node_scaling_factor", value);
    }

    /// <summary>
    /// The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based on your data footprint and optimized for 50% storage utilization.
    /// </summary>
    public TerraformProperty<double>? NumNodes
    {
        get => GetProperty<TerraformProperty<double>>("num_nodes");
        set => WithProperty("num_nodes", value);
    }

    /// <summary>
    /// The state of the cluster
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The storage type to use. One of &amp;quot;SSD&amp;quot; or &amp;quot;HDD&amp;quot;. Defaults to &amp;quot;SSD&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => WithProperty("storage_type", value);
    }

    /// <summary>
    /// The zone to create the Cloud Bigtable cluster in. Each cluster must have a different zone in the same region. Zones that support Bigtable instances are noted on the Cloud Bigtable locations page.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => WithProperty("zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableInstanceTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a google_bigtable_instance resource.
/// </summary>
public class GoogleBigtableInstance : TerraformResource
{
    public GoogleBigtableInstance(string name) : base("google_bigtable_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The human-readable display name of the Bigtable instance. Defaults to the instance name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// When deleting a BigTable instance, this boolean option will delete all backups within the instance.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The instance type to create. One of &amp;quot;DEVELOPMENT&amp;quot; or &amp;quot;PRODUCTION&amp;quot;. Defaults to &amp;quot;PRODUCTION&amp;quot;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// A mapping of labels to assign to the resource.
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
    /// The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance. Must be 6-33 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for cluster.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigtableInstanceClusterBlock>? Cluster
    {
        get => GetProperty<List<GoogleBigtableInstanceClusterBlock>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigtableInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
