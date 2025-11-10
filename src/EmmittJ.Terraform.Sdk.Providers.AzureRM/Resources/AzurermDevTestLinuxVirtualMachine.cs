using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for gallery_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        get => GetProperty<TerraformProperty<string>>("offer");
        set => WithProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => WithProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for inbound_nat_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock : TerraformBlock
{
    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformProperty<double> BackendPort
    {
        get => GetProperty<TerraformProperty<double>>("backend_port");
        set => WithProperty("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformProperty<double>? FrontendPort
    {
        get => GetProperty<TerraformProperty<double>>("frontend_port");
        set => WithProperty("frontend_port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestLinuxVirtualMachineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_dev_test_linux_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDevTestLinuxVirtualMachine : TerraformResource
{
    public AzurermDevTestLinuxVirtualMachine(string name) : base("azurerm_dev_test_linux_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("unique_identifier");
    }

    /// <summary>
    /// The allow_claim attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowClaim
    {
        get => GetProperty<TerraformProperty<bool>>("allow_claim");
        set => this.WithProperty("allow_claim", value);
    }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? DisallowPublicIpAddress
    {
        get => GetProperty<TerraformProperty<bool>>("disallow_public_ip_address");
        set => this.WithProperty("disallow_public_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformProperty<string> LabName
    {
        get => GetProperty<TerraformProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
    }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabSubnetName is required")]
    public required TerraformProperty<string> LabSubnetName
    {
        get => GetProperty<TerraformProperty<string>>("lab_subnet_name");
        set => this.WithProperty("lab_subnet_name", value);
    }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabVirtualNetworkId is required")]
    public required TerraformProperty<string> LabVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("lab_virtual_network_id");
        set => this.WithProperty("lab_virtual_network_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<string> Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The ssh_key attribute.
    /// </summary>
    public TerraformProperty<string>? SshKey
    {
        get => GetProperty<TerraformProperty<string>>("ssh_key");
        set => this.WithProperty("ssh_key", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// Block for gallery_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GalleryImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GalleryImageReference block(s) allowed")]
    public List<AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock>? GalleryImageReference
    {
        get => GetProperty<List<AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock>>("gallery_image_reference");
        set => this.WithProperty("gallery_image_reference", value);
    }

    /// <summary>
    /// Block for inbound_nat_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock>? InboundNatRule
    {
        get => GetProperty<HashSet<AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock>>("inbound_nat_rule");
        set => this.WithProperty("inbound_nat_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevTestLinuxVirtualMachineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevTestLinuxVirtualMachineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformExpression UniqueIdentifier => this["unique_identifier"];

}
