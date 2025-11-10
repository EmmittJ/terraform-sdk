using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncApiEventConfigBlock : TerraformBlock
{
}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The owner_contact attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerContact
    {
        get => GetProperty<TerraformProperty<string>>("owner_contact");
        set => this.WithProperty("owner_contact", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for event_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncApiEventConfigBlock>? EventConfig
    {
        get => GetProperty<List<AwsAppsyncApiEventConfigBlock>>("event_config");
        set => this.WithProperty("event_config", value);
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
