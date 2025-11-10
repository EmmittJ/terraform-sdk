using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVmwarePrivateCloudDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    [TerraformPropertyName("circuit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Circuit => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "circuit");

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("hcx_cloud_manager_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HcxCloudManagerEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hcx_cloud_manager_endpoint");

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_connection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InternetConnectionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "internet_connection_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    [TerraformPropertyName("management_cluster")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagementCluster => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "management_cluster");

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("management_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagementSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "management_subnet_cidr");

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("network_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_subnet_cidr");

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("nsxt_certificate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NsxtCertificateThumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nsxt_certificate_thumbprint");

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("nsxt_manager_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NsxtManagerEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nsxt_manager_endpoint");

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProvisioningSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provisioning_subnet_cidr");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("vcenter_certificate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VcenterCertificateThumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vcenter_certificate_thumbprint");

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("vcsa_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VcsaEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vcsa_endpoint");

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("vmotion_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmotionSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vmotion_subnet_cidr");

}
