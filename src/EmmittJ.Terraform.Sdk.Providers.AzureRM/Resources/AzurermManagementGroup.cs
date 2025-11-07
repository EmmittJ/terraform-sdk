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
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentManagementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("parent_management_group_id");
        set => this.WithProperty("parent_management_group_id", value);
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubscriptionIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subscription_ids");
        set => this.WithProperty("subscription_ids", value);
    }

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformExpression TenantScopedId => this["tenant_scoped_id"];

}
