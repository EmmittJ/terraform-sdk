using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMysqlFlexibleServerFirewallRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mysql_flexible_server_firewall_rule resource.
/// </summary>
public class AzurermMysqlFlexibleServerFirewallRule : TerraformResource
{
    public AzurermMysqlFlexibleServerFirewallRule(string name) : base("azurerm_mysql_flexible_server_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The end_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndIpAddress is required")]
    public required TerraformProperty<string> EndIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("end_ip_address");
        set => this.WithProperty("end_ip_address", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The start_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartIpAddress is required")]
    public required TerraformProperty<string> StartIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("start_ip_address");
        set => this.WithProperty("start_ip_address", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMysqlFlexibleServerFirewallRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMysqlFlexibleServerFirewallRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
