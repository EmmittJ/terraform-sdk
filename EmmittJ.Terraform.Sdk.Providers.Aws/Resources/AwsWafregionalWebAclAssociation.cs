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
