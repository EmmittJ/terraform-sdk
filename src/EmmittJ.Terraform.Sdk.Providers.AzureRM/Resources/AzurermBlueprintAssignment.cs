using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_blueprint_assignment resource.
/// </summary>
public class AzurermBlueprintAssignment : TerraformResource
{
    public AzurermBlueprintAssignment(string name) : base("azurerm_blueprint_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("blueprint_name");
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("type");
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
    /// The lock_exclude_actions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? LockExcludeActions
    {
        get => GetProperty<TerraformProperty<List<string>>>("lock_exclude_actions");
        set => this.WithProperty("lock_exclude_actions", value);
    }

    /// <summary>
    /// The lock_exclude_principals attribute.
    /// </summary>
    public TerraformProperty<List<string>>? LockExcludePrincipals
    {
        get => GetProperty<TerraformProperty<List<string>>>("lock_exclude_principals");
        set => this.WithProperty("lock_exclude_principals", value);
    }

    /// <summary>
    /// The lock_mode attribute.
    /// </summary>
    public TerraformProperty<string>? LockMode
    {
        get => GetProperty<TerraformProperty<string>>("lock_mode");
        set => this.WithProperty("lock_mode", value);
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
    /// The parameter_values attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterValues
    {
        get => GetProperty<TerraformProperty<string>>("parameter_values");
        set => this.WithProperty("parameter_values", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroups
    {
        get => GetProperty<TerraformProperty<string>>("resource_groups");
        set => this.WithProperty("resource_groups", value);
    }

    /// <summary>
    /// The target_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetSubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("target_subscription_id");
        set => this.WithProperty("target_subscription_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// The blueprint_name attribute.
    /// </summary>
    public TerraformExpression BlueprintName => this["blueprint_name"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
