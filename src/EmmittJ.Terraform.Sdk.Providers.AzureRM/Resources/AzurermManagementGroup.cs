using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_management_group resource.
/// </summary>
public class AzurermManagementGroup : TerraformResource
{
    public AzurermManagementGroup(string name) : base("azurerm_management_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("tenant_scoped_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public string? ParentManagementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_management_group_id")?.Value;
        set => this.WithProperty("parent_management_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public HashSet<string>? SubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subscription_ids")?.Value;
        set => this.WithProperty("subscription_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformExpression TenantScopedId => this["tenant_scoped_id"];

}
