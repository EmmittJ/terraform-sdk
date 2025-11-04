using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("endpoint_id");
        this.DeclareOutput("id");
        this.DeclareOutput("subscriber_endpoint");
    }

    /// <summary>
    /// The subscriber_id attribute.
    /// </summary>
    public string? SubscriberId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscriber_id")?.Value;
        set => this.WithProperty("subscriber_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
