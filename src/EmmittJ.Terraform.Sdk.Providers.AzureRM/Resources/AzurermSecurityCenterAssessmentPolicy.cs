using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_security_center_assessment_policy resource.
/// </summary>
public class AzurermSecurityCenterAssessmentPolicy : TerraformResource
{
    public AzurermSecurityCenterAssessmentPolicy(string name) : base("azurerm_security_center_assessment_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public HashSet<string>? Categories
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("categories")?.Value;
        set => this.WithProperty("categories", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The implementation_effort attribute.
    /// </summary>
    public string? ImplementationEffort
    {
        get => GetProperty<TerraformLiteralProperty<string>>("implementation_effort")?.Value;
        set => this.WithProperty("implementation_effort", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    public string? RemediationDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remediation_description")?.Value;
        set => this.WithProperty("remediation_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public string? Severity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("severity")?.Value;
        set => this.WithProperty("severity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    public HashSet<string>? Threats
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("threats")?.Value;
        set => this.WithProperty("threats", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    public string? UserImpact
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_impact")?.Value;
        set => this.WithProperty("user_impact", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
