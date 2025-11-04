using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_wafv2_web_acl_association resource.
/// </summary>
public class AwsWafv2WebAclAssociation : TerraformResource
{
    public AwsWafv2WebAclAssociation(string name) : base("aws_wafv2_web_acl_association", name)
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
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    public string? WebAclArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_acl_arn")?.Value;
        set => this.WithProperty("web_acl_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
