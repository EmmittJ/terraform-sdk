using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRulesEngineRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorRulesEngineTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_frontdoor_rules_engine resource.
/// </summary>
public class AzurermFrontdoorRulesEngine : TerraformResource
{
    public AzurermFrontdoorRulesEngine(string name) : base("azurerm_frontdoor_rules_engine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frontdoor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontdoorName is required")]
    public required TerraformProperty<string> FrontdoorName
    {
        get => GetProperty<TerraformProperty<string>>("frontdoor_name");
        set => this.WithProperty("frontdoor_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Rule block(s) allowed")]
    public List<AzurermFrontdoorRulesEngineRuleBlock>? Rule
    {
        get => GetProperty<List<AzurermFrontdoorRulesEngineRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFrontdoorRulesEngineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFrontdoorRulesEngineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

}
