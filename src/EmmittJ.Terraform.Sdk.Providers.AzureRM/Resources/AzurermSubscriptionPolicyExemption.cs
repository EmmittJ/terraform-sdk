using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subscription_policy_exemption resource.
/// </summary>
public class AzurermSubscriptionPolicyExemption : TerraformResource
{
    public AzurermSubscriptionPolicyExemption(string name) : base("azurerm_subscription_policy_exemption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The exemption_category attribute.
    /// </summary>
    public string? ExemptionCategory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("exemption_category")?.Value;
        set => this.WithProperty("exemption_category", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expires_on attribute.
    /// </summary>
    public string? ExpiresOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expires_on")?.Value;
        set => this.WithProperty("expires_on", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The metadata attribute.
    /// </summary>
    public string? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_assignment_id attribute.
    /// </summary>
    public string? PolicyAssignmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_assignment_id")?.Value;
        set => this.WithProperty("policy_assignment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_definition_reference_ids attribute.
    /// </summary>
    public List<string>? PolicyDefinitionReferenceIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("policy_definition_reference_ids")?.Value;
        set => this.WithProperty("policy_definition_reference_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
