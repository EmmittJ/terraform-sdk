using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_queue Terraform data source.
/// Retrieves information about a aws_connect_queue.
/// </summary>
public partial class AwsConnectQueueDataSource(string name) : TerraformDataSource("aws_connect_queue", name)
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
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
    /// The queue_id attribute.
    /// </summary>
    public TerraformValue<string>? QueueId
    {
        get => GetArgument<TerraformValue<string>>("queue_id");
        set => SetArgument("queue_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    public TerraformValue<string> HoursOfOperationId
        => AsReference("hours_of_operation_id");

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    public TerraformValue<double> MaxContacts
        => AsReference("max_contacts");

    /// <summary>
    /// The outbound_caller_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutboundCallerConfig
        => AsReference("outbound_caller_config");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
