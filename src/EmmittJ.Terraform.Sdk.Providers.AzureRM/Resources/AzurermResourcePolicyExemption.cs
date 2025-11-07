using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_resource_policy_exemption resource.
/// </summary>
public class AzurermResourcePolicyExemption : TerraformResource
{
    public AzurermResourcePolicyExemption(string name) : base("azurerm_resource_policy_exemption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The exemption_category attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExemptionCategory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("exemption_category");
        set => this.WithProperty("exemption_category", value);
    }

    /// <summary>
    /// The expires_on attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpiresOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expires_on");
        set => this.WithProperty("expires_on", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The policy_assignment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyAssignmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_assignment_id");
        set => this.WithProperty("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PolicyDefinitionReferenceIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("policy_definition_reference_ids");
        set => this.WithProperty("policy_definition_reference_ids", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

}
