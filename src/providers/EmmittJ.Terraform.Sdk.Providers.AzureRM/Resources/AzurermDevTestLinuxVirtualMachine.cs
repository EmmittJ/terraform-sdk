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
        set => SetProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("backend_port", value);
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public TerraformProperty<double>? FrontendPort
    {
        set => SetProperty("frontend_port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("fqdn");
        SetOutput("unique_identifier");
        SetOutput("allow_claim");
        SetOutput("disallow_public_ip_address");
        SetOutput("id");
        SetOutput("lab_name");
        SetOutput("lab_subnet_name");
        SetOutput("lab_virtual_network_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("notes");
        SetOutput("password");
        SetOutput("resource_group_name");
        SetOutput("size");
        SetOutput("ssh_key");
        SetOutput("storage_type");
        SetOutput("tags");
        SetOutput("username");
    }

    /// <summary>
    /// The allow_claim attribute.
    /// </summary>
    public TerraformProperty<bool> AllowClaim
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_claim");
        set => SetProperty("allow_claim", value);
    }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool> DisallowPublicIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disallow_public_ip_address");
        set => SetProperty("disallow_public_ip_address", value);
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
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformProperty<string> LabName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lab_name");
        set => SetProperty("lab_name", value);
    }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabSubnetName is required")]
    public required TerraformProperty<string> LabSubnetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lab_subnet_name");
        set => SetProperty("lab_subnet_name", value);
    }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabVirtualNetworkId is required")]
    public required TerraformProperty<string> LabVirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lab_virtual_network_id");
        set => SetProperty("lab_virtual_network_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The notes attribute.
    /// </summary>
    public TerraformProperty<string> Notes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notes");
        set => SetProperty("notes", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
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
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<string> Size
    {
        get => GetRequiredOutput<TerraformProperty<string>>("size");
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The ssh_key attribute.
    /// </summary>
    public TerraformProperty<string> SshKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssh_key");
        set => SetProperty("ssh_key", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for gallery_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GalleryImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GalleryImageReference block(s) allowed")]
    public List<AzurermDevTestLinuxVirtualMachineGalleryImageReferenceBlock>? GalleryImageReference
    {
        set => SetProperty("gallery_image_reference", value);
    }

    /// <summary>
    /// Block for inbound_nat_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermDevTestLinuxVirtualMachineInboundNatRuleBlock>? InboundNatRule
    {
        set => SetProperty("inbound_nat_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevTestLinuxVirtualMachineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
