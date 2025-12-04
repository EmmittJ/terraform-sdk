using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for gallery_image_reference in AzurermDevTestLinuxVirtualMachine.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gallery_image_reference";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => GetRequiredArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for inbound_nat_rule in AzurermDevTestLinuxVirtualMachine.
/// Nesting mode: set
/// </summary>
public class AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inbound_nat_rule";

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformValue<double> BackendPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformValue<double> FrontendPort
        => AsReference("frontend_port");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDevTestLinuxVirtualMachine.
/// Nesting mode: single
/// </summary>
public class AzurermDevTestLinuxVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_test_linux_virtual_machine Terraform resource.
/// Manages a azurerm_dev_test_linux_virtual_machine resource.
/// </summary>
public partial class AzurermDevTestLinuxVirtualMachine(string name) : TerraformResource("azurerm_dev_test_linux_virtual_machine", name)
{
    /// <summary>
    /// The allow_claim attribute.
    /// </summary>
    public TerraformValue<bool>? AllowClaim
    {
        get => GetArgument<TerraformValue<bool>>("allow_claim");
        set => SetArgument("allow_claim", value);
    }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool>? DisallowPublicIpAddress
    {
        get => GetArgument<TerraformValue<bool>>("disallow_public_ip_address");
        set => SetArgument("disallow_public_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformValue<string> LabName
    {
        get => GetRequiredArgument<TerraformValue<string>>("lab_name");
        set => SetArgument("lab_name", value);
    }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabSubnetName is required")]
    public required TerraformValue<string> LabSubnetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("lab_subnet_name");
        set => SetArgument("lab_subnet_name", value);
    }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabVirtualNetworkId is required")]
    public required TerraformValue<string> LabVirtualNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("lab_virtual_network_id");
        set => SetArgument("lab_virtual_network_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => GetArgument<TerraformValue<string>>("notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<string> Size
    {
        get => GetRequiredArgument<TerraformValue<string>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The ssh_key attribute.
    /// </summary>
    public TerraformValue<string>? SshKey
    {
        get => GetArgument<TerraformValue<string>>("ssh_key");
        set => SetArgument("ssh_key", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformValue<string> StorageType
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformValue<string> UniqueIdentifier
        => AsReference("unique_identifier");

    /// <summary>
    /// GalleryImageReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GalleryImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GalleryImageReference block(s) allowed")]
    public required TerraformList<AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock> GalleryImageReference
    {
        get => GetRequiredArgument<TerraformList<AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock>>("gallery_image_reference");
        set => SetArgument("gallery_image_reference", value);
    }

    /// <summary>
    /// InboundNatRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock>? InboundNatRule
    {
        get => GetArgument<TerraformSet<AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock>>("inbound_nat_rule");
        set => SetArgument("inbound_nat_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestLinuxVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestLinuxVirtualMachineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
