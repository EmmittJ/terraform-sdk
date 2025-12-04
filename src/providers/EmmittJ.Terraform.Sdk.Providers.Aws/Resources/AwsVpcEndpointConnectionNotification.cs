using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_endpoint_connection_notification Terraform resource.
/// Manages a aws_vpc_endpoint_connection_notification resource.
/// </summary>
public partial class AwsVpcEndpointConnectionNotification(string name) : TerraformResource("aws_vpc_endpoint_connection_notification", name)
{
    /// <summary>
    /// The connection_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionEvents is required")]
    public required TerraformSet<string> ConnectionEvents
    {
        get => GetArgument<TerraformSet<string>>("connection_events");
        set => SetArgument("connection_events", value);
    }

    /// <summary>
    /// The connection_notification_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionNotificationArn is required")]
    public required TerraformValue<string> ConnectionNotificationArn
    {
        get => GetArgument<TerraformValue<string>>("connection_notification_arn");
        set => SetArgument("connection_notification_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointId
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointServiceId
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_service_id");
        set => SetArgument("vpc_endpoint_service_id", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    public TerraformValue<string> NotificationType
        => AsReference("notification_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

}
