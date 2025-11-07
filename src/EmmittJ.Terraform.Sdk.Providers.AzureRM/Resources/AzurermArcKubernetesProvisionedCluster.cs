using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_arc_kubernetes_provisioned_cluster resource.
/// </summary>
public class AzurermArcKubernetesProvisionedCluster : TerraformResource
{
    public AzurermArcKubernetesProvisionedCluster(string name) : base("azurerm_arc_kubernetes_provisioned_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agent_version");
        this.DeclareOutput("distribution");
        this.DeclareOutput("infrastructure");
        this.DeclareOutput("kubernetes_version");
        this.DeclareOutput("offering");
        this.DeclareOutput("total_core_count");
        this.DeclareOutput("total_node_count");
    }

    /// <summary>
    /// The arc_agent_auto_upgrade_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ArcAgentAutoUpgradeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("arc_agent_auto_upgrade_enabled");
        set => this.WithProperty("arc_agent_auto_upgrade_enabled", value);
    }

    /// <summary>
    /// The arc_agent_desired_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ArcAgentDesiredVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_agent_desired_version");
        set => this.WithProperty("arc_agent_desired_version", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformExpression AgentVersion => this["agent_version"];

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    public TerraformExpression Distribution => this["distribution"];

    /// <summary>
    /// The infrastructure attribute.
    /// </summary>
    public TerraformExpression Infrastructure => this["infrastructure"];

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformExpression KubernetesVersion => this["kubernetes_version"];

    /// <summary>
    /// The offering attribute.
    /// </summary>
    public TerraformExpression Offering => this["offering"];

    /// <summary>
    /// The total_core_count attribute.
    /// </summary>
    public TerraformExpression TotalCoreCount => this["total_core_count"];

    /// <summary>
    /// The total_node_count attribute.
    /// </summary>
    public TerraformExpression TotalNodeCount => this["total_node_count"];

}
