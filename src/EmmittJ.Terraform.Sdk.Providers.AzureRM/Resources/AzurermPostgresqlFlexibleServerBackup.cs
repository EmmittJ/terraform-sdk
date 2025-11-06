using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_flexible_server_backup resource.
/// </summary>
public class AzurermPostgresqlFlexibleServerBackup : TerraformResource
{
    public AzurermPostgresqlFlexibleServerBackup(string name) : base("azurerm_postgresql_flexible_server_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("completed_time");
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
    /// The completed_time attribute.
    /// </summary>
    public TerraformExpression CompletedTime => this["completed_time"];

}
