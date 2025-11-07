using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mysql_flexible_database resource.
/// </summary>
public class AzurermMysqlFlexibleDatabase : TerraformResource
{
    public AzurermMysqlFlexibleDatabase(string name) : base("azurerm_mysql_flexible_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The charset attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Charset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("charset");
        set => this.WithProperty("charset", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation");
        set => this.WithProperty("collation", value);
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
    /// The server_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

}
