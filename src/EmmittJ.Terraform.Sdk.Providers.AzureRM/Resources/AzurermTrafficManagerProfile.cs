using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_traffic_manager_profile resource.
/// </summary>
public class AzurermTrafficManagerProfile : TerraformResource
{
    public AzurermTrafficManagerProfile(string name) : base("azurerm_traffic_manager_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
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
    /// The max_return attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxReturn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_return");
        set => this.WithProperty("max_return", value);
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
    /// The profile_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProfileStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_status");
        set => this.WithProperty("profile_status", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrafficRoutingMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_routing_method");
        set => this.WithProperty("traffic_routing_method", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TrafficViewEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("traffic_view_enabled");
        set => this.WithProperty("traffic_view_enabled", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
