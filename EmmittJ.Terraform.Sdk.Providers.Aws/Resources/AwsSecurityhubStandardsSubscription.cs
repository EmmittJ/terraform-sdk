using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_standards_subscription resource.
/// </summary>
public class AwsSecurityhubStandardsSubscription : TerraformResource
{
    public AwsSecurityhubStandardsSubscription(string name) : base("aws_securityhub_standards_subscription", name)
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
    /// The standards_arn attribute.
    /// </summary>
    public string? StandardsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("standards_arn")?.Value;
        set => this.WithProperty("standards_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
