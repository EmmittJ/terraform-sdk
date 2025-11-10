using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for status in .
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAssessmentStatusBlock : TerraformBlock
{
    /// <summary>
    /// The cause attribute.
    /// </summary>
    public TerraformProperty<string>? Cause
    {
        get => GetProperty<TerraformProperty<string>>("cause");
        set => WithProperty("cause", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformProperty<string> Code
    {
        get => GetProperty<TerraformProperty<string>>("code");
        set => WithProperty("code", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_security_center_assessment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSecurityCenterAssessment : TerraformResource
{
    public AzurermSecurityCenterAssessment(string name) : base("azurerm_security_center_assessment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_data attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalData
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_data");
        set => this.WithProperty("additional_data", value);
    }

    /// <summary>
    /// The assessment_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentPolicyId is required")]
    public required TerraformProperty<string> AssessmentPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("assessment_policy_id");
        set => this.WithProperty("assessment_policy_id", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// Block for status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Status block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Status block(s) allowed")]
    public List<AzurermSecurityCenterAssessmentStatusBlock>? Status
    {
        get => GetProperty<List<AzurermSecurityCenterAssessmentStatusBlock>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterAssessmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSecurityCenterAssessmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
