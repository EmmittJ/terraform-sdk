using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_routing_profile Terraform data source.
/// Retrieves information about a aws_connect_routing_profile.
/// </summary>
public partial class AwsConnectRoutingProfileDataSource(string name) : TerraformDataSource("aws_connect_routing_profile", name)
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformValue<string> RoutingProfileId
    {
        get => new TerraformReference<string>(this, "routing_profile_id");
        set => SetArgument("routing_profile_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultOutboundQueueId
    {
        get => new TerraformReference<string>(this, "default_outbound_queue_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The media_concurrencies attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> MediaConcurrencies
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "media_concurrencies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The queue_configs attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> QueueConfigs
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "queue_configs").ResolveNodes(ctx));
    }

}
