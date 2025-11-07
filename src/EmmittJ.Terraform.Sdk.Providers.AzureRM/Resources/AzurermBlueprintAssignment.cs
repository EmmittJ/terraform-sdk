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
    /// The lock_exclude_actions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? LockExcludeActions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("lock_exclude_actions");
        set => this.WithProperty("lock_exclude_actions", value);
    }

    /// <summary>
    /// The lock_exclude_principals attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? LockExcludePrincipals
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("lock_exclude_principals");
        set => this.WithProperty("lock_exclude_principals", value);
    }

    /// <summary>
    /// The lock_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LockMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_mode");
        set => this.WithProperty("lock_mode", value);
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
    /// The parameter_values attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParameterValues
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_values");
        set => this.WithProperty("parameter_values", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroups
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_groups");
        set => this.WithProperty("resource_groups", value);
    }

    /// <summary>
    /// The target_subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetSubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_subscription_id");
        set => this.WithProperty("target_subscription_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id");
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
