using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_connection_notification resource.
/// </summary>
public class AwsVpcEndpointConnectionNotification : TerraformResource
{
    public AwsVpcEndpointConnectionNotification(string name) : base("aws_vpc_endpoint_connection_notification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("notification_type");
        SetOutput("state");
        SetOutput("connection_events");
        SetOutput("connection_notification_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("vpc_endpoint_id");
        SetOutput("vpc_endpoint_service_id");
    }

    /// <summary>
    /// The connection_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionEvents is required")]
    public HashSet<TerraformProperty<string>> ConnectionEvents
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("connection_events");
        set => SetProperty("connection_events", value);
    }

    /// <summary>
    /// The connection_notification_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionNotificationArn is required")]
    public required TerraformProperty<string> ConnectionNotificationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_notification_arn");
        set => SetProperty("connection_notification_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_id");
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcEndpointServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_service_id");
        set => SetProperty("vpc_endpoint_service_id", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    public TerraformExpression NotificationType => this["notification_type"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
