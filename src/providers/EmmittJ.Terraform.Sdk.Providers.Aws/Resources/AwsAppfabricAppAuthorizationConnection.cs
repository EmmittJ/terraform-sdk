using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_request in .
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationConnectionAuthRequestBlock : TerraformBlock
{
    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformProperty<string> Code
    {
        set => SetProperty("code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    public required TerraformProperty<string> RedirectUri
    {
        set => SetProperty("redirect_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAppfabricAppAuthorizationConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_appfabric_app_authorization_connection resource.
/// </summary>
public class AwsAppfabricAppAuthorizationConnection : TerraformResource
{
    public AwsAppfabricAppAuthorizationConnection(string name) : base("aws_appfabric_app_authorization_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app");
        SetOutput("id");
        SetOutput("tenant");
        SetOutput("app_authorization_arn");
        SetOutput("app_bundle_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The app_authorization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppAuthorizationArn is required")]
    public required TerraformProperty<string> AppAuthorizationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_authorization_arn");
        set => SetProperty("app_authorization_arn", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    public required TerraformProperty<string> AppBundleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_bundle_arn");
        set => SetProperty("app_bundle_arn", value);
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
    /// Block for auth_request.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppfabricAppAuthorizationConnectionAuthRequestBlock>? AuthRequest
    {
        set => SetProperty("auth_request", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAppfabricAppAuthorizationConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    public TerraformExpression App => this["app"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformExpression Tenant => this["tenant"];

}
