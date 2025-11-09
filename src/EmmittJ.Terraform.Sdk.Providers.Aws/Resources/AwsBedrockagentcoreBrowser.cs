using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_browser resource.
/// </summary>
public class AwsBedrockagentcoreBrowser : TerraformResource
{
    public AwsBedrockagentcoreBrowser(string name) : base("aws_bedrockagentcore_browser", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("browser_arn");
        this.DeclareOutput("browser_id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The browser_arn attribute.
    /// </summary>
    public TerraformExpression BrowserArn => this["browser_arn"];

    /// <summary>
    /// The browser_id attribute.
    /// </summary>
    public TerraformExpression BrowserId => this["browser_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
