using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_workspace resource.
/// </summary>
public class AzurermMachineLearningWorkspace : TerraformResource
{
    public AzurermMachineLearningWorkspace(string name) : base("azurerm_machine_learning_workspace", name)
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
    public string? ApplicationInsightsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_insights_id")?.Value;
        set => this.WithProperty("application_insights_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public string? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id")?.Value;
        set => this.WithProperty("container_registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public string? FriendlyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("friendly_name")?.Value;
        set => this.WithProperty("friendly_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    public bool? HighBusinessImpact
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("high_business_impact")?.Value;
        set => this.WithProperty("high_business_impact", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The image_build_compute_name attribute.
    /// </summary>
    public string? ImageBuildComputeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_build_compute_name")?.Value;
        set => this.WithProperty("image_build_compute_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public string? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id")?.Value;
        set => this.WithProperty("key_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    public string? PrimaryUserAssignedIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_user_assigned_identity")?.Value;
        set => this.WithProperty("primary_user_assigned_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    public bool? ServiceSideEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("service_side_encryption_enabled")?.Value;
        set => this.WithProperty("service_side_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    public bool? V1LegacyModeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("v1_legacy_mode_enabled")?.Value;
        set => this.WithProperty("v1_legacy_mode_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
