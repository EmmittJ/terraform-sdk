using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("azure_active_directory_authentication");
        this.DeclareOutput("client_revoked_certificate");
        this.DeclareOutput("client_root_certificate");
        this.DeclareOutput("ipsec_policy");
        this.DeclareOutput("location");
        this.DeclareOutput("radius");
        this.DeclareOutput("tags");
        this.DeclareOutput("vpn_authentication_types");
        this.DeclareOutput("vpn_protocols");
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
