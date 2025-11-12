using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVmwarePrivateCloudDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_vmware_private_cloud.
/// </summary>
public partial class AzurermVmwarePrivateCloudDataSource : TerraformDataSource
{
    public AzurermVmwarePrivateCloudDataSource(string name) : base("azurerm_vmware_private_cloud", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVmwarePrivateCloudDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    [TerraformProperty("circuit")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Circuit { get; }

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    [TerraformProperty("hcx_cloud_manager_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HcxCloudManagerEndpoint { get; }

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_connection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> InternetConnectionEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    [TerraformProperty("management_cluster")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagementCluster { get; }

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("management_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagementSubnetCidr { get; }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("network_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkSubnetCidr { get; }

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    [TerraformProperty("nsxt_certificate_thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NsxtCertificateThumbprint { get; }

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    [TerraformProperty("nsxt_manager_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NsxtManagerEndpoint { get; }

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("provisioning_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProvisioningSubnetCidr { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    [TerraformProperty("vcenter_certificate_thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VcenterCertificateThumbprint { get; }

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    [TerraformProperty("vcsa_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VcsaEndpoint { get; }

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("vmotion_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VmotionSubnetCidr { get; }

}
