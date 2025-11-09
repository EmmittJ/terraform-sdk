using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_service_fabric_cluster resource.
/// </summary>
public class AzurermServiceFabricCluster : TerraformResource
{
    public AzurermServiceFabricCluster(string name) : base("azurerm_service_fabric_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_endpoint");
    }

    /// <summary>
    /// The add_on_features attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AddOnFeatures
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("add_on_features");
        set => this.WithProperty("add_on_features", value);
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterCodeVersion
    {
        get => GetProperty<TerraformProperty<string>>("cluster_code_version");
        set => this.WithProperty("cluster_code_version", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The management_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? ManagementEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("management_endpoint");
        set => this.WithProperty("management_endpoint", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reliability_level attribute.
    /// </summary>
    public TerraformProperty<string>? ReliabilityLevel
    {
        get => GetProperty<TerraformProperty<string>>("reliability_level");
        set => this.WithProperty("reliability_level", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceFabricZonalUpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("service_fabric_zonal_upgrade_mode");
        set => this.WithProperty("service_fabric_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_mode");
        set => this.WithProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    public TerraformProperty<string>? VmImage
    {
        get => GetProperty<TerraformProperty<string>>("vm_image");
        set => this.WithProperty("vm_image", value);
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? VmssZonalUpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("vmss_zonal_upgrade_mode");
        set => this.WithProperty("vmss_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

}
