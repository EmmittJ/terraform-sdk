using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_server_dns_alias resource.
/// </summary>
public class AzurermMssqlServerDnsAlias : TerraformResource
{
    public AzurermMssqlServerDnsAlias(string name) : base("azurerm_mssql_server_dns_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dns_record");
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
    /// The mssql_server_id attribute.
    /// </summary>
    public string? MssqlServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mssql_server_id")?.Value;
        set => this.WithProperty("mssql_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The dns_record attribute.
    /// </summary>
    public TerraformExpression DnsRecord => this["dns_record"];

}
