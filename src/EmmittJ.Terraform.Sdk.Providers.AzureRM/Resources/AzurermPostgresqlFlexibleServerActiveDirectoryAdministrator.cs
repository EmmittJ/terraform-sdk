using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_flexible_server_active_directory_administrator resource.
/// </summary>
public class AzurermPostgresqlFlexibleServerActiveDirectoryAdministrator : TerraformResource
{
    public AzurermPostgresqlFlexibleServerActiveDirectoryAdministrator(string name) : base("azurerm_postgresql_flexible_server_active_directory_administrator", name)
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
    /// The object_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// The principal_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_name");
        set => this.WithProperty("principal_name", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_type");
        set => this.WithProperty("principal_type", value);
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

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
