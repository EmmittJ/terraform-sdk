using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackFqdnListTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_palo_alto_local_rulestack_fqdn_list resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackFqdnList : TerraformResource
{
    public AzurermPaloAltoLocalRulestackFqdnList(string name) : base("azurerm_palo_alto_local_rulestack_fqdn_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("audit_comment");
        SetOutput("description");
        SetOutput("fully_qualified_domain_names");
        SetOutput("id");
        SetOutput("name");
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
    /// The fully_qualified_domain_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullyQualifiedDomainNames is required")]
    public List<TerraformProperty<string>> FullyQualifiedDomainNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("fully_qualified_domain_names");
        set => SetProperty("fully_qualified_domain_names", value);
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
    public AzurermPaloAltoLocalRulestackFqdnListTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
