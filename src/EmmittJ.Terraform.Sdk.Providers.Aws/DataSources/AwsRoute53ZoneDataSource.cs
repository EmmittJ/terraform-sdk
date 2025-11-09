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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The private_zone attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateZone
    {
        get => GetProperty<TerraformProperty<bool>>("private_zone");
        set => this.WithProperty("private_zone", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
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
