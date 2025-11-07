using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_security_center_assessment resource.
/// </summary>
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
    public TerraformLiteralProperty<Dictionary<string, string>>? AdditionalData
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_data");
        set => this.WithProperty("additional_data", value);
    }

    /// <summary>
    /// The assessment_policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AssessmentPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assessment_policy_id");
        set => this.WithProperty("assessment_policy_id", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

}
