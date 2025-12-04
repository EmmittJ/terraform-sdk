using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_zone Terraform data source.
/// Retrieves information about a aws_route53_zone.
/// </summary>
public partial class AwsRoute53ZoneDataSource(string name) : TerraformDataSource("aws_route53_zone", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_zone attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateZone
    {
        get => GetArgument<TerraformValue<bool>>("private_zone");
        set => SetArgument("private_zone", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string>? ZoneId
    {
        get => GetArgument<TerraformValue<string>>("zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
        => AsReference("caller_reference");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
        => AsReference("comment");

    /// <summary>
    /// The linked_service_description attribute.
    /// </summary>
    public TerraformValue<string> LinkedServiceDescription
        => AsReference("linked_service_description");

    /// <summary>
    /// The linked_service_principal attribute.
    /// </summary>
    public TerraformValue<string> LinkedServicePrincipal
        => AsReference("linked_service_principal");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformList<string> NameServers
        => AsReference("name_servers");

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    public TerraformValue<string> PrimaryNameServer
        => AsReference("primary_name_server");

    /// <summary>
    /// The resource_record_set_count attribute.
    /// </summary>
    public TerraformValue<double> ResourceRecordSetCount
        => AsReference("resource_record_set_count");

}
