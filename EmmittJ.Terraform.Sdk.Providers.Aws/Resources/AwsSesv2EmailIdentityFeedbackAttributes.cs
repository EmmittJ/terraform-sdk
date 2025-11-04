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

}
