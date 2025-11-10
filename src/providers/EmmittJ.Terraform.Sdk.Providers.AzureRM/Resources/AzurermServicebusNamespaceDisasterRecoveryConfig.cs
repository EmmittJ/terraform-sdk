using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_servicebus_namespace_disaster_recovery_config resource.
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfig : TerraformResource
{
    public AzurermServicebusNamespaceDisasterRecoveryConfig(string name) : base("azurerm_servicebus_namespace_disaster_recovery_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputefault_primary_key");
        this.WithOutputefault_secondary_key");
        this.WithOutputrimary_connection_string_alias");
        this.WithOutputecondary_connection_string_alias");
    }

    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    public TerraformProperty<string>? AliasAuthorizationRuleId
    {
        get => GetProperty<TerraformProperty<string>>("alias_authorization_rule_id");
        set => this.WithProperty("alias_authorization_rule_id", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerNamespaceId is required")]
    public required TerraformProperty<string> PartnerNamespaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("partner_namespace_id");
        set => this.WithProperty("partner_namespace_id", value);
    }

    /// <summary>
    /// The primary_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryNamespaceId is required")]
    public required TerraformProperty<string> PrimaryNamespaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("primary_namespace_id");
        set => this.WithProperty("primary_namespace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryKey => this["default_primary_key"];

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryKey => this["default_secondary_key"];

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionStringAlias => this["primary_connection_string_alias"];

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionStringAlias => this["secondary_connection_string_alias"];

}
