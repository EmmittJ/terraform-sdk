using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_session_logger_association resource.
/// </summary>
public class AwsWorkspaceswebSessionLoggerAssociation : TerraformResource
{
    public AwsWorkspaceswebSessionLoggerAssociation(string name) : base("aws_workspacesweb_session_logger_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public string? PortalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("portal_arn")?.Value;
        set => this.WithProperty("portal_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public string? SessionLoggerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_logger_arn")?.Value;
        set => this.WithProperty("session_logger_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
