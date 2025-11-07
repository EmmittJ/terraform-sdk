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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The standards_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StandardsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("standards_arn");
        set => this.WithProperty("standards_arn", value);
    }

}
