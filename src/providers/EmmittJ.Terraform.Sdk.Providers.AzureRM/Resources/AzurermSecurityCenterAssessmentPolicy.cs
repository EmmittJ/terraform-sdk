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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("name");
        SetOutput("categories");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("implementation_effort");
        SetOutput("remediation_description");
        SetOutput("severity");
        SetOutput("threats");
        SetOutput("user_impact");
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Categories
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("categories");
        set => SetProperty("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The implementation_effort attribute.
    /// </summary>
    public TerraformProperty<string> ImplementationEffort
    {
        get => GetRequiredOutput<TerraformProperty<string>>("implementation_effort");
        set => SetProperty("implementation_effort", value);
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    public TerraformProperty<string> RemediationDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remediation_description");
        set => SetProperty("remediation_description", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<string> Severity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Threats
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("threats");
        set => SetProperty("threats", value);
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    public TerraformProperty<string> UserImpact
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_impact");
        set => SetProperty("user_impact", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterAssessmentPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
