using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_managed_instance_active_directory_administrator resource.
/// </summary>
public class AzurermMssqlManagedInstanceActiveDirectoryAdministrator : TerraformResource
{
    public AzurermMssqlManagedInstanceActiveDirectoryAdministrator(string name) : base("azurerm_mssql_managed_instance_active_directory_administrator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public bool? AzureadAuthenticationOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azuread_authentication_only")?.Value;
        set => this.WithProperty("azuread_authentication_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The login_username attribute.
    /// </summary>
    public string? LoginUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login_username")?.Value;
        set => this.WithProperty("login_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    public string? ManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_instance_id")?.Value;
        set => this.WithProperty("managed_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
