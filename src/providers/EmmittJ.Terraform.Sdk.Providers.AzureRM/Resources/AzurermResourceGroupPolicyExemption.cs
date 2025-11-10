using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupPolicyExemptionTimeoutsBlock : TerraformBlock
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
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("exemption_category");
        SetOutput("expires_on");
        SetOutput("id");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("policy_assignment_id");
        SetOutput("policy_definition_reference_ids");
        SetOutput("resource_group_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The exemption_category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExemptionCategory is required")]
    public required TerraformProperty<string> ExemptionCategory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("exemption_category");
        set => SetProperty("exemption_category", value);
    }

    /// <summary>
    /// The expires_on attribute.
    /// </summary>
    public TerraformProperty<string> ExpiresOn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expires_on");
        set => SetProperty("expires_on", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformProperty<string> Metadata
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformProperty<string> PolicyAssignmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_assignment_id");
        set => SetProperty("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> PolicyDefinitionReferenceIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("policy_definition_reference_ids");
        set => SetProperty("policy_definition_reference_ids", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformProperty<string> ResourceGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_id");
        set => SetProperty("resource_group_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceGroupPolicyExemptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
