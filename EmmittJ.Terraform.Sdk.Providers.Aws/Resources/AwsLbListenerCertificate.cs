using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_listener_certificate resource.
/// </summary>
public class AwsLbListenerCertificate : TerraformResource
{
    public AwsLbListenerCertificate(string name) : base("aws_lb_listener_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The listener_arn attribute.
    /// </summary>
    public string? ListenerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("listener_arn")?.Value;
        set => this.WithProperty("listener_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
