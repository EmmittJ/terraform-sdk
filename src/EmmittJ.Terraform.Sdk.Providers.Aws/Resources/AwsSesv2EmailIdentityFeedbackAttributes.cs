using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_email_identity_feedback_attributes resource.
/// </summary>
public class AwsSesv2EmailIdentityFeedbackAttributes : TerraformResource
{
    public AwsSesv2EmailIdentityFeedbackAttributes(string name) : base("aws_sesv2_email_identity_feedback_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The email_forwarding_enabled attribute.
    /// </summary>
    public bool? EmailForwardingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("email_forwarding_enabled")?.Value;
        set => this.WithProperty("email_forwarding_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    public string? EmailIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_identity")?.Value;
        set => this.WithProperty("email_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
