using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_ai_foundry resource.
/// </summary>
public class AzurermAiFoundry : TerraformResource
{
    public AzurermAiFoundry(string name) : base("azurerm_ai_foundry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("discovery_url");
        this.DeclareOutput("workspace_id");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationInsightsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
    }

    /// <summary>
    /// The high_business_impact_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HighBusinessImpactEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("high_business_impact_enabled");
        set => this.WithProperty("high_business_impact_enabled", value);
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
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
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
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrimaryUserAssignedIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_user_assigned_identity");
        set => this.WithProperty("primary_user_assigned_identity", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
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
    /// The discovery_url attribute.
    /// </summary>
    public TerraformExpression DiscoveryUrl => this["discovery_url"];

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceId => this["workspace_id"];

}
