using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_spring_cloud_service.
/// </summary>
public class AzurermSpringCloudServiceDataSource : TerraformDataSource
{
    public AzurermSpringCloudServiceDataSource(string name) : base("azurerm_spring_cloud_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("config_server_git_setting");
        this.DeclareOutput("location");
        this.DeclareOutput("outbound_public_ip_addresses");
        this.DeclareOutput("required_network_traffic_rules");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The config_server_git_setting attribute.
    /// </summary>
    public TerraformExpression ConfigServerGitSetting => this["config_server_git_setting"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The outbound_public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundPublicIpAddresses => this["outbound_public_ip_addresses"];

    /// <summary>
    /// The required_network_traffic_rules attribute.
    /// </summary>
    public TerraformExpression RequiredNetworkTrafficRules => this["required_network_traffic_rules"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
