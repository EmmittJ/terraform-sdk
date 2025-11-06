using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_zone.
/// </summary>
public class AwsRoute53ZoneDataSource : TerraformDataSource
{
    public AwsRoute53ZoneDataSource(string name) : base("aws_route53_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("caller_reference");
        this.DeclareOutput("comment");
        this.DeclareOutput("linked_service_description");
        this.DeclareOutput("linked_service_principal");
        this.DeclareOutput("name_servers");
        this.DeclareOutput("primary_name_server");
        this.DeclareOutput("resource_record_set_count");
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
    /// The private_zone attribute.
    /// </summary>
    public bool? PrivateZone
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_zone")?.Value;
        set => this.WithProperty("private_zone", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformExpression CallerReference => this["caller_reference"];

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformExpression Comment => this["comment"];

    /// <summary>
    /// The linked_service_description attribute.
    /// </summary>
    public TerraformExpression LinkedServiceDescription => this["linked_service_description"];

    /// <summary>
    /// The linked_service_principal attribute.
    /// </summary>
    public TerraformExpression LinkedServicePrincipal => this["linked_service_principal"];

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformExpression NameServers => this["name_servers"];

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    public TerraformExpression PrimaryNameServer => this["primary_name_server"];

    /// <summary>
    /// The resource_record_set_count attribute.
    /// </summary>
    public TerraformExpression ResourceRecordSetCount => this["resource_record_set_count"];

}
