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
    public TerraformLiteralProperty<bool>? AzureadAuthenticationOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azuread_authentication_only");
        set => this.WithProperty("azuread_authentication_only", value);
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
    /// The login_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoginUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("login_username");
        set => this.WithProperty("login_username", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
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
    /// The tenant_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
