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
    public bool? CopyPasteEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_paste_enabled")?.Value;
        set => this.WithProperty("copy_paste_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public bool? FileCopyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("file_copy_enabled")?.Value;
        set => this.WithProperty("file_copy_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    public bool? IpConnectEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ip_connect_enabled")?.Value;
        set => this.WithProperty("ip_connect_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kerberos_enabled attribute.
    /// </summary>
    public bool? KerberosEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kerberos_enabled")?.Value;
        set => this.WithProperty("kerberos_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public double? ScaleUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scale_units")?.Value;
        set => this.WithProperty("scale_units", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public bool? SessionRecordingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("session_recording_enabled")?.Value;
        set => this.WithProperty("session_recording_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public bool? ShareableLinkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("shareable_link_enabled")?.Value;
        set => this.WithProperty("shareable_link_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public bool? TunnelingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tunneling_enabled")?.Value;
        set => this.WithProperty("tunneling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

}
