using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_new_relic_monitor resource.
/// </summary>
public class AzurermNewRelicMonitor : TerraformResource
{
    public AzurermNewRelicMonitor(string name) : base("azurerm_new_relic_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    public string? AccountCreationSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_creation_source")?.Value;
        set => this.WithProperty("account_creation_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ingestion_key attribute.
    /// </summary>
    public string? IngestionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingestion_key")?.Value;
        set => this.WithProperty("ingestion_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The org_creation_source attribute.
    /// </summary>
    public string? OrgCreationSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_creation_source")?.Value;
        set => this.WithProperty("org_creation_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public string? OrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_id")?.Value;
        set => this.WithProperty("organization_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The user_id attribute.
    /// </summary>
    public string? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id")?.Value;
        set => this.WithProperty("user_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
