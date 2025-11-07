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
    public TerraformLiteralProperty<bool>? CopyPasteEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_paste_enabled");
        set => this.WithProperty("copy_paste_enabled", value);
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FileCopyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("file_copy_enabled");
        set => this.WithProperty("file_copy_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IpConnectEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ip_connect_enabled");
        set => this.WithProperty("ip_connect_enabled", value);
    }

    /// <summary>
    /// The kerberos_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? KerberosEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kerberos_enabled");
        set => this.WithProperty("kerberos_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ScaleUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scale_units");
        set => this.WithProperty("scale_units", value);
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SessionRecordingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("session_recording_enabled");
        set => this.WithProperty("session_recording_enabled", value);
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ShareableLinkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("shareable_link_enabled");
        set => this.WithProperty("shareable_link_enabled", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TunnelingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tunneling_enabled");
        set => this.WithProperty("tunneling_enabled", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

}
