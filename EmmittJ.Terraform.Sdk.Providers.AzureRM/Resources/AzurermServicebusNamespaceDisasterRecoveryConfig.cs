using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("default_primary_key");
        this.DeclareOutput("default_secondary_key");
        this.DeclareOutput("primary_connection_string_alias");
        this.DeclareOutput("secondary_connection_string_alias");
    }

    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    public string? AliasAuthorizationRuleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias_authorization_rule_id")?.Value;
        set => this.WithProperty("alias_authorization_rule_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    public string? PartnerNamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partner_namespace_id")?.Value;
        set => this.WithProperty("partner_namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The primary_namespace_id attribute.
    /// </summary>
    public string? PrimaryNamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_namespace_id")?.Value;
        set => this.WithProperty("primary_namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
