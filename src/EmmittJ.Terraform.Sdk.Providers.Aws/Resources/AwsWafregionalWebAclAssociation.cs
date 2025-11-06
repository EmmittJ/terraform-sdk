using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_wafregional_web_acl_association resource.
/// </summary>
public class AwsWafregionalWebAclAssociation : TerraformResource
{
    public AwsWafregionalWebAclAssociation(string name) : base("aws_wafregional_web_acl_association", name)
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
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    public string? WebAclId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_acl_id")?.Value;
        set => this.WithProperty("web_acl_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
