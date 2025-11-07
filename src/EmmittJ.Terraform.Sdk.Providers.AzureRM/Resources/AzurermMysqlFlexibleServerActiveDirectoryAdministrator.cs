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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The login attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Login
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login");
        set => this.WithProperty("login", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
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
    /// The tenant_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
