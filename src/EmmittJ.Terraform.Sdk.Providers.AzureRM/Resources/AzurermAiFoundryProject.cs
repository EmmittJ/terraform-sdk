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
    public TerraformLiteralProperty<string>? AiServicesHubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ai_services_hub_id");
        set => this.WithProperty("ai_services_hub_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    public TerraformExpression ProjectId => this["project_id"];

}
