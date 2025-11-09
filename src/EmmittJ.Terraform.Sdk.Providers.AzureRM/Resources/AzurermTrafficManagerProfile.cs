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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_return attribute.
    /// </summary>
    public TerraformProperty<double>? MaxReturn
    {
        get => GetProperty<TerraformProperty<double>>("max_return");
        set => this.WithProperty("max_return", value);
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
    /// The profile_status attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileStatus
    {
        get => GetProperty<TerraformProperty<string>>("profile_status");
        set => this.WithProperty("profile_status", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficRoutingMethod
    {
        get => GetProperty<TerraformProperty<string>>("traffic_routing_method");
        set => this.WithProperty("traffic_routing_method", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrafficViewEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("traffic_view_enabled");
        set => this.WithProperty("traffic_view_enabled", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
