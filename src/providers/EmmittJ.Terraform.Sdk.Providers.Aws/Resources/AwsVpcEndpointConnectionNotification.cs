using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_connection_notification resource.
/// </summary>
public class AwsVpcEndpointConnectionNotification : TerraformResource
{
    public AwsVpcEndpointConnectionNotification(string name) : base("aws_vpc_endpoint_connection_notification", name)
    {
    }

    /// <summary>
    /// The connection_events attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionEvents is required")]
    [TerraformPropertyName("connection_events")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ConnectionEvents { get; set; }

    /// <summary>
    /// The connection_notification_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionNotificationArn is required")]
    [TerraformPropertyName("connection_notification_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionNotificationArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_service_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcEndpointServiceId { get; set; }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    [TerraformPropertyName("notification_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotificationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "notification_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
