using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("circuit");
        this.DeclareOutput("hcx_cloud_manager_endpoint");
        this.DeclareOutput("internet_connection_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("management_cluster");
        this.DeclareOutput("management_subnet_cidr");
        this.DeclareOutput("network_subnet_cidr");
        this.DeclareOutput("nsxt_certificate_thumbprint");
        this.DeclareOutput("nsxt_manager_endpoint");
        this.DeclareOutput("provisioning_subnet_cidr");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
        this.DeclareOutput("vcenter_certificate_thumbprint");
        this.DeclareOutput("vcsa_endpoint");
        this.DeclareOutput("vmotion_subnet_cidr");
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
