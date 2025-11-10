using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberNotificationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_securitylake_subscriber_notification resource.
/// </summary>
public class AwsSecuritylakeSubscriberNotification : TerraformResource
{
    public AwsSecuritylakeSubscriberNotification(string name) : base("aws_securitylake_subscriber_notification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("endpoint_id");
        SetOutput("id");
        SetOutput("subscriber_endpoint");
        SetOutput("region");
        SetOutput("subscriber_id");
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
    /// The subscriber_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriberId is required")]
    public required TerraformProperty<string> SubscriberId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscriber_id");
        set => SetProperty("subscriber_id", value);
    }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSecuritylakeSubscriberNotificationConfigurationBlock>? Configuration
    {
        set => SetProperty("configuration", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformExpression EndpointId => this["endpoint_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    public TerraformExpression SubscriberEndpoint => this["subscriber_endpoint"];

}
