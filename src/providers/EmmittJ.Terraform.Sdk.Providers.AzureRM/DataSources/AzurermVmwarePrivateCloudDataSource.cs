using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_vmware_private_cloud.
/// </summary>
public class AzurermVmwarePrivateCloudDataSource : TerraformDataSource
{
    public AzurermVmwarePrivateCloudDataSource(string name) : base("azurerm_vmware_private_cloud", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("circuit");
        SetOutput("hcx_cloud_manager_endpoint");
        SetOutput("internet_connection_enabled");
        SetOutput("location");
        SetOutput("management_cluster");
        SetOutput("management_subnet_cidr");
        SetOutput("network_subnet_cidr");
        SetOutput("nsxt_certificate_thumbprint");
        SetOutput("nsxt_manager_endpoint");
        SetOutput("provisioning_subnet_cidr");
        SetOutput("sku_name");
        SetOutput("tags");
        SetOutput("vcenter_certificate_thumbprint");
        SetOutput("vcsa_endpoint");
        SetOutput("vmotion_subnet_cidr");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVmwarePrivateCloudDataSourceTimeoutsBlock? Timeouts
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
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformExpression InternetConnectionEnabled => this["internet_connection_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    public TerraformExpression ManagementCluster => this["management_cluster"];

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    public TerraformExpression ManagementSubnetCidr => this["management_subnet_cidr"];

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    public TerraformExpression NetworkSubnetCidr => this["network_subnet_cidr"];

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
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

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
