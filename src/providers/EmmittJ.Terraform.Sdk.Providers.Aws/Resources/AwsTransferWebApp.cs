using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_provider_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferWebAppIdentityProviderDetailsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_transfer_web_app resource.
/// </summary>
public class AwsTransferWebApp : TerraformResource
{
    public AwsTransferWebApp(string name) : base("aws_transfer_web_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("tags_all");
        SetOutput("web_app_id");
        SetOutput("access_endpoint");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("web_app_endpoint_policy");
        SetOutput("web_app_units");
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> AccessEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_endpoint");
        set => SetProperty("access_endpoint", value);
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
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    public TerraformProperty<string> WebAppEndpointPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_app_endpoint_policy");
        set => SetProperty("web_app_endpoint_policy", value);
    }

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    public List<TerraformProperty<object>> WebAppUnits
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("web_app_units");
        set => SetProperty("web_app_units", value);
    }

    /// <summary>
    /// Block for identity_provider_details.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTransferWebAppIdentityProviderDetailsBlock>? IdentityProviderDetails
    {
        set => SetProperty("identity_provider_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    public TerraformExpression WebAppId => this["web_app_id"];

}
