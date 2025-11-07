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
    public TerraformLiteralProperty<bool>? AllowOverwrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_overwrite");
        set => this.WithProperty("allow_overwrite", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HealthCheckId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_check_id");
        set => this.WithProperty("health_check_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultivalueAnswerRoutingPolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multivalue_answer_routing_policy");
        set => this.WithProperty("multivalue_answer_routing_policy", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The records attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Records
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("records");
        set => this.WithProperty("records", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SetIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("set_identifier");
        set => this.WithProperty("set_identifier", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
