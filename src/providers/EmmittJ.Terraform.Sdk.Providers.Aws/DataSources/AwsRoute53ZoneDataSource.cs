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
        SetOutput("arn");
        SetOutput("caller_reference");
        SetOutput("comment");
        SetOutput("linked_service_description");
        SetOutput("linked_service_principal");
        SetOutput("name_servers");
        SetOutput("primary_name_server");
        SetOutput("resource_record_set_count");
        SetOutput("id");
        SetOutput("name");
        SetOutput("private_zone");
        SetOutput("tags");
        SetOutput("vpc_id");
        SetOutput("zone_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_zone attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateZone
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_zone");
        set => SetProperty("private_zone", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string> ZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_id");
        set => SetProperty("zone_id", value);
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
