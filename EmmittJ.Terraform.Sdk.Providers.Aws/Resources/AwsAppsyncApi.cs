using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_api resource.
/// </summary>
public class AwsAppsyncApi : TerraformResource
{
    public AwsAppsyncApi(string name) : base("aws_appsync_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_arn");
        this.DeclareOutput("api_id");
        this.DeclareOutput("dns");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("waf_web_acl_arn");
        this.DeclareOutput("xray_enabled");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner_contact attribute.
    /// </summary>
    public string? OwnerContact
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_contact")?.Value;
        set => this.WithProperty("owner_contact", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The api_arn attribute.
    /// </summary>
    public TerraformExpression ApiArn => this["api_arn"];

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformExpression ApiId => this["api_id"];

    /// <summary>
    /// The dns attribute.
    /// </summary>
    public TerraformExpression Dns => this["dns"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The waf_web_acl_arn attribute.
    /// </summary>
    public TerraformExpression WafWebAclArn => this["waf_web_acl_arn"];

    /// <summary>
    /// The xray_enabled attribute.
    /// </summary>
    public TerraformExpression XrayEnabled => this["xray_enabled"];

}
