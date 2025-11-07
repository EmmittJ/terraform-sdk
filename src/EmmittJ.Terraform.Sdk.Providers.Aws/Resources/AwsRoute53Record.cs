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
    public TerraformProperty<bool>? AllowOverwrite
    {
        get => GetProperty<TerraformProperty<bool>>("allow_overwrite");
        set => this.WithProperty("allow_overwrite", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckId
    {
        get => GetProperty<TerraformProperty<string>>("health_check_id");
        set => this.WithProperty("health_check_id", value);
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
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? MultivalueAnswerRoutingPolicy
    {
        get => GetProperty<TerraformProperty<bool>>("multivalue_answer_routing_policy");
        set => this.WithProperty("multivalue_answer_routing_policy", value);
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
    /// The records attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Records
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("records");
        set => this.WithProperty("records", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SetIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("set_identifier");
        set => this.WithProperty("set_identifier", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
