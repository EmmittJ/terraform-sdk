using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_ip_group resource.
/// </summary>
public class AzurermIpGroup : TerraformResource
{
    public AzurermIpGroup(string name) : base("azurerm_ip_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("firewall_ids");
        this.DeclareOutput("firewall_policy_ids");
    }

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Cidrs
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("cidrs");
        set => this.WithProperty("cidrs", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The firewall_ids attribute.
    /// </summary>
    public TerraformExpression FirewallIds => this["firewall_ids"];

    /// <summary>
    /// The firewall_policy_ids attribute.
    /// </summary>
    public TerraformExpression FirewallPolicyIds => this["firewall_policy_ids"];

}
