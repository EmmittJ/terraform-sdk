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
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public List<string>? Applications
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("applications")?.Value;
        set => this.WithProperty("applications", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public string? AuditComment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("audit_comment")?.Value;
        set => this.WithProperty("audit_comment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    public string? DecryptionRuleType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("decryption_rule_type")?.Value;
        set => this.WithProperty("decryption_rule_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The inspection_certificate_id attribute.
    /// </summary>
    public string? InspectionCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inspection_certificate_id")?.Value;
        set => this.WithProperty("inspection_certificate_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    public bool? LoggingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("logging_enabled")?.Value;
        set => this.WithProperty("logging_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The negate_destination attribute.
    /// </summary>
    public bool? NegateDestination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("negate_destination")?.Value;
        set => this.WithProperty("negate_destination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    public bool? NegateSource
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("negate_source")?.Value;
        set => this.WithProperty("negate_source", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    public List<string>? ProtocolPorts
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("protocol_ports")?.Value;
        set => this.WithProperty("protocol_ports", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    public string? RulestackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rulestack_id")?.Value;
        set => this.WithProperty("rulestack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
