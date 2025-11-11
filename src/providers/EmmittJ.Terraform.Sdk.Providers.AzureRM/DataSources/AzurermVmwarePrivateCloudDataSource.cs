using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_vmware_private_cloud.
/// </summary>
public class AzurermVmwarePrivateCloudDataSource : TerraformDataSource
{
    public AzurermVmwarePrivateCloudDataSource(string name) : base("azurerm_vmware_private_cloud", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVmwarePrivateCloudDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    [TerraformPropertyName("circuit")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Circuit => new TerraformReference(this, "circuit");

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("hcx_cloud_manager_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HcxCloudManagerEndpoint => new TerraformReference(this, "hcx_cloud_manager_endpoint");

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_connection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> InternetConnectionEnabled => new TerraformReference(this, "internet_connection_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    [TerraformPropertyName("management_cluster")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagementCluster => new TerraformReference(this, "management_cluster");

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("management_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagementSubnetCidr => new TerraformReference(this, "management_subnet_cidr");

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("network_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkSubnetCidr => new TerraformReference(this, "network_subnet_cidr");

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("nsxt_certificate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NsxtCertificateThumbprint => new TerraformReference(this, "nsxt_certificate_thumbprint");

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("nsxt_manager_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NsxtManagerEndpoint => new TerraformReference(this, "nsxt_manager_endpoint");

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProvisioningSubnetCidr => new TerraformReference(this, "provisioning_subnet_cidr");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("vcenter_certificate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VcenterCertificateThumbprint => new TerraformReference(this, "vcenter_certificate_thumbprint");

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("vcsa_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VcsaEndpoint => new TerraformReference(this, "vcsa_endpoint");

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("vmotion_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmotionSubnetCidr => new TerraformReference(this, "vmotion_subnet_cidr");

}
