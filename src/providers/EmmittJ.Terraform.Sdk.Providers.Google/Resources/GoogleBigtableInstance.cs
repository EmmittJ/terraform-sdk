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
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect the destination Bigtable cluster. The requirements for this key are: 1) The Cloud Bigtable service account associated with the project that contains this cluster must be granted the cloudkms.cryptoKeyEncrypterDecrypter role on the CMEK key. 2) Only regional keys can be used and the region of the CMEK key must match the region of the cluster. 3) All clusters within an instance must use the same CMEK key. Values are of the form projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// The node scaling factor of this cluster. One of &amp;quot;NodeScalingFactor1X&amp;quot; or &amp;quot;NodeScalingFactor2X&amp;quot;. Defaults to &amp;quot;NodeScalingFactor1X&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? NodeScalingFactor
    {
        set => SetProperty("node_scaling_factor", value);
    }

    /// <summary>
    /// The number of nodes in the cluster. If no value is set, Cloud Bigtable automatically allocates nodes based on your data footprint and optimized for 50% storage utilization.
    /// </summary>
    public TerraformProperty<double>? NumNodes
    {
        set => SetProperty("num_nodes", value);
    }

    /// <summary>
    /// The state of the cluster
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The storage type to use. One of &amp;quot;SSD&amp;quot; or &amp;quot;HDD&amp;quot;. Defaults to &amp;quot;SSD&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The zone to create the Cloud Bigtable cluster in. Each cluster must have a different zone in the same region. Zones that support Bigtable instances are noted on the Cloud Bigtable locations page.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        set => SetProperty("zone", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("instance_type");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the instance will fail. When the field is set to false, deleting the instance is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The human-readable display name of the Bigtable instance. Defaults to the instance name.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// When deleting a BigTable instance, this boolean option will delete all backups within the instance.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The instance type to create. One of &amp;quot;DEVELOPMENT&amp;quot; or &amp;quot;PRODUCTION&amp;quot;. Defaults to &amp;quot;PRODUCTION&amp;quot;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 				
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The name (also called Instance Id in the Cloud Console) of the Cloud Bigtable instance. Must be 6-33 characters and must only contain hyphens, lowercase letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for cluster.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigtableInstanceClusterBlock>? Cluster
    {
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
