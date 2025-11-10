using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackPrefixListTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_palo_alto_local_rulestack_prefix_list resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackPrefixList : TerraformResource
{
    public AzurermPaloAltoLocalRulestackPrefixList(string name) : base("azurerm_palo_alto_local_rulestack_prefix_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("audit_comment");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("prefix_list");
        SetOutput("rulestack_id");
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformProperty<string> AuditComment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("audit_comment");
        set => SetProperty("audit_comment", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The prefix_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixList is required")]
    public List<TerraformProperty<string>> PrefixList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("prefix_list");
        set => SetProperty("prefix_list", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rulestack_id");
        set => SetProperty("rulestack_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackPrefixListTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
