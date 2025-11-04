using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_policy_attachment resource.
/// </summary>
public class AwsIotPolicyAttachment : TerraformResource
{
    public AwsIotPolicyAttachment(string name) : base("aws_iot_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The target attribute.
    /// </summary>
    public string? Target
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target")?.Value;
        set => this.WithProperty("target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
