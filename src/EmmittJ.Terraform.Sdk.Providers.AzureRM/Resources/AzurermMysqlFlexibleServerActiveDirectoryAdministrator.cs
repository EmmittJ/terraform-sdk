using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mysql_flexible_server_active_directory_administrator resource.
/// </summary>
public class AzurermMysqlFlexibleServerActiveDirectoryAdministrator : TerraformResource
{
    public AzurermMysqlFlexibleServerActiveDirectoryAdministrator(string name) : base("azurerm_mysql_flexible_server_active_directory_administrator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The identity_id attribute.
    /// </summary>
    public string? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id")?.Value;
        set => this.WithProperty("identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The login attribute.
    /// </summary>
    public string? Login
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login")?.Value;
        set => this.WithProperty("login", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public string? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id")?.Value;
        set => this.WithProperty("object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
