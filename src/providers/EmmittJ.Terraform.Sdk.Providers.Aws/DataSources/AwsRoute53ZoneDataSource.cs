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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_zone attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateZone
    {
        get => new TerraformReference<bool>(this, "private_zone");
        set => SetArgument("private_zone", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformValue<string> CallerReference
    {
        get => new TerraformReference<string>(this, "caller_reference");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string> Comment
    {
        get => new TerraformReference<string>(this, "comment");
    }

    /// <summary>
    /// The linked_service_description attribute.
    /// </summary>
    public TerraformValue<string> LinkedServiceDescription
    {
        get => new TerraformReference<string>(this, "linked_service_description");
    }

    /// <summary>
    /// The linked_service_principal attribute.
    /// </summary>
    public TerraformValue<string> LinkedServicePrincipal
    {
        get => new TerraformReference<string>(this, "linked_service_principal");
    }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformList<string> NameServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "name_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    public TerraformValue<string> PrimaryNameServer
    {
        get => new TerraformReference<string>(this, "primary_name_server");
    }

    /// <summary>
    /// The resource_record_set_count attribute.
    /// </summary>
    public TerraformValue<double> ResourceRecordSetCount
    {
        get => new TerraformReference<double>(this, "resource_record_set_count");
    }

}
