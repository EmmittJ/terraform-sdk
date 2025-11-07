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
    public TerraformLiteralProperty<HashSet<string>>? AddOnFeatures
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("add_on_features");
        set => this.WithProperty("add_on_features", value);
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterCodeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_code_version");
        set => this.WithProperty("cluster_code_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The management_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagementEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_endpoint");
        set => this.WithProperty("management_endpoint", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reliability_level attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReliabilityLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reliability_level");
        set => this.WithProperty("reliability_level", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceFabricZonalUpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_fabric_zonal_upgrade_mode");
        set => this.WithProperty("service_fabric_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upgrade_mode");
        set => this.WithProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmImage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_image");
        set => this.WithProperty("vm_image", value);
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmssZonalUpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmss_zonal_upgrade_mode");
        set => this.WithProperty("vmss_zonal_upgrade_mode", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

}
