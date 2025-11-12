using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for gallery_image_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock() : TerraformBlock("gallery_image_reference")
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformProperty("offer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for inbound_nat_rule in .
/// Nesting mode: set
/// </summary>
public partial class AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock() : TerraformBlock("inbound_nat_rule")
{
    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformProperty("backend_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BackendPort { get; set; }


    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevTestLinuxVirtualMachineTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_dev_test_linux_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDevTestLinuxVirtualMachine : TerraformResource
{
    public AzurermDevTestLinuxVirtualMachine(string name) : base("azurerm_dev_test_linux_virtual_machine", name)
    {
    }

    /// <summary>
    /// The allow_claim attribute.
    /// </summary>
    [TerraformProperty("allow_claim")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowClaim { get; set; }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    [TerraformProperty("disallow_public_ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisallowPublicIpAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    [TerraformProperty("lab_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LabName { get; set; }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabSubnetName is required")]
    [TerraformProperty("lab_subnet_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LabSubnetName { get; set; }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabVirtualNetworkId is required")]
    [TerraformProperty("lab_virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LabVirtualNetworkId { get; set; }

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
    /// The notes attribute.
    /// </summary>
    [TerraformProperty("notes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Notes { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Size { get; set; }

    /// <summary>
    /// The ssh_key attribute.
    /// </summary>
    [TerraformProperty("ssh_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SshKey { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    [TerraformProperty("storage_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

    /// <summary>
    /// Block for gallery_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GalleryImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GalleryImageReference block(s) allowed")]
    [TerraformProperty("gallery_image_reference")]
    public required TerraformList<AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock> GalleryImageReference { get; set; } = new();

    /// <summary>
    /// Block for inbound_nat_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("inbound_nat_rule")]
    public TerraformSet<AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock> InboundNatRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDevTestLinuxVirtualMachineTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformProperty("unique_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueIdentifier { get; }

}
