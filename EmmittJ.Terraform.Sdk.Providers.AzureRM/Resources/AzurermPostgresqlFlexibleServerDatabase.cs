using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_flexible_server_database resource.
/// </summary>
public class AzurermPostgresqlFlexibleServerDatabase : TerraformResource
{
    public AzurermPostgresqlFlexibleServerDatabase(string name) : base("azurerm_postgresql_flexible_server_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The charset attribute.
    /// </summary>
    public string? Charset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("charset")?.Value;
        set => this.WithProperty("charset", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public string? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation")?.Value;
        set => this.WithProperty("collation", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
