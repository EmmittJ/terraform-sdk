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
    public HashSet<string>? ConnectionEvents
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("connection_events")?.Value;
        set => this.WithProperty("connection_events", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The connection_notification_arn attribute.
    /// </summary>
    public string? ConnectionNotificationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_notification_arn")?.Value;
        set => this.WithProperty("connection_notification_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    public string? VpcEndpointServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_service_id")?.Value;
        set => this.WithProperty("vpc_endpoint_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
