using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mssql_failover_group.
/// </summary>
public class AzurermMssqlFailoverGroupDataSource : TerraformDataSource
{
    public AzurermMssqlFailoverGroupDataSource(string name) : base("azurerm_mssql_failover_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("databases");
        this.DeclareOutput("partner_server");
        this.DeclareOutput("read_write_endpoint_failover_policy");
        this.DeclareOutput("readonly_endpoint_failover_policy_enabled");
        this.DeclareOutput("tags");
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
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    public TerraformExpression Databases => this["databases"];

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    public TerraformExpression PartnerServer => this["partner_server"];

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    public TerraformExpression ReadWriteEndpointFailoverPolicy => this["read_write_endpoint_failover_policy"];

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public TerraformExpression ReadonlyEndpointFailoverPolicyEnabled => this["readonly_endpoint_failover_policy_enabled"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
