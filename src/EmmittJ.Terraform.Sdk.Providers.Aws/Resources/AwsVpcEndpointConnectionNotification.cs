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
        this.DeclareOutput("notification_type");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The connection_events attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ConnectionEvents
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("connection_events");
        set => this.WithProperty("connection_events", value);
    }

    /// <summary>
    /// The connection_notification_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionNotificationArn
    {
        get => GetProperty<TerraformProperty<string>>("connection_notification_arn");
        set => this.WithProperty("connection_notification_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointServiceId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_service_id");
        set => this.WithProperty("vpc_endpoint_service_id", value);
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
