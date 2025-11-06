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
    public bool? AzureadAuthenticationOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azuread_authentication_only")?.Value;
        set => this.WithProperty("azuread_authentication_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    public string? ComputeSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_subnet_id")?.Value;
        set => this.WithProperty("compute_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    public bool? DataExfiltrationProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_exfiltration_protection_enabled")?.Value;
        set => this.WithProperty("data_exfiltration_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    public List<string>? LinkingAllowedForAadTenantIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("linking_allowed_for_aad_tenant_ids")?.Value;
        set => this.WithProperty("linking_allowed_for_aad_tenant_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public string? ManagedResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resource_group_name")?.Value;
        set => this.WithProperty("managed_resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public bool? ManagedVirtualNetworkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed_virtual_network_enabled")?.Value;
        set => this.WithProperty("managed_virtual_network_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public string? PurviewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("purview_id")?.Value;
        set => this.WithProperty("purview_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sql_administrator_login attribute.
    /// </summary>
    public string? SqlAdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_administrator_login")?.Value;
        set => this.WithProperty("sql_administrator_login", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    public string? SqlAdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_administrator_login_password")?.Value;
        set => this.WithProperty("sql_administrator_login_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    public bool? SqlIdentityControlEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sql_identity_control_enabled")?.Value;
        set => this.WithProperty("sql_identity_control_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    public string? StorageDataLakeGen2FilesystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_data_lake_gen2_filesystem_id")?.Value;
        set => this.WithProperty("storage_data_lake_gen2_filesystem_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    public TerraformExpression ConnectivityEndpoints => this["connectivity_endpoints"];

}
