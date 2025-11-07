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
    /// The server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// The completed_time attribute.
    /// </summary>
    public TerraformExpression CompletedTime => this["completed_time"];

}
