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
    /// The lock_exclude_actions attribute.
    /// </summary>
    public List<string>? LockExcludeActions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("lock_exclude_actions")?.Value;
        set => this.WithProperty("lock_exclude_actions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The lock_exclude_principals attribute.
    /// </summary>
    public List<string>? LockExcludePrincipals
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("lock_exclude_principals")?.Value;
        set => this.WithProperty("lock_exclude_principals", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The lock_mode attribute.
    /// </summary>
    public string? LockMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_mode")?.Value;
        set => this.WithProperty("lock_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameter_values attribute.
    /// </summary>
    public string? ParameterValues
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_values")?.Value;
        set => this.WithProperty("parameter_values", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public string? ResourceGroups
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_groups")?.Value;
        set => this.WithProperty("resource_groups", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_subscription_id attribute.
    /// </summary>
    public string? TargetSubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_subscription_id")?.Value;
        set => this.WithProperty("target_subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public string? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id")?.Value;
        set => this.WithProperty("version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
