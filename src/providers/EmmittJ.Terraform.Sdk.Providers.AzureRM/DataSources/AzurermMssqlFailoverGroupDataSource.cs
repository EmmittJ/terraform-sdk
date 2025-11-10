using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlFailoverGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("databases");
        SetOutput("partner_server");
        SetOutput("read_write_endpoint_failover_policy");
        SetOutput("readonly_endpoint_failover_policy_enabled");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("name");
        SetOutput("server_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlFailoverGroupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
