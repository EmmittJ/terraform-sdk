using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_active_directory_administrator resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermPostgresqlActiveDirectoryAdministrator : TerraformResource
{
    public AzurermPostgresqlActiveDirectoryAdministrator(string name) : base("azurerm_postgresql_active_directory_administrator", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public string? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name")?.Value;
        set => this.WithProperty("server_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
