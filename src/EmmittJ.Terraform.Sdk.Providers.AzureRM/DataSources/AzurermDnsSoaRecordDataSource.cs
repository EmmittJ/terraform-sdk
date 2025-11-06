using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_dns_soa_record.
/// </summary>
public class AzurermDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermDnsSoaRecordDataSource(string name) : base("azurerm_dns_soa_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("email");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("host_name");
        this.DeclareOutput("minimum_ttl");
        this.DeclareOutput("refresh_time");
        this.DeclareOutput("retry_time");
        this.DeclareOutput("serial_number");
        this.DeclareOutput("tags");
        this.DeclareOutput("ttl");
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
    /// The zone_name attribute.
    /// </summary>
    public string? ZoneName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_name")?.Value;
        set => this.WithProperty("zone_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformExpression HostName => this["host_name"];

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    public TerraformExpression MinimumTtl => this["minimum_ttl"];

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformExpression RefreshTime => this["refresh_time"];

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformExpression RetryTime => this["retry_time"];

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformExpression SerialNumber => this["serial_number"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformExpression Ttl => this["ttl"];

}
