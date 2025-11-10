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
        SetOutput("api_arn");
        SetOutput("api_id");
        SetOutput("dns");
        SetOutput("tags_all");
        SetOutput("waf_web_acl_arn");
        SetOutput("xray_enabled");
        SetOutput("name");
        SetOutput("owner_contact");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The owner_contact attribute.
    /// </summary>
    public TerraformProperty<string> OwnerContact
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_contact");
        set => SetProperty("owner_contact", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for event_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncApiEventConfigBlock>? EventConfig
    {
        set => SetProperty("event_config", value);
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
