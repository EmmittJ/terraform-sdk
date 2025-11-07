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
    public TerraformProperty<bool>? AzureadAuthenticationOnly
    {
        get => GetProperty<TerraformProperty<bool>>("azuread_authentication_only");
        set => this.WithProperty("azuread_authentication_only", value);
    }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("compute_subnet_id");
        set => this.WithProperty("compute_subnet_id", value);
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataExfiltrationProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_exfiltration_protection_enabled");
        set => this.WithProperty("data_exfiltration_protection_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? LinkingAllowedForAadTenantIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("linking_allowed_for_aad_tenant_ids");
        set => this.WithProperty("linking_allowed_for_aad_tenant_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ManagedVirtualNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("managed_virtual_network_enabled");
        set => this.WithProperty("managed_virtual_network_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public TerraformProperty<string>? PurviewId
    {
        get => GetProperty<TerraformProperty<string>>("purview_id");
        set => this.WithProperty("purview_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sql_administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? SqlAdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("sql_administrator_login");
        set => this.WithProperty("sql_administrator_login", value);
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string>? SqlAdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("sql_administrator_login_password");
        set => this.WithProperty("sql_administrator_login_password", value);
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SqlIdentityControlEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sql_identity_control_enabled");
        set => this.WithProperty("sql_identity_control_enabled", value);
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageDataLakeGen2FilesystemId
    {
        get => GetProperty<TerraformProperty<string>>("storage_data_lake_gen2_filesystem_id");
        set => this.WithProperty("storage_data_lake_gen2_filesystem_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    public TerraformExpression ConnectivityEndpoints => this["connectivity_endpoints"];

}
