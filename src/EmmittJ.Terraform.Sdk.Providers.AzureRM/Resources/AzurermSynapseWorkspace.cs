using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_workspace resource.
/// </summary>
public class AzurermSynapseWorkspace : TerraformResource
{
    public AzurermSynapseWorkspace(string name) : base("azurerm_synapse_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connectivity_endpoints");
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
    /// The compute_subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComputeSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_subnet_id");
        set => this.WithProperty("compute_subnet_id", value);
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DataExfiltrationProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_exfiltration_protection_enabled");
        set => this.WithProperty("data_exfiltration_protection_enabled", value);
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
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? LinkingAllowedForAadTenantIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("linking_allowed_for_aad_tenant_ids");
        set => this.WithProperty("linking_allowed_for_aad_tenant_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ManagedVirtualNetworkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed_virtual_network_enabled");
        set => this.WithProperty("managed_virtual_network_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PurviewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("purview_id");
        set => this.WithProperty("purview_id", value);
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
    /// The sql_administrator_login attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlAdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_administrator_login");
        set => this.WithProperty("sql_administrator_login", value);
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlAdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_administrator_login_password");
        set => this.WithProperty("sql_administrator_login_password", value);
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SqlIdentityControlEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sql_identity_control_enabled");
        set => this.WithProperty("sql_identity_control_enabled", value);
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageDataLakeGen2FilesystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_data_lake_gen2_filesystem_id");
        set => this.WithProperty("storage_data_lake_gen2_filesystem_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    public TerraformExpression ConnectivityEndpoints => this["connectivity_endpoints"];

}
