using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_resource_group_policy_exemption resource.
/// </summary>
public class AzurermResourceGroupPolicyExemption : TerraformResource
{
    public AzurermResourceGroupPolicyExemption(string name) : base("azurerm_resource_group_policy_exemption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The exemption_category attribute.
    /// </summary>
    public TerraformProperty<string>? ExemptionCategory
    {
        get => GetProperty<TerraformProperty<string>>("exemption_category");
        set => this.WithProperty("exemption_category", value);
    }

    /// <summary>
    /// The expires_on attribute.
    /// </summary>
    public TerraformProperty<string>? ExpiresOn
    {
        get => GetProperty<TerraformProperty<string>>("expires_on");
        set => this.WithProperty("expires_on", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformProperty<string>? Metadata
    {
        get => GetProperty<TerraformProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyAssignmentId
    {
        get => GetProperty<TerraformProperty<string>>("policy_assignment_id");
        set => this.WithProperty("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PolicyDefinitionReferenceIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("policy_definition_reference_ids");
        set => this.WithProperty("policy_definition_reference_ids", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupId
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_id");
        set => this.WithProperty("resource_group_id", value);
    }

}
