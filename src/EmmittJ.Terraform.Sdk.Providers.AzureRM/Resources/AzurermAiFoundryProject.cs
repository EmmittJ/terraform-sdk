using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_ai_foundry_project resource.
/// </summary>
public class AzurermAiFoundryProject : TerraformResource
{
    public AzurermAiFoundryProject(string name) : base("azurerm_ai_foundry_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("project_id");
    }

    /// <summary>
    /// The ai_services_hub_id attribute.
    /// </summary>
    public string? AiServicesHubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ai_services_hub_id")?.Value;
        set => this.WithProperty("ai_services_hub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The high_business_impact_enabled attribute.
    /// </summary>
    public bool? HighBusinessImpactEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("high_business_impact_enabled")?.Value;
        set => this.WithProperty("high_business_impact_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    public TerraformExpression ProjectId => this["project_id"];

}
