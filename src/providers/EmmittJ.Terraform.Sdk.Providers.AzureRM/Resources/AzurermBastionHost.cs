using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBastionHostIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    public required TerraformProperty<string> PublicIpAddressId
    {
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBastionHostTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_bastion_host resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBastionHost : TerraformResource
{
    public AzurermBastionHost(string name) : base("azurerm_bastion_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_name");
        SetOutput("copy_paste_enabled");
        SetOutput("file_copy_enabled");
        SetOutput("id");
        SetOutput("ip_connect_enabled");
        SetOutput("kerberos_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("scale_units");
        SetOutput("session_recording_enabled");
        SetOutput("shareable_link_enabled");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("tunneling_enabled");
        SetOutput("virtual_network_id");
        SetOutput("zones");
    }

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CopyPasteEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_paste_enabled");
        set => SetProperty("copy_paste_enabled", value);
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FileCopyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("file_copy_enabled");
        set => SetProperty("file_copy_enabled", value);
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
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IpConnectEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ip_connect_enabled");
        set => SetProperty("ip_connect_enabled", value);
    }

    /// <summary>
    /// The kerberos_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> KerberosEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("kerberos_enabled");
        set => SetProperty("kerberos_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public TerraformProperty<double> ScaleUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scale_units");
        set => SetProperty("scale_units", value);
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SessionRecordingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("session_recording_enabled");
        set => SetProperty("session_recording_enabled", value);
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ShareableLinkEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("shareable_link_enabled");
        set => SetProperty("shareable_link_enabled", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
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
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TunnelingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tunneling_enabled");
        set => SetProperty("tunneling_enabled", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfiguration block(s) allowed")]
    public List<AzurermBastionHostIpConfigurationBlock>? IpConfiguration
    {
        set => SetProperty("ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBastionHostTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

}
