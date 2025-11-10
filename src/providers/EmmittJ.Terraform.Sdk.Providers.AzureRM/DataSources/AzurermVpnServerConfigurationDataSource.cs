using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnServerConfigurationDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_vpn_server_configuration.
/// </summary>
public class AzurermVpnServerConfigurationDataSource : TerraformDataSource
{
    public AzurermVpnServerConfigurationDataSource(string name) : base("azurerm_vpn_server_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("azure_active_directory_authentication");
        this.WithOutput("client_revoked_certificate");
        this.WithOutput("client_root_certificate");
        this.WithOutput("ipsec_policy");
        this.WithOutput("location");
        this.WithOutput("radius");
        this.WithOutput("tags");
        this.WithOutput("vpn_authentication_types");
        this.WithOutput("vpn_protocols");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnServerConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVpnServerConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    public TerraformExpression AzureActiveDirectoryAuthentication => this["azure_active_directory_authentication"];

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    public TerraformExpression ClientRevokedCertificate => this["client_revoked_certificate"];

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    public TerraformExpression ClientRootCertificate => this["client_root_certificate"];

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    public TerraformExpression IpsecPolicy => this["ipsec_policy"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The radius attribute.
    /// </summary>
    public TerraformExpression Radius => this["radius"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    public TerraformExpression VpnAuthenticationTypes => this["vpn_authentication_types"];

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    public TerraformExpression VpnProtocols => this["vpn_protocols"];

}
