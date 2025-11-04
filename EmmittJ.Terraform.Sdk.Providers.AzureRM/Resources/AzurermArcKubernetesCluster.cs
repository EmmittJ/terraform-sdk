using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_arc_kubernetes_cluster resource.
/// </summary>
public class AzurermArcKubernetesCluster : TerraformResource
{
    public AzurermArcKubernetesCluster(string name) : base("azurerm_arc_kubernetes_cluster", name)
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
    /// The agent_public_key_certificate attribute.
    /// </summary>
    public string? AgentPublicKeyCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_public_key_certificate")?.Value;
        set => this.WithProperty("agent_public_key_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
