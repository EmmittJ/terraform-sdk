using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_record resource.
/// </summary>
public class AwsRoute53Record : TerraformResource
{
    public AwsRoute53Record(string name) : base("aws_route53_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The allow_overwrite attribute.
    /// </summary>
    public bool? AllowOverwrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_overwrite")?.Value;
        set => this.WithProperty("allow_overwrite", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public string? HealthCheckId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_id")?.Value;
        set => this.WithProperty("health_check_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    public bool? MultivalueAnswerRoutingPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multivalue_answer_routing_policy")?.Value;
        set => this.WithProperty("multivalue_answer_routing_policy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The records attribute.
    /// </summary>
    public HashSet<string>? Records
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("records")?.Value;
        set => this.WithProperty("records", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public string? SetIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("set_identifier")?.Value;
        set => this.WithProperty("set_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public double? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ttl")?.Value;
        set => this.WithProperty("ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public string? ZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_id")?.Value;
        set => this.WithProperty("zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
