using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_connection_notification resource.
/// </summary>
public partial class AwsVpcEndpointConnectionNotification : TerraformResource
{
    public AwsVpcEndpointConnectionNotification(string name) : base("aws_vpc_endpoint_connection_notification", name)
    {
    }

    /// <summary>
    /// The connection_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionEvents is required")]
    [TerraformProperty("connection_events")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> ConnectionEvents { get; set; }

    /// <summary>
    /// The connection_notification_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionNotificationArn is required")]
    [TerraformProperty("connection_notification_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionNotificationArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_service_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VpcEndpointServiceId { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [TerraformProperty("notification_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NotificationType { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
