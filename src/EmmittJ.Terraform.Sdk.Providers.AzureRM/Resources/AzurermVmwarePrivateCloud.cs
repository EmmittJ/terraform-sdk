using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for management_cluster in .
/// Nesting mode: list
/// </summary>
public class AzurermVmwarePrivateCloudManagementClusterBlock : TerraformBlock
{
    /// <summary>
    /// The hosts attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Hosts
    {
        get => GetProperty<List<TerraformProperty<string>>>("hosts");
        set => WithProperty("hosts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<double>? Id
    {
        get => GetProperty<TerraformProperty<double>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudTimeoutsBlock : TerraformBlock
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
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
/// Manages a azurerm_vmware_private_cloud resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVmwarePrivateCloud : TerraformResource
{
    public AzurermVmwarePrivateCloud(string name) : base("azurerm_vmware_private_cloud", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("circuit");
        this.DeclareOutput("hcx_cloud_manager_endpoint");
        this.DeclareOutput("management_subnet_cidr");
        this.DeclareOutput("nsxt_certificate_thumbprint");
        this.DeclareOutput("nsxt_manager_endpoint");
        this.DeclareOutput("provisioning_subnet_cidr");
        this.DeclareOutput("vcenter_certificate_thumbprint");
        this.DeclareOutput("vcsa_endpoint");
        this.DeclareOutput("vmotion_subnet_cidr");
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
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetConnectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_connection_enabled");
        set => this.WithProperty("internet_connection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    public required TerraformProperty<string> NetworkSubnetCidr
    {
        get => GetProperty<TerraformProperty<string>>("network_subnet_cidr");
        set => this.WithProperty("network_subnet_cidr", value);
    }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    public TerraformProperty<string>? NsxtPassword
    {
        get => GetProperty<TerraformProperty<string>>("nsxt_password");
        set => this.WithProperty("nsxt_password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vcenter_password attribute.
    /// </summary>
    public TerraformProperty<string>? VcenterPassword
    {
        get => GetProperty<TerraformProperty<string>>("vcenter_password");
        set => this.WithProperty("vcenter_password", value);
    }

    /// <summary>
    /// Block for management_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    public List<AzurermVmwarePrivateCloudManagementClusterBlock>? ManagementCluster
    {
        get => GetProperty<List<AzurermVmwarePrivateCloudManagementClusterBlock>>("management_cluster");
        set => this.WithProperty("management_cluster", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVmwarePrivateCloudTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVmwarePrivateCloudTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    public TerraformExpression Circuit => this["circuit"];

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    public TerraformExpression HcxCloudManagerEndpoint => this["hcx_cloud_manager_endpoint"];

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    public TerraformExpression ManagementSubnetCidr => this["management_subnet_cidr"];

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    public TerraformExpression NsxtCertificateThumbprint => this["nsxt_certificate_thumbprint"];

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    public TerraformExpression NsxtManagerEndpoint => this["nsxt_manager_endpoint"];

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    public TerraformExpression ProvisioningSubnetCidr => this["provisioning_subnet_cidr"];

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    public TerraformExpression VcenterCertificateThumbprint => this["vcenter_certificate_thumbprint"];

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    public TerraformExpression VcsaEndpoint => this["vcsa_endpoint"];

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    public TerraformExpression VmotionSubnetCidr => this["vmotion_subnet_cidr"];

}
