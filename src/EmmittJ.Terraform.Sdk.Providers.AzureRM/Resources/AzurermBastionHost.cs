using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bastion_host resource.
/// </summary>
public class AzurermBastionHost : TerraformResource
{
    public AzurermBastionHost(string name) : base("azurerm_bastion_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dns_name");
    }

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyPasteEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("copy_paste_enabled");
        set => this.WithProperty("copy_paste_enabled", value);
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FileCopyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("file_copy_enabled");
        set => this.WithProperty("file_copy_enabled", value);
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
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IpConnectEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ip_connect_enabled");
        set => this.WithProperty("ip_connect_enabled", value);
    }

    /// <summary>
    /// The kerberos_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? KerberosEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_enabled");
        set => this.WithProperty("kerberos_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleUnits
    {
        get => GetProperty<TerraformProperty<double>>("scale_units");
        set => this.WithProperty("scale_units", value);
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SessionRecordingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("session_recording_enabled");
        set => this.WithProperty("session_recording_enabled", value);
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ShareableLinkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("shareable_link_enabled");
        set => this.WithProperty("shareable_link_enabled", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TunnelingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tunneling_enabled");
        set => this.WithProperty("tunneling_enabled", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

}
