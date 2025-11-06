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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
