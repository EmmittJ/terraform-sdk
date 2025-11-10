using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for management_cluster in .
/// Nesting mode: list
/// </summary>
public class AzurermVmwarePrivateCloudManagementClusterBlock : ITerraformBlock
{
    /// <summary>
    /// The hosts attribute.
    /// </summary>
    [TerraformPropertyName("hosts")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Hosts => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "hosts");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Id => new TerraformReferenceProperty<TerraformProperty<double>>("", "id");

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformPropertyName("size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Size { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_vmware_private_cloud resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVmwarePrivateCloud : TerraformResource
{
    public AzurermVmwarePrivateCloud(string name) : base("azurerm_vmware_private_cloud", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_connection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternetConnectionEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    [TerraformPropertyName("network_subnet_cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkSubnetCidr { get; set; }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    [TerraformPropertyName("nsxt_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NsxtPassword { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The vcenter_password attribute.
    /// </summary>
    [TerraformPropertyName("vcenter_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VcenterPassword { get; set; }

    /// <summary>
    /// Block for management_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    [TerraformPropertyName("management_cluster")]
    public TerraformList<TerraformBlock<AzurermVmwarePrivateCloudManagementClusterBlock>>? ManagementCluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVmwarePrivateCloudTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("management_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagementSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "management_subnet_cidr");

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
