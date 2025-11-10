using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWafv2WebAclAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAclArn is required")]
    public required TerraformProperty<string> WebAclArn
    {
        get => GetProperty<TerraformProperty<string>>("web_acl_arn");
        set => this.WithProperty("web_acl_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsWafv2WebAclAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsWafv2WebAclAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
