using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_email_identity_policy resource.
/// </summary>
public class AwsSesv2EmailIdentityPolicy : TerraformResource
{
    public AwsSesv2EmailIdentityPolicy(string name) : base("aws_sesv2_email_identity_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public string? PolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_name")?.Value;
        set => this.WithProperty("policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
