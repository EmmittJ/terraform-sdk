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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subscriber_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriberId
    {
        get => GetProperty<TerraformProperty<string>>("subscriber_id");
        set => this.WithProperty("subscriber_id", value);
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
