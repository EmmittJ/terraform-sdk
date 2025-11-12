using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for management_cluster in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVmwarePrivateCloudManagementClusterBlock() : TerraformBlock("management_cluster")
{


    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Size { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVmwarePrivateCloudTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_vmware_private_cloud resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVmwarePrivateCloud : TerraformResource
{
    public AzurermVmwarePrivateCloud(string name) : base("azurerm_vmware_private_cloud", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_connection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetConnectionEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    [TerraformProperty("network_subnet_cidr")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkSubnetCidr { get; set; }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    [TerraformProperty("nsxt_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NsxtPassword { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The vcenter_password attribute.
    /// </summary>
    [TerraformProperty("vcenter_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VcenterPassword { get; set; }

    /// <summary>
    /// Block for management_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    [TerraformProperty("management_cluster")]
    public required TerraformList<AzurermVmwarePrivateCloudManagementClusterBlock> ManagementCluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVmwarePrivateCloudTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("management_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagementSubnetCidr { get; }

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
