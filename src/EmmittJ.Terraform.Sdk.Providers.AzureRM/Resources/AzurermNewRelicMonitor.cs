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
    public TerraformLiteralProperty<string>? AccountCreationSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_creation_source");
        set => this.WithProperty("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// The ingestion_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IngestionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingestion_key");
        set => this.WithProperty("ingestion_key", value);
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
    /// The org_creation_source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgCreationSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_creation_source");
        set => this.WithProperty("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

}
