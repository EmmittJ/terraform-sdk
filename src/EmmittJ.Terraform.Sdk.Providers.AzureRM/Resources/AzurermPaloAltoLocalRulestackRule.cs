using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_rule resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackRule : TerraformResource
{
    public AzurermPaloAltoLocalRulestackRule(string name) : base("azurerm_palo_alto_local_rulestack_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Applications
    {
        get => GetProperty<TerraformProperty<List<string>>>("applications");
        set => this.WithProperty("applications", value);
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformProperty<string>? AuditComment
    {
        get => GetProperty<TerraformProperty<string>>("audit_comment");
        set => this.WithProperty("audit_comment", value);
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    public TerraformProperty<string>? DecryptionRuleType
    {
        get => GetProperty<TerraformProperty<string>>("decryption_rule_type");
        set => this.WithProperty("decryption_rule_type", value);
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
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The inspection_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? InspectionCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("inspection_certificate_id");
        set => this.WithProperty("inspection_certificate_id", value);
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LoggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("logging_enabled");
        set => this.WithProperty("logging_enabled", value);
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
    /// The negate_destination attribute.
    /// </summary>
    public TerraformProperty<bool>? NegateDestination
    {
        get => GetProperty<TerraformProperty<bool>>("negate_destination");
        set => this.WithProperty("negate_destination", value);
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    public TerraformProperty<bool>? NegateSource
    {
        get => GetProperty<TerraformProperty<bool>>("negate_source");
        set => this.WithProperty("negate_source", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ProtocolPorts
    {
        get => GetProperty<TerraformProperty<List<string>>>("protocol_ports");
        set => this.WithProperty("protocol_ports", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    public TerraformProperty<string>? RulestackId
    {
        get => GetProperty<TerraformProperty<string>>("rulestack_id");
        set => this.WithProperty("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
