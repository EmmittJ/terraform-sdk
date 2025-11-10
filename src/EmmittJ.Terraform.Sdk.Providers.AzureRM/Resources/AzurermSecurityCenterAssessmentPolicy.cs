using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public HashSet<TerraformProperty<string>>? Categories
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("categories");
        set => this.WithProperty("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    public HashSet<TerraformProperty<string>>? Threats
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("threats");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterAssessmentPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSecurityCenterAssessmentPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
