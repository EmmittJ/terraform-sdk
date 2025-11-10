using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_app_configuration.
/// </summary>
public class AzurermAppConfigurationDataSource : TerraformDataSource
{
    public AzurermAppConfigurationDataSource(string name) : base("azurerm_app_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("data_plane_proxy_authentication_mode");
        this.DeclareOutput("data_plane_proxy_private_link_delegation_enabled");
        this.DeclareOutput("encryption");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("identity");
        this.DeclareOutput("local_auth_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("primary_read_key");
        this.DeclareOutput("primary_write_key");
        this.DeclareOutput("public_network_access");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("purge_protection_enabled");
        this.DeclareOutput("replica");
        this.DeclareOutput("secondary_read_key");
        this.DeclareOutput("secondary_write_key");
        this.DeclareOutput("sku");
        this.DeclareOutput("soft_delete_retention_days");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    public TerraformExpression DataPlaneProxyAuthenticationMode => this["data_plane_proxy_authentication_mode"];

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    public TerraformExpression DataPlaneProxyPrivateLinkDelegationEnabled => this["data_plane_proxy_private_link_delegation_enabled"];

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformExpression Encryption => this["encryption"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformExpression LocalAuthEnabled => this["local_auth_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    public TerraformExpression PrimaryReadKey => this["primary_read_key"];

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    public TerraformExpression PrimaryWriteKey => this["primary_write_key"];

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccess => this["public_network_access"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformExpression PurgeProtectionEnabled => this["purge_protection_enabled"];

    /// <summary>
    /// The replica attribute.
    /// </summary>
    public TerraformExpression Replica => this["replica"];

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    public TerraformExpression SecondaryReadKey => this["secondary_read_key"];

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    public TerraformExpression SecondaryWriteKey => this["secondary_write_key"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformExpression SoftDeleteRetentionDays => this["soft_delete_retention_days"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
