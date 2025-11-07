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
    public TerraformProperty<HashSet<string>>? Categories
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("categories");
        set => this.WithProperty("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The implementation_effort attribute.
    /// </summary>
    public TerraformProperty<string>? ImplementationEffort
    {
        get => GetProperty<TerraformProperty<string>>("implementation_effort");
        set => this.WithProperty("implementation_effort", value);
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    public TerraformProperty<string>? RemediationDescription
    {
        get => GetProperty<TerraformProperty<string>>("remediation_description");
        set => this.WithProperty("remediation_description", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<string>? Severity
    {
        get => GetProperty<TerraformProperty<string>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Threats
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("threats");
        set => this.WithProperty("threats", value);
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    public TerraformProperty<string>? UserImpact
    {
        get => GetProperty<TerraformProperty<string>>("user_impact");
        set => this.WithProperty("user_impact", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
