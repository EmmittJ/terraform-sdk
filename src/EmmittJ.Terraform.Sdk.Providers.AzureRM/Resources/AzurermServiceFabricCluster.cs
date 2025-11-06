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
    public HashSet<string>? AddOnFeatures
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("add_on_features")?.Value;
        set => this.WithProperty("add_on_features", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cluster_code_version attribute.
    /// </summary>
    public string? ClusterCodeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_code_version")?.Value;
        set => this.WithProperty("cluster_code_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The management_endpoint attribute.
    /// </summary>
    public string? ManagementEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_endpoint")?.Value;
        set => this.WithProperty("management_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reliability_level attribute.
    /// </summary>
    public string? ReliabilityLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reliability_level")?.Value;
        set => this.WithProperty("reliability_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_fabric_zonal_upgrade_mode attribute.
    /// </summary>
    public string? ServiceFabricZonalUpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_fabric_zonal_upgrade_mode")?.Value;
        set => this.WithProperty("service_fabric_zonal_upgrade_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public string? UpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upgrade_mode")?.Value;
        set => this.WithProperty("upgrade_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vm_image attribute.
    /// </summary>
    public string? VmImage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_image")?.Value;
        set => this.WithProperty("vm_image", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vmss_zonal_upgrade_mode attribute.
    /// </summary>
    public string? VmssZonalUpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vmss_zonal_upgrade_mode")?.Value;
        set => this.WithProperty("vmss_zonal_upgrade_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

}
