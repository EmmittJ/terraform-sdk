using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdminGroupObjectIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("admin_group_object_ids");
        set => WithProperty("admin_group_object_ids", value);
    }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureRbacEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("azure_rbac_enabled");
        set => WithProperty("azure_rbac_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesProvisionedClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcKubernetesProvisionedClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_arc_kubernetes_provisioned_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<bool>? ArcAgentAutoUpgradeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("arc_agent_auto_upgrade_enabled");
        set => this.WithProperty("arc_agent_auto_upgrade_enabled", value);
    }

    /// <summary>
    /// The arc_agent_desired_version attribute.
    /// </summary>
    public TerraformProperty<string>? ArcAgentDesiredVersion
    {
        get => GetProperty<TerraformProperty<string>>("arc_agent_desired_version");
        set => this.WithProperty("arc_agent_desired_version", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    public List<AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock>? AzureActiveDirectory
    {
        get => GetProperty<List<AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock>>("azure_active_directory");
        set => this.WithProperty("azure_active_directory", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermArcKubernetesProvisionedClusterIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermArcKubernetesProvisionedClusterIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermArcKubernetesProvisionedClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermArcKubernetesProvisionedClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
