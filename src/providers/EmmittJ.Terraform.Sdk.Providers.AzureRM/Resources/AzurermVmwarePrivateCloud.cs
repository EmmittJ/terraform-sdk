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
        set => SetProperty("hosts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<double>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        set => SetProperty("size", value);
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
        SetOutput("circuit");
        SetOutput("hcx_cloud_manager_endpoint");
        SetOutput("management_subnet_cidr");
        SetOutput("nsxt_certificate_thumbprint");
        SetOutput("nsxt_manager_endpoint");
        SetOutput("provisioning_subnet_cidr");
        SetOutput("vcenter_certificate_thumbprint");
        SetOutput("vcsa_endpoint");
        SetOutput("vmotion_subnet_cidr");
        SetOutput("id");
        SetOutput("internet_connection_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_subnet_cidr");
        SetOutput("nsxt_password");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("tags");
        SetOutput("vcenter_password");
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
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetConnectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_connection_enabled");
        set => SetProperty("internet_connection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    public required TerraformProperty<string> NetworkSubnetCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_subnet_cidr");
        set => SetProperty("network_subnet_cidr", value);
    }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    public TerraformProperty<string> NsxtPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nsxt_password");
        set => SetProperty("nsxt_password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The vcenter_password attribute.
    /// </summary>
    public TerraformProperty<string> VcenterPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vcenter_password");
        set => SetProperty("vcenter_password", value);
    }

    /// <summary>
    /// Block for management_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    public List<AzurermVmwarePrivateCloudManagementClusterBlock>? ManagementCluster
    {
        set => SetProperty("management_cluster", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVmwarePrivateCloudTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
