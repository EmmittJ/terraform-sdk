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
    public TerraformLiteralProperty<HashSet<string>>? Categories
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("categories");
        set => this.WithProperty("categories", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The implementation_effort attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImplementationEffort
    {
        get => GetProperty<TerraformLiteralProperty<string>>("implementation_effort");
        set => this.WithProperty("implementation_effort", value);
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RemediationDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remediation_description");
        set => this.WithProperty("remediation_description", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Severity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Threats
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("threats");
        set => this.WithProperty("threats", value);
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserImpact
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_impact");
        set => this.WithProperty("user_impact", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
