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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mssql_server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MssqlServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mssql_server_id");
        set => this.WithProperty("mssql_server_id", value);
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
    /// The dns_record attribute.
    /// </summary>
    public TerraformExpression DnsRecord => this["dns_record"];

}
